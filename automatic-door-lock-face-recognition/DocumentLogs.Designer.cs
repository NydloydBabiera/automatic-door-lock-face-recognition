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
            document_type = new DataGridViewTextBoxColumn();
            time_log = new DataGridViewTextBoxColumn();
            log_type = new DataGridViewTextBoxColumn();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocumentLogs).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDocumentLogs);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(608, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Document Logs";
            // 
            // dgvDocumentLogs
            // 
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
            dgvDocumentLogs.Columns.AddRange(new DataGridViewColumn[] { document_type, time_log, log_type });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
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
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvDocumentLogs.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvDocumentLogs.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDocumentLogs.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvDocumentLogs.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDocumentLogs.Size = new Size(596, 378);
            dgvDocumentLogs.TabIndex = 0;
            dgvDocumentLogs.CellContentClick += dgvDocumentLogs_CellContentClick;
            // 
            // document_type
            // 
            document_type.DataPropertyName = "document_type";
            document_type.HeaderText = "Document";
            document_type.Name = "document_type";
            document_type.ReadOnly = true;
            document_type.Width = 150;
            // 
            // time_log
            // 
            time_log.DataPropertyName = "time_log";
            time_log.HeaderText = "Time";
            time_log.Name = "time_log";
            time_log.ReadOnly = true;
            time_log.Width = 150;
            // 
            // log_type
            // 
            log_type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            log_type.DataPropertyName = "log_type";
            log_type.HeaderText = "Log Type";
            log_type.Name = "log_type";
            log_type.ReadOnly = true;
            // 
            // button1
            // 
            button1.Location = new Point(420, 444);
            button1.Name = "button1";
            button1.Size = new Size(194, 28);
            button1.TabIndex = 1;
            button1.Text = "DELETE ALL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DocumentLogs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 484);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "DocumentLogs";
            Text = "DocumentLogs";
            Load += DocumentLogs_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDocumentLogs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvDocumentLogs;
        private DataGridViewTextBoxColumn document_type;
        private DataGridViewTextBoxColumn time_log;
        private DataGridViewTextBoxColumn log_type;
        private Button button1;
    }
}