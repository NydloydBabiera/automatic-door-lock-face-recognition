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
    }
}
