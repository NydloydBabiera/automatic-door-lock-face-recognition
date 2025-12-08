using automatic_door_lock_face_recognition.Classess;
using automatic_door_lock_face_recognition.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automatic_door_lock_face_recognition
{
    public partial class DocumentLogs : Form
    {
        private DBPostgress _db;
        public DocumentLogs()
        {
            InitializeComponent();
            _db = new DBPostgress(GlobalVariables.DbConnString);
            if (dgvDocumentLogs == null)
            {
                //MessageBox.Show("dgvDocument is null!");
                return;
            }

            if (_db == null)
            {
                //MessageBox.Show("_db (database class) is null!");
                return;
            }

            dgvDocumentLogs.AutoGenerateColumns = false;
            _db.LoadDocumentLogs(dgvDocumentLogs);

        }

        private void DocumentLogs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var isConfirmed = MessageBox.Show(
               "Are you sure you want to delete all records? This action cannot be undone.",
               "Confirm Deletion",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning
           );

            if (isConfirmed.Equals(DialogResult.Yes))
            {
                MessageBox.Show($"Deleting:{GlobalVariables.SelectedPersonnelId}");
                _db.DeleteAllRowsAsync("document_information_logs");
                _db.LoadDocumentLogs(dgvDocumentLogs);
            }

        }
    }
}
