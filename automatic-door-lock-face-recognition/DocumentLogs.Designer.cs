namespace automatic_door_lock_face_recognition
{
    partial class DocumentLogs
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            dgvDocumentLogs = new DataGridView();
            button1 = new Button();
            student_name = new DataGridViewTextBoxColumn();
            course = new DataGridViewTextBoxColumn();
            record_no = new DataGridViewTextBoxColumn();
            row_num = new DataGridViewTextBoxColumn();
            time_log = new DataGridViewTextBoxColumn();
            log_type = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocumentLogs).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDocumentLogs);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1065, 559);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Document Logs";
            // 
            // dgvDocumentLogs
            // 
            dgvDocumentLogs.AllowDrop = true;
            dgvDocumentLogs.AllowUserToAddRows = false;
            dgvDocumentLogs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDocumentLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDocumentLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDocumentLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocumentLogs.Columns.AddRange(new DataGridViewColumn[] { student_name, course, record_no, row_num, time_log, log_type });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDocumentLogs.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDocumentLogs.Location = new Point(6, 42);
            dgvDocumentLogs.Name = "dgvDocumentLogs";
            dgvDocumentLogs.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvDocumentLogs.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvDocumentLogs.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDocumentLogs.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvDocumentLogs.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDocumentLogs.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvDocumentLogs.Size = new Size(1053, 511);
            dgvDocumentLogs.TabIndex = 0;
            dgvDocumentLogs.CellContentClick += dgvDocumentLogs_CellContentClick;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(883, 577);
            button1.Name = "button1";
            button1.Size = new Size(194, 28);
            button1.TabIndex = 1;
            button1.Text = "DELETE ALL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // student_name
            // 
            student_name.DataPropertyName = "student_name";
            student_name.HeaderText = "Student";
            student_name.Name = "student_name";
            student_name.ReadOnly = true;
            student_name.Width = 350;
            // 
            // course
            // 
            course.DataPropertyName = "course";
            course.HeaderText = "Course";
            course.Name = "course";
            course.ReadOnly = true;
            course.Width = 150;
            // 
            // record_no
            // 
            record_no.DataPropertyName = "record_no";
            record_no.HeaderText = "Record no.";
            record_no.Name = "record_no";
            record_no.ReadOnly = true;
            record_no.Width = 50;
            // 
            // row_num
            // 
            row_num.DataPropertyName = "row_num";
            row_num.HeaderText = "Row";
            row_num.Name = "row_num";
            row_num.ReadOnly = true;
            row_num.Width = 50;
            // 
            // time_log
            // 
            time_log.DataPropertyName = "time_log";
            time_log.HeaderText = "Time";
            time_log.Name = "time_log";
            time_log.ReadOnly = true;
            time_log.Width = 300;
            // 
            // log_type
            // 
            log_type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            log_type.DataPropertyName = "log_type";
            log_type.HeaderText = "Log Type";
            log_type.Name = "log_type";
            log_type.ReadOnly = true;
            // 
            // DocumentLogs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1089, 617);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            ForeColor = Color.Black;
            Name = "DocumentLogs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DocumentLogs";
            Load += DocumentLogs_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDocumentLogs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvDocumentLogs;
        private Button button1;
        private DataGridViewTextBoxColumn student_name;
        private DataGridViewTextBoxColumn course;
        private DataGridViewTextBoxColumn record_no;
        private DataGridViewTextBoxColumn row_num;
        private DataGridViewTextBoxColumn time_log;
        private DataGridViewTextBoxColumn log_type;
    }
}