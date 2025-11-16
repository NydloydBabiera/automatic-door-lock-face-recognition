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
            //port.Open();
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
                    { "document_type", txtDocumentType.Text.Trim() },
                    {"shelf_number", txtShelfNumber.Text.Trim() },
                    {"student_name", txtStudentName.Text.Trim() },
                    {"student_id", txtStudentName.Text.Trim() }
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
                        { "document_type", txtDocumentType.Text.Trim() },
                        {"shelf_number", long.Parse(txtShelfNumber.Text.Trim()) },
                        {"student_name", txtStudentName.Text.Trim() },
                        {"student_id", long.Parse(txtStudentID.Text.Trim()) }
                    });
            }
               
            LoadUserGrid();
            buttonsDefaultState();
            textboxesDefaultState();
        }

        private void clearTextBoxes()
        {
            txtDocumentType.Text = "";
            txtRFIDtag.Text = "";
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
            txtDocumentType.Enabled = false;
            txtRFIDtag.Enabled = false;
            txtStudentName.Enabled = false;
            txtShelfNumber.Enabled = false;
            txtStudentID.Enabled = false;
        }

        private void textboxesEnable()
        {
            txtDocumentType.Enabled = true;
            txtRFIDtag.Enabled = true;
            txtStudentName.Enabled = true;
            txtShelfNumber.Enabled = true;
            txtStudentID.Enabled = true;
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
            txtDocumentType.Text = dgvDocument.CurrentRow.Cells["document_type"].Value.ToString();
            txtRFIDtag.Text = dgvDocument.CurrentRow.Cells["document_rfid_tag"].Value.ToString();
            txtShelfNumber.Text = dgvDocument.CurrentRow.Cells["shelf_number"].Value.ToString();
            txtStudentName.Text = dgvDocument.CurrentRow.Cells["student_name"].Value.ToString();
            txtStudentID.Text = dgvDocument.CurrentRow.Cells["student_id"].Value.ToString();

            textboxesEnable();

            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = true;
            btnSave.Enabled = true;
        }
    }
}
