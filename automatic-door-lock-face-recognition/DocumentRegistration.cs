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
        public DocumentRegistration()
        {
            InitializeComponent();
            _db = new DBPostgress(GlobalVariables.DbConnString);
            LoadUserGrid();
        }

        private void DocumentRegistration_Load(object sender, EventArgs e)
        {
            port = new SerialPort("COM6", 115200);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Saving RFID Tag: " + txtRFIDtag.Text.Trim());
            //if(_db == null)
            //{
            //    return;
            //}
            //else
            //{
            //    bool dataExists = _db.CheckIfDataExists("document_information", "document_rfid_tag", txtRFIDtag.Text.Trim());
            //    if (dataExists)
            //    {
            //        MessageBox.Show("⚠️ Record already exists.");
            //    }
            //}
            bool dataExists = _db.CheckIfDataExists("document_information", "document_rfid_tag", txtRFIDtag.Text.Trim());
            if (dataExists)
            {
                MessageBox.Show("⚠️ Record already exists.");
            }

            _db.AddRecord("document_information", new Dictionary<string, object>
            {
                { "document_rfid_tag", txtRFIDtag.Text.Trim() },
                { "document_type", txtDocumentType.Text.Trim() },
            });
            LoadUserGrid();
        }
    }
}
