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
        public DocumentDialog(SerialPort _port)
        {
            InitializeComponent();
            port = _port;
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
            //change sang shelf_number to row (A B C D)
            string shelf_number = row.Cells["shelf_number"].Value?.ToString();
            string row_num = row.Cells["row_num"].Value?.ToString();
            string student_name = row.Cells["student_name"].Value?.ToString();
           
            var isConfirmed = CustomMessageBoxService.Show(
                $"Are you sure you want to retrieve {student_name}'s record in shelf {shelf_number} {row_num}?",
                "Confirm Action",
                "Info",
                CustomMessageBoxButtons.YesNo
            );

            if (isConfirmed == CustomDialogResult.Yes)
            {
                switch (row_num)
                {
                    case "ROW A":
                        port.WriteLine($"ON1");
                        break;
                    case "ROW B":
                        port.WriteLine($"ON2");
                        break;
                    case "ROW C":
                        port.WriteLine($"ON3");
                        break;
                    case "ROW D":
                        port.WriteLine($"ON4");
                        break;
                    default:
                        break;
                }
               
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

        private void dgvDocument_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
