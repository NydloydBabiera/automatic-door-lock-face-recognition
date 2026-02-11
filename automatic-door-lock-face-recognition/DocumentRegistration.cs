using automatic_door_lock_face_recognition.Classess;
using automatic_door_lock_face_recognition.Services;
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

namespace automatic_door_lock_face_recognition
{
    public partial class DocumentRegistration : Form
    {
        private SerialPort port;
        private DBPostgress _db;
        private bool isEditMode = false;
        public DocumentRegistration()
        {
            InitializeComponent();
            _db = new DBPostgress(GlobalVariables.DbConnString);
            LoadUserGrid();
        }

        private void DocumentRegistration_Load(object sender, EventArgs e)
        {
            dgvDocument.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            buttonsDefaultState();
            textboxesDefaultState();
            clearTextBoxes();
            port = new SerialPort(GlobalVariables.SerialPortName, 115200);
            port.DataReceived += SerialPort_DataReceived;
            port.Open();
        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = port.ReadExisting();
            AppendTextToTextBox(data);
        }
        private void AppendTextToTextBox(string text)
        {
            if (txtRFIDtag.InvokeRequired)
            {
                txtRFIDtag.Invoke(new Action<string>(AppendTextToTextBox), text);
            }
            else
            {
                txtRFIDtag.AppendText(text);
            }
        }
        private void LoadUserGrid()
        {
            if (dgvDocument == null)
            {
                //MessageBox.Show("dgvDocument is null!");
                return;
            }

            if (_db == null)
            {
                //MessageBox.Show("_db (database class) is null!");
                return;
            }

            dgvDocument.AutoGenerateColumns = false;
            _db.LoadData("document_information", dgvDocument);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                var columns = new Dictionary<string, object>
                {
                    { "document_rfid_tag", txtRFIDtag.Text.Trim() },
                    { "record_no", txtRecordNo.Text.Trim() },
                    { "row_num", txtRowNo.Text.Trim() },
                    {"shelf_number", long.Parse(txtShelfNumber.Text.Trim()) },
                    {"student_name", txtStudentName.Text.Trim() },
                    {"student_id", long.Parse(txtStudentID.Text.Trim()) },
                    {"course", txtCourse.Text.Trim() }
                };
                {

                }
                ;

                int updated = await _db.UpdateRowAsync(
                    "document_information",
                    "document_information_id",
                    GlobalVariables.SelectedDocumentId,         // key value
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
                bool dataExists = _db.CheckIfDataExists("document_information", "document_rfid_tag", txtRFIDtag.Text.Trim());
                if (dataExists)
                {
                    MessageBox.Show("⚠️ Record already exists.");
                }

                _db.AddRecord("document_information", new Dictionary<string, object>
                    {
                        { "document_rfid_tag", txtRFIDtag.Text.Trim() },
                        { "record_no", long.Parse(txtRecordNo.Text.Trim()) },
                        { "shelf_number", long.Parse(txtShelfNumber.Text.Trim()) },
                        { "student_name", $"{txtStudentName.Text.Trim()} {txtMiddleName.Text.Trim()} {txtLastName.Text.Trim()}" },
                        { "student_id", long.Parse(txtStudentID.Text.Trim()) },
                        { "course", txtCourse.Text.Trim() },
                        { "row_num", txtRowNo.Text.Trim() }
                    });
            }

            LoadUserGrid();
            buttonsDefaultState();
            textboxesDefaultState();
            dgvDocument.Enabled = true;
        }

        private void clearTextBoxes()
        {
            txtRecordNo.Text = "";
            txtRFIDtag.Text = "";
            txtStudentName.Text = "";
            txtShelfNumber.Text = "";
            txtStudentID.Text = "";
            txtRowNo.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            txtCourse.Text = "";
        }

        private void buttonsDefaultState()
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void textboxesDefaultState()
        {
            txtRecordNo.Enabled = false;
            txtRFIDtag.Enabled = false;
            txtStudentName.Enabled = false;
            txtShelfNumber.Enabled = false;
            txtStudentID.Enabled = false;
            txtRowNo.Enabled = false;
            txtMiddleName.Enabled = false; ;
            txtLastName.Enabled = false;
            txtCourse.Enabled = false;
        }

        private void textboxesEnable()
        {
            txtRecordNo.Enabled = true;
            txtRFIDtag.Enabled = true;
            txtStudentName.Enabled = true;
            txtShelfNumber.Enabled = true;
            txtStudentID.Enabled = true;
            txtRowNo.Enabled = true;
            txtMiddleName.Enabled = true;
            txtLastName.Enabled = true;
            txtCourse.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            buttonsDefaultState();
            textboxesDefaultState();
            dgvDocument.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            textboxesEnable();
            clearTextBoxes();
            dgvDocument.Enabled = false;
        }

        private void dgvDocument_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            GlobalVariables.SelectedDocumentId = Convert.ToInt32(dgvDocument.Rows[e.RowIndex].Cells["document_information_id"].Value);


            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = true;

            isEditMode = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtRecordNo.Text = dgvDocument.CurrentRow.Cells["record_no"].Value.ToString();
            txtRFIDtag.Text = dgvDocument.CurrentRow.Cells["document_rfid_tag"].Value.ToString();
            txtShelfNumber.Text = dgvDocument.CurrentRow.Cells["shelf_number"].Value.ToString();
            txtStudentName.Text = dgvDocument.CurrentRow.Cells["student_name"].Value.ToString().Split()[0];
            txtMiddleName.Text = dgvDocument.CurrentRow.Cells["student_name"].Value.ToString().Split()[1];
            txtLastName.Text = dgvDocument.CurrentRow.Cells["student_name"].Value.ToString().Split()[2];
            txtStudentID.Text = dgvDocument.CurrentRow.Cells["student_id"].Value.ToString();
            txtRowNo.Text = dgvDocument.CurrentRow.Cells["row_num"].Value.ToString();
            textboxesEnable();

            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
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
                MessageBox.Show($"Deleting:{GlobalVariables.SelectedDocumentId}");
                _db.DeleteRowAsync("document_information", "document_information_id", GlobalVariables.SelectedDocumentId);
                LoadUserGrid();
                buttonsDefaultState();
            }
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            var results = _db.Search(
                "document_information",
                new[] { "record_no", "document_rfid_tag", "shelf_number", "student_name", "student_id" },
                textBox1.Text
            );

            dgvDocument.DataSource = results;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLastName.Text))
            {
                char firstChar = txtLastName.Text[0];

                // Example: put it in another TextBox
                txtRowNo.Text = $"ROW {firstChar.ToString().ToUpper()}";
            }
        }

        private void txtRFIDtag_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClearRfidTag_Click(object sender, EventArgs e)
        {
            txtRFIDtag.Clear();
        }
    }
}
