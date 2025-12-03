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
using automatic_door_lock_face_recognition.Classess;
using automatic_door_lock_face_recognition.Services;

namespace automatic_door_lock_face_recognition
{
    public partial class DocumentDialog : Form
    {
        private DBPostgress _db;
        private SerialPort port;
        public DocumentDialog()
        {
            InitializeComponent();
            port = new SerialPort(GlobalVariables.SerialPortName, 115200);
            //port.DataReceived += SerialPort_DataReceived;
            //port.Open();
            _db = new DBPostgress(GlobalVariables.DbConnString);
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

        private void DocumentDialog_Load(object sender, EventArgs e)
        {
            dgvDocument.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadUserGrid();
        }

        private void dgvDocument_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            // Get the row data
            DataGridViewRow row = dgvDocument.Rows[e.RowIndex];

            string shelf_number = row.Cells["shelf_number"].Value?.ToString();
            string student_name = row.Cells["student_name"].Value?.ToString();
            MessageBox.Show($"shelf_number:{shelf_number}");
            var isConfirmed = MessageBox.Show(
             $"Get document for student {student_name} in shelf number {shelf_number}",
             "Confirm Deletion",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning
             );

            if (isConfirmed.Equals(DialogResult.Yes))
            {
                port.WriteLine($"ON{shelf_number}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var results = _db.Search(
                "document_information",
                new[] { "document_type", "document_rfid_tag", "shelf_number", "student_name", "student_id" },
                textBox1.Text
            );

            dgvDocument.DataSource = results;
        }
    }
}
