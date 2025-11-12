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
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace automatic_door_lock_face_recognition
{
    public partial class FaceScan : Form
    {
        private SerialPort port;
        private MemoryStream imageBuffer = new MemoryStream();
        private CameraService _camera;
        private FaceRecognitionService _faceService;
        private DBPostgress _db;
        private bool _recognizing = false;
        private string _samplesDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "samples");
        private Dictionary<int, string> _labelToName = new Dictionary<int, string>();
        private int _nextLabel = 0;
        public FaceScan()
        {
            InitializeComponent();
            // Example: set default stream url
            txtStreamUrl.Text = "http://192.168.68.115:81/stream";
            _camera = new CameraService();
            _camera.OnFrame += Camera_OnFrame;

            // Adjust this to your connection string
            string connStr = "Host=localhost;Username=postgres;Password=postgres1234;Database=records_system;";
            _db = new DBPostgress(connStr);

            // Ensure sample folder exists
            Directory.CreateDirectory(_samplesDir);

            // Provide path to Haar cascade xml (copy to output)
            string cascadePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "haarcascade_frontalface_default.xml");
            _faceService = new FaceRecognitionService(cascadePath);

            LoadUserGrid();

        }

        private void LoadUserGrid()
        {
            var rows = _db.GetAllSamples();
            //dgvUsers.DataSource = rows.Select(r => new { r.id, r.name, r.imagePath }).ToList();
        }

        private void FaceScan_Load(object sender, EventArgs e)
        {

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

        private void btnConnect_Click(object sender, EventArgs e)
        {
            port = new SerialPort("COM5", 115200);
            port.DataReceived += Port_DataReceived;
            port.Open();
            MessageBox.Show("Connected to ESP32");
           
        }
        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string incoming = port.ReadExisting();

            if (incoming.Contains("END"))
            {
                Invoke(new Action(() =>
                {
                    try
                    {
                        Image img = Image.FromStream(imageBuffer);
                        pictureBox1.Image = img;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to decode image: " + ex.Message);
                    }
                }));
                imageBuffer.SetLength(0);
            }
            else
            {
                byte[] bytes = System.Text.Encoding.Default.GetBytes(incoming);
                imageBuffer.Write(bytes, 0, bytes.Length);
            }
        }

        private void btnStartStream_Click(object sender, EventArgs e)
        {
            try
            {
                _camera.Start(txtStreamUrl.Text.Trim());
                lblStatus.Text = "Stream started";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to start stream: " + ex.Message);
            }
        }

        private void btnCaptureSamples_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Enter a name first.");
                return;
            }

            // capture several samples from live feed
            int samplesWanted = 5;
            int saved = 0;
            lblStatus.Text = "Capturing samples...";
            Application.DoEvents();

            for (int i = 0; i < 50 && saved < samplesWanted; i++)
            {
                if (pictureBox1.Image == null) { System.Threading.Thread.Sleep(100); continue; }

                using (var bmp = new Bitmap(pictureBox1.Image))
                using (var mat = bmp.ToMat())
                {
                    var faces = _faceService.DetectFaces(mat);
                    if (faces.Length > 0)
                    {
                        var face = faces[0];
                        using (var faceMat = _faceService.ExtractFace(mat, face))
                        {
                            string fileName = $"{txtName.Text}_{DateTime.Now:yyyyMMdd_HHmmssfff}_{saved}.png";
                            string fullPath = Path.Combine(_samplesDir, fileName);
                            faceMat.Save(fullPath);
                            _db.InsertSample(txtName.Text, fullPath);
                            saved++;
                        }
                    }
                }
                System.Threading.Thread.Sleep(400);
            }

            lblStatus.Text = $"Captured {saved} samples.";
            LoadUserGrid();
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            // Load samples from DB and build labeled list
            var all = _db.GetAllSamples();
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

            lblStatus.Text = $"Trained on {labeledFiles.Count} samples, {nameToLabel.Count} people.";
        }

        private async void btnRecognize_Click(object sender, EventArgs e)
        {
            _recognizing = !_recognizing;
            btnRecognize.Text = _recognizing ? "Stop Recognize" : "Recognize";
            if (_recognizing)
            {
                lblStatus.Text = "Recognizing...";
                while (_recognizing)
                {
                    if (pictureBox1.Image == null) { await System.Threading.Tasks.Task.Delay(100); continue; }
                    using (var bmp = new Bitmap(pictureBox1.Image))
                    using (var mat = bmp.ToMat())
                    {
                        var faces = _faceService.DetectFaces(mat);
                        if (faces.Length > 0)
                        {
                            var f = faces[0];
                            using (var faceGray = _faceService.ExtractFace(mat, f))
                            {
                                var (label, confidence) = _faceService.Predict(faceGray);
                                string name = "Unknown";
                                if (label >= 0 && _labelToName.ContainsKey(label))
                                    name = _labelToName[label];

                                Invoke(new Action(() =>
                                {
                                    lblStatus.Text = $"Detected: {name}, confidence: {confidence:F1}";
                                }));
                            }
                        }
                        else
                        {
                            Invoke(new Action(() => lblStatus.Text = "No face detected"));
                        }
                    }
                    await System.Threading.Tasks.Task.Delay(300);
                }
            }
            else
            {
                lblStatus.Text = "Recognition stopped.";
            }
        }
    }
}
