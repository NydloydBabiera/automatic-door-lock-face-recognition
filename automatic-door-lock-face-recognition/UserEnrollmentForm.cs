using automatic_door_lock_face_recognition.Classess;
using automatic_door_lock_face_recognition.Services;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace automatic_door_lock_face_recognition
{
    public partial class UserEnrollmentForm : Form
    {
        private DBPostgress _db;
        private CameraService _camera;
        private Boolean isStreaming = false;
        private FaceRecognitionService _faceService;
        private string _samplesDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "samples");
        private Dictionary<int, string> _labelToName = new Dictionary<int, string>();
        private string _trainedModelPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "trained_model.yml");
        private bool isEditMode = false;
        public UserEnrollmentForm()
        {
            InitializeComponent();
            lblCameraStream.Text = GlobalVariables.CameralUrl;
            _camera = new CameraService();
            _camera.OnFrame += Camera_OnFrame;

            string connStr = "Host=localhost;Username=postgres;Password=postgres1234;Database=records_system;";
            _db = new DBPostgress(connStr);
            isStreaming = false;
            LoadUserGrid();
            // Ensure sample folder exists
            Directory.CreateDirectory(_samplesDir);
            string cascadePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "haarcascade_frontalface_default.xml");
            _faceService = new FaceRecognitionService(cascadePath);



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                var columns = new Dictionary<string, object>
                {
                    { "first_name", txtFirstName.Text.Trim() },
                    { "middle_name",txtMiddleName.Text.Trim() },
                    { "last_name", txtLastName.Text.Trim() },
                    { "designation",txtDesignation.Text.Trim() },
                };
                {

                }
                ;

                int updated = await _db.UpdateRowAsync(
                    "personnel_information",
                    "personnel_information_id",
                    GlobalVariables.SelectedPersonnelId,         // key value
                    columns
                );

                if (updated == 1)
                {
                    MessageBox.Show("Data updated successfully!");
                }
                else
                {
                    MessageBox.Show("Update failed or no matching row.");
                }
            }
            else
            {
                _db.AddRecord("personnel_information", new Dictionary<string, object>
                {
                    { "first_name", txtFirstName.Text.Trim() },
                    { "middle_name", txtMiddleName.Text.Trim() },
                    { "last_name", txtLastName.Text.Trim() },
                    { "designation", txtDesignation.Text.Trim() },
                });
                MessageBox.Show("✅ Record successfully saved!", "Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadUserGrid();
            CameraService.Instance.OnFrame += Camera_OnFrame;
            btnImageSaving.Enabled = true;
            btnReloadCamera.Enabled = true;
            buttonsDefaultState();
            textboxesDefaultState();
            dgvPersonnels.Enabled = true;
            //cameraStream();



        }

        private void cameraStream()
        {
            try
            {
                _camera.Start(GlobalVariables.CameralUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to start stream: " + ex.Message);
            }
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

        private void btnImageSaving_Click(object sender, EventArgs e)
        {
            //isStreaming = false;
            btnImageSaving.Enabled = false;
            btnImageSaving.Text = "Saving and training images...";
            captureSamples();
            System.Threading.Thread.Sleep(1000);
            trainModel();
            //isStreaming = false;
            btnImageSaving.Text = "Capture Image";
            btnImageSaving.Enabled = true;
            _camera.Stop();
            //if(isStreaming == false)
            //{
            //    isStreaming = true;
            //    btnImageSaving.Text = "Capture Image";
            //    cameraStream();
            //}
            //if(isStreaming == true)
            //{
            //    //isStreaming = false;
            //    btnImageSaving.Enabled = false;
            //    //btnImageSaving.Text = "Open Camera";
            //    captureSamples();
            //    System.Threading.Thread.Sleep(1000);
            //    trainModel();
            //    isStreaming = false;
            //    btnImageSaving.Text = "Open Camera";
            //    btnImageSaving.Enabled = true;
            //}
        }
        private void LoadUserGrid()
        {
            if (dgvPersonnels == null)
            {
                //MessageBox.Show("dgvDocument is null!");
                return;
            }

            if (_db == null)
            {
                //MessageBox.Show("_db (database class) is null!");
                return;
            }
            dgvPersonnels.AutoGenerateColumns = false;
            //var rows = _db.GetTableData("personnel_information");
            _db.LoadData("personnel_information", dgvPersonnels);
        }

        private void captureSamples()
        {
            // capture several samples from live feed
            int samplesWanted = 5;
            int saved = 0;
            lblCameraStream.Text = "Capturing samples...";
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
                            string fileName = $"{txtFirstName.Text.Trim()}_{txtMiddleName.Text.Trim()}_{txtLastName.Text.Trim()}_{DateTime.Now:yyyyMMdd_HHmmssfff}_{saved}.png";
                            string fullPath = Path.Combine(_samplesDir, fileName);
                            faceMat.Save(fullPath);
                            //_db.InsertSample(txtFirstName.Text, fullPath);
                            _db.AddRecord("personnel_face_records", new Dictionary<string, object>
                            {
                                { "personnel_information_id", GlobalVariables.PersonnelId },
                                {"name",$"{txtFirstName.Text.Trim()}_{txtMiddleName.Text.Trim()}_{txtLastName.Text.Trim()}"  },
                                { "image_path", fullPath }
                            });
                            saved++;
                        }
                    }
                }
                System.Threading.Thread.Sleep(400);
            }

            lblCameraStream.Text = $"Captured {saved} samples.";
        }

        private void trainModel()
        {
            // Load samples from DB and build labeled list
            //var all = _db.GetAllSamples();
            var all = _db.GetAllUntrainedImage();

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

            // Build label->name map for later use
            _labelToName = nameToLabel.ToDictionary(k => k.Value, v => v.Key);

            // Train
            _faceService.TrainFromFiles(labeledFiles);

            // --- SAVE TRAINED MODEL AND LABEL MAP ---
            string appData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FaceRecognitionApp");
            Directory.CreateDirectory(appData);

            string modelPath = Path.Combine(appData, "trainedModel.yml");
            string labelsPath = Path.Combine(appData, "labels.json");

            _faceService.SaveModel(modelPath);
            File.WriteAllText(labelsPath, JsonSerializer.Serialize(_labelToName));

            // --- STORE GLOBALLY ---
            GlobalVariables.FaceService = _faceService;
            GlobalVariables.LabelToName = _labelToName;
            GlobalVariables.TrainedModelPath = modelPath;
            GlobalVariables.LabelsPath = labelsPath;

            lblCameraStream.Text = $"Trained on {labeledFiles.Count} samples, {nameToLabel.Count} people.";
        }

        private void btnReloadCamera_Click(object sender, EventArgs e)
        {
            cameraStream();
        }

        private void UserEnrollmentForm_Load(object sender, EventArgs e)
        {
            dgvPersonnels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnImageSaving.Enabled = false;
            btnSave.Enabled = false;
            btnReloadCamera.Enabled = false;
            btnCancel.Enabled = false;

            txtDesignation.Enabled = false;
            txtFirstName.Enabled = false;
            txtMiddleName.Enabled = false;
            txtLastName.Enabled = false;
            txtDesignation.Enabled = false;

            txtDesignation.Text = "";
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            txtDesignation.Text = "";



        }


        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            isEditMode = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnImageSaving.Enabled = true;
            btnReloadCamera.Enabled = true;
            btnCancel.Enabled = true;

            textboxesEnable();

            clearTextBoxes();
        }

        private void dgvPersonnels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPersonnels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            GlobalVariables.SelectedPersonnelId = Convert.ToInt32(dgvPersonnels.Rows[e.RowIndex].Cells["personnel_information_id"].Value);

            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnImageSaving.Enabled = false;
            btnReloadCamera.Enabled = false;

            isEditMode = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = dgvPersonnels.CurrentRow.Cells["first_name"].Value.ToString();
            txtMiddleName.Text = dgvPersonnels.CurrentRow.Cells["middle_name"].Value.ToString();
            txtLastName.Text = dgvPersonnels.CurrentRow.Cells["last_name"].Value.ToString();
            txtDesignation.Text = dgvPersonnels.CurrentRow.Cells["designation"].Value.ToString();

            txtDesignation.Enabled = true;
            txtFirstName.Enabled = true;
            txtMiddleName.Enabled = true;
            txtLastName.Enabled = true;
            txtDesignation.Enabled = true;

            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = true;
            btnSave.Enabled = true;
            btnImageSaving.Enabled = false;
            btnReloadCamera.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            buttonsDefaultState();

            textboxesEnable();

            textboxesDefaultState();

            clearTextBoxes();

            dgvPersonnels.Enabled = true;
        }

        private void clearTextBoxes()
        {
            txtDesignation.Text = "";
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            txtDesignation.Text = "";
        }

        private void buttonsDefaultState()
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;
            //btnImageSaving.Enabled = false;
            //btnReloadCamera.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void textboxesDefaultState()
        {
            txtDesignation.Enabled = false;
            txtFirstName.Enabled = false;
            txtMiddleName.Enabled = false;
            txtLastName.Enabled = false;
            txtDesignation.Enabled = false;
        }

        private void textboxesEnable()
        {
            txtDesignation.Enabled = true;
            txtFirstName.Enabled = true;
            txtMiddleName.Enabled = true;
            txtLastName.Enabled = true;
            txtDesignation.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var isConfirmed = MessageBox.Show(
                "Are you sure you want to delete this record? This action cannot be undone.",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (isConfirmed.Equals(DialogResult.Yes))
            {
                MessageBox.Show($"Deleting:{GlobalVariables.SelectedPersonnelId}");
                _db.DeletePersonRecordsAndFiles(GlobalVariables.SelectedPersonnelId);
                LoadUserGrid();
                buttonsDefaultState();
            }

        }

        private void UserEnrollmentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CameraService.Instance.OnFrame -= Camera_OnFrame;
        }
    }
}
