namespace automatic_door_lock_face_recognition
{
    partial class PersonnelLogs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            dgvPersonnelLogs = new DataGridView();
            personnel_name = new DataGridViewTextBoxColumn();
            log_type = new DataGridViewTextBoxColumn();
            time_log = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonnelLogs).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvPersonnelLogs);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personnel Logs";
            // 
            // dgvPersonnelLogs
            // 
            dgvPersonnelLogs.AllowUserToAddRows = false;
            dgvPersonnelLogs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPersonnelLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPersonnelLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonnelLogs.Columns.AddRange(new DataGridViewColumn[] { personnel_name, log_type, time_log });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPersonnelLogs.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPersonnelLogs.Location = new Point(6, 32);
            dgvPersonnelLogs.Name = "dgvPersonnelLogs";
            dgvPersonnelLogs.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPersonnelLogs.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPersonnelLogs.RowHeadersVisible = false;
            dgvPersonnelLogs.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPersonnelLogs.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvPersonnelLogs.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPersonnelLogs.Size = new Size(764, 406);
            dgvPersonnelLogs.TabIndex = 0;
            // 
            // personnel_name
            // 
            personnel_name.HeaderText = "Name";
            personnel_name.Name = "personnel_name";
            personnel_name.ReadOnly = true;
            personnel_name.Width = 400;
            // 
            // log_type
            // 
            log_type.HeaderText = "Log Status";
            log_type.Name = "log_type";
            log_type.ReadOnly = true;
            log_type.Width = 150;
            // 
            // time_log
            // 
            time_log.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            time_log.HeaderText = "Date and Time";
            time_log.Name = "time_log";
            time_log.ReadOnly = true;
            // 
            // PersonnelLogs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "PersonnelLogs";
            Text = "PersonnelLogs";
            Load += PersonnelLogs_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersonnelLogs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvPersonnelLogs;
        private DataGridViewTextBoxColumn personnel_name;
        private DataGridViewTextBoxColumn log_type;
        private DataGridViewTextBoxColumn time_log;
    }
}