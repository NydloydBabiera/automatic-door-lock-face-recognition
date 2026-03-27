using automatic_door_lock_face_recognition.Classess;
using automatic_door_lock_face_recognition.Services;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace automatic_door_lock_face_recognition
{
    public partial class MainForm : Form
    {
        private DBPostgress _db;
        private CameraService _camera;
        private FaceRecognitionService _faceService;
        string cameraUrl = GlobalVariables.CameralUrl;
        private bool _recognizing = true;
        private string _samplesDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "samples");
        private Dictionary<int, string> _labelToName = new Dictionary<int, string>();
        private SerialPort port;
        private Image _latestImage;
        private int scanCount = 0;
        private string[] rfidTags =
        {
             "e28069150000600f0e023daf",
             "e28069150000700f0e0525af",
             "e28069150000700f0e01f5af",
             "e28069150000600f0e01fdaf",
             "e28069150000600f0e051daf",
             "e28069150000700f0e04edaf",
             "e28069150000600f0e04e5af",
             "e28069150000600f0e052daf",
             "e28069150000700f0e022daf",
             "e20000197408005416606d4e",
             "e20000197408005116606d55",
             "e20000197608005216606d4d",
             "e20000197408006916606d36",
             "e20000197408007116606d37"
        };
        public MainForm()
        {
            InitializeComponent();

            _camera = new CameraService();
            _camera.OnFrame += Camera_OnFrame;
            string cascadePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "haarcascade_frontalface_default.xml");
            _faceService = new FaceRecognitionService(cascadePath);
            Directory.CreateDirectory(_samplesDir);

            _db = new DBPostgress(GlobalVariables.DbConnString);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Camera_OnFrame(Mat frame)
        {
            try
            {
                // show on PictureBox
                var bmp = frame.ToBitmap();
                Invoke(new Action(() =>
                {
                    if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
                    pictureBox1.Image = bmp;
                }));
            }
            catch (Exception ex)
            {
                Console.WriteLine("OnFrame show error: " + ex.Message);
            }
        }

        private void cameraStream()
        {
            try
            {
                _camera.Start(cameraUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to start stream: " + ex.Message);
            }
        }

        private void personnelRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (UserEnrollmentForm enrollmentForm = new UserEnrollmentForm())
            {
                CameraService.Instance.OnFrame -= Camera_OnFrame;
                enrollmentForm.ShowDialog();
            }
            trainData();
            System.Threading.Thread.Sleep(1000);
            recognizeFace2();
            CameraService.Instance.OnFrame += Camera_OnFrame;
            ;
        }

        private async void recognizeFace()
        {
            // Ensure the model is available
            string appData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FaceRecognitionApp");
            string modelPath = Path.Combine(appData, "trainedModel.yml");
            string labelsPath = Path.Combine(appData, "labels.json");

            // Load FaceService if not already in memory
            if (GlobalVariables.FaceService == null)
            {
                GlobalVariables.FaceService = new FaceRecognitionService("haarcascade_frontalface_default.xml");
                if (File.Exists(modelPath))
                {
                    GlobalVariables.FaceService.LoadModel(modelPath);
                }
            }

            // Load labels if not yet loaded
            if (GlobalVariables.LabelToName == null || GlobalVariables.LabelToName.Count == 0)
            {
                if (File.Exists(labelsPath))
                {
                    var json = File.ReadAllText(labelsPath);
                    GlobalVariables.LabelToName = JsonSerializer.Deserialize<Dictionary<int, string>>(json);
                }
            }

            // Check if model is ready
            if (GlobalVariables.FaceService == null || GlobalVariables.LabelToName == null || GlobalVariables.LabelToName.Count == 0)
            {
                lblFaceScan.Text = "No trained model available!";
                GlobalVariables.IsTrained = false;
                return;
            }
            else
            {
                GlobalVariables.IsTrained = true;
            }

            _recognizing = true;
            lblFaceScan.Text = "Recognizing...";

            while (_recognizing)
            {
                if (pictureBox1.Image == null)
                {
                    await Task.Delay(100);
                    continue;
                }

                using (var bmp = new Bitmap(pictureBox1.Image))
                using (var mat = bmp.ToMat())
                {
                    var faces = GlobalVariables.FaceService.DetectFaces(mat);
                    if (faces.Length > 0)
                    {
                        var face = faces[0];

                        using (var faceGray = GlobalVariables.FaceService.ExtractFace(mat, face))
                        {
                            var (label, confidence) = GlobalVariables.FaceService.Predict(faceGray);
                            string name = "Unknown";

                            if (label >= 0 && GlobalVariables.LabelToName.ContainsKey(label))
                                name = GlobalVariables.LabelToName[label];

                            Invoke(new Action(() =>
                            {
                                lblFaceScan.Text = $"Detected: {name}, confidence: {confidence:F1}";
                            }));
                        }
                    }
                    else
                    {
                        Invoke(new Action(() => lblFaceScan.Text = "No face detected"));
                    }
                }

                await Task.Delay(300);
            }

        }

        private async void recognizeFace2()
        {
            int countMatch = 0;
            double threshold = 60;
            int matchThreshold = 3;
            if (_recognizing)
            {
                lblFaceScan.ForeColor = Color.Black;
                lblFaceScan.Text = "Recognizing...";
                while (_recognizing)
                {
                    if (pictureBox1.Image == null)
                    {
                        await Task.Delay(100);
                        continue;
                    }

                    using (var bmp = new Bitmap(pictureBox1.Image))
                    using (var mat = bmp.ToMat())
                    {
                        var faces = _faceService.DetectFaces(mat);

                        if (faces.Length > 0)
                        {
                            foreach (var f in faces)
                            {
                                using (var faceGray = _faceService.ExtractFace(mat, f))
                                {
                                    var (label, confidence) = _faceService.Predict(faceGray);

                                    string name = "Unknown";
                                    if (label >= 0 && _labelToName.ContainsKey(label))
                                        name = _labelToName[label];

                                    Invoke(new Action(() =>
                                    {
                                        if (name != "Unknown" && confidence < threshold)
                                        {
                                            if (confidence < threshold)
                                            {
                                                countMatch++;
                                                if (countMatch >= matchThreshold)
                                                {
                                                    lblFaceScan.ForeColor = Color.Black;
                                                    lblFaceScan.Text = $"Detected: {name}, confidence: {confidence:F1}";
                                                    GlobalVariables.personnelEntered = name;
                                                    port.WriteLine("OPEN");
                                                    MessageBox.Show($"Welcome {name}");
                                                    System.Threading.Thread.Sleep(3000);
                                                    using (DocumentDialog documentDialog = new DocumentDialog(port))
                                                    {
                                                        CameraService.Instance.OnFrame -= Camera_OnFrame;
                                                        documentDialog.ShowDialog();
                                                    }
                                                    countMatch = 0;
                                                    CameraService.Instance.OnFrame += Camera_OnFrame;
                                                }
                                            }

                                        }
                                        else
                                        {
                                            lblFaceScan.ForeColor = Color.Red;
                                            lblFaceScan.Text = $"Unknown face (conf: {confidence:F1})";
                                        }
                                    }));
                                }
                            }
                        }
                        else
                        {
                            Invoke(() =>
                            {
                                lblFaceScan.ForeColor = Color.Black;
                                lblFaceScan.Text = "No face detected";
                            });
                        }
                    }

                    await Task.Delay(300);
                }
            }
            else
            {
                lblFaceScan.Text = "Recognition stopped.";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            port = new SerialPort(GlobalVariables.SerialPortName, 115200);
            port.DataReceived += SerialPort_DataReceived;
            port.Open();
            trainData();
            System.Threading.Thread.Sleep(1000);
            CameraService.Instance.OnFrame += Camera_OnFrame;
            recognizeFace2();

        }


        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //if(GlobalVariables.personnelEntered == null)
            //{
            //    return;
            //}
           
            string data = port.ReadExisting();
            //port.Close();
            //System.Threading.Thread.Sleep(1000);
            if (rfidTags.Contains(data))
            {
                AppendTextToTextBox(data);
                var docInfo = _db.GetDocumentInformation(data.Trim());
                ///MessageBox.Show("Document Type: " + docInfo.Value);
                if (docInfo != null)
                {
                    string message =
                        $"Record No.: {docInfo.Value.record_no}\n" +
                        $"Student: {docInfo.Value.student_name}\n" +
                        $"Course: {docInfo.Value.course}\n" +
                        $"Personnel: {GlobalVariables.personnelEntered}";
                    this.Invoke(() =>
                    {
                        MessageBox.Show(message, "📄 Document Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //var toast = new Toast(
                        //       "📄 Document Found ",
                        //       message,
                        //       Color.LightGreen, // success color
                        //       2000 // 5 seconds new is 2sec
                        //   );
                        //toast.Show();
                    });

                }
                else
                {
                    this.Invoke(() =>
                    {
                        MessageBox.Show("Document not found in database", "❌ Not Registered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // var toast = new Toast(
                        //    "❌ Not Registered",
                        //    "Document not found in database",
                        //    Color.LightCoral,
                        //    5000 // 10 sec new is 5sec
                        //);

                        // toast.Show();
                    });

                }

                if (docInfo == null)
                {
                    return;
                }
                _db.AddRecord("document_information_logs", new Dictionary<string, object>
            {
                { "document_information_id", docInfo.Value.id }
            });
            }
        }
        private void AppendTextToTextBox(string text)
        {
            if (txtTag.InvokeRequired)
            {
                txtTag.Invoke(new Action<string>(AppendTextToTextBox), text);
            }
            else
            {
                txtTag.AppendText(text);
            }
        }

        private void WriteToSerialPort(string data)
        {
            if (port != null && port.IsOpen)
            {
                string message = "OPEN"; // Example command
                port.WriteLine(message);
                //lblStatus.Text = $"Sent: {message}";
            }
            //else
            //{
            //    lblStatus.Text = "Serial port not open!";
            //}
        }


        private void trainData()
        {
            // Load samples from DB and build labeled list
            var all = _db.GetAllImages();
            // Map names to integer labels
            var nameToLabel = new Dictionary<string, int>();
            int labelCounter = 0;
            var labeledFiles = new List<(string path, int label)>();
            foreach (var row in all)
            {
                if (!nameToLabel.ContainsKey(row.name))
                    nameToLabel[row.name] = labelCounter++;

                int lab = nameToLabel[row.name];
                labeledFiles.Add((row.imagePath, lab));
            }

            // Build label->name map for later display
            _labelToName = nameToLabel.ToDictionary(k => k.Value, v => v.Key);

            _faceService.TrainFromFiles(labeledFiles);

            lblFaceScan.Text = $"Trained on {labeledFiles.Count} samples, {nameToLabel.Count} people.";
        }

        private void documentLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocumentLogs documentLogs = new DocumentLogs();
            documentLogs.ShowDialog();
        }

        private void personnelLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void documentRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DocumentRegistration documentRegistration = new DocumentRegistration())
            {

                port.Close();
                documentRegistration.ShowDialog();
            }
            this.Refresh();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (_latestImage == null) return;

            int pbWidth = pictureBox1.Width;
            int pbHeight = pictureBox1.Height;

            int imgWidth = _latestImage.Width;
            int imgHeight = _latestImage.Height;

            int x = (pbWidth - imgWidth) / 2;
            int y = (pbHeight - imgHeight) / 2;

            e.Graphics.DrawImage(_latestImage, x, y, imgWidth, imgHeight);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            port.WriteLine("OPEN");
            ////using (DocumentDialog documentDialog = new DocumentDialog(port))
            ////{
            ////    //CameraService.Instance.OnFrame -= Camera_OnFrame;
            ////    documentDialog.ShowDialog();
            ////}
            //string data = txtTag.Text.Trim();
            //var docInfo = _db.GetDocumentInformation(data.Trim());
            ///// MessageBox.Show("Document Type: " + docInfo.Value);
            //GlobalVariables.personnelEntered = "Test Personnel"; // Set this to the actual personnel name from face recognition
            //if (docInfo != null)
            //{
            //    string message =
            //        $"Record No.: {docInfo.Value.record_no}\n" +
            //        $"Student: {docInfo.Value.student_name}\n" +
            //        $"Course: {docInfo.Value.course}\n" +
            //        $"Personnel: {GlobalVariables.personnelEntered}";
            //    this.Invoke(() =>
            //    {
            //        MessageBox.Show(message, "📄 Document Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        //var toast = new Toast(
            //        //       "📄 Document Found",
            //        //       message,
            //        //       Color.LightGreen, // success color
            //        //       5000 // 5 seconds
            //        //   );
            //        //toast.Show();
            //    });

            //}
            //else
            //{
            //    this.Invoke(() =>
            //    {
            //        MessageBox.Show("Document not found in database", "❌ Not Registered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        // var toast = new Toast(
            //        //    "❌ Not Registered",
            //        //    "Document not found in database",
            //        //    Color.LightCoral,
            //        //    10000 // 10 sec
            //        //);

            //        // toast.Show();
            //    });

            //}

            ////if (docInfo == null)
            ////{
            ////    return;
            ////}
            ////_db.AddRecord("document_information_logs", new Dictionary<string, object>
            ////{
            ////    { "document_information_id", docInfo.Value.id }
            ////});
            ////var docInfo = _db.GetDocumentInformation(txtTag.Text.Trim());
            //////MessageBox.Show("Document Type: " + docInfo.Value.id);
            ////if (docInfo == null)
            ////{
            ////    return;
            ////}
            ////_db.AddRecord("document_information_logs", new Dictionary<string, object>
            ////{
            ////    { "document_information_id", docInfo.Value.id }
            ////});

        }

        private void documentLogsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (DocumentLogsReport enrollmentForm = new DocumentLogsReport())
            {
                enrollmentForm.ShowDialog();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
