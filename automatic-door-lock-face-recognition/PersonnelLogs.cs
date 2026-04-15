using automatic_door_lock_face_recognition.Classess;
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
    public partial class PersonnelLogs : Form
    {
        private DBPostgress _db;
        public PersonnelLogs()
        {
            InitializeComponent();
        }

        private void PersonnelLogs_Load(object sender, EventArgs e)
        {
            if (dgvPersonnelLogs == null)
            {
                //MessageBox.Show("dgvDocument is null!");
                return;
            }

            if (_db == null)
            {
                //MessageBox.Show("_db (database class) is null!");
                return;
            }
            dgvPersonnelLogs.AutoGenerateColumns = false;
            _db.LoadDocumentLogs(dgvPersonnelLogs);
        }
    }
}
