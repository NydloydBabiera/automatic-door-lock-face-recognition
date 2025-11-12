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
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            document_type = new DataGridViewTextBoxColumn();
            time_log = new DataGridViewTextBoxColumn();
            log_type = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(608, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Document Logs";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { document_type, time_log, log_type });
            dataGridView1.Location = new Point(6, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(596, 378);
            dataGridView1.TabIndex = 0;
            // 
            // document_type
            // 
            document_type.DataPropertyName = "document_type";
            document_type.HeaderText = "Document";
            document_type.Name = "document_type";
            document_type.ReadOnly = true;
            // 
            // time_log
            // 
            time_log.DataPropertyName = "time_log";
            time_log.HeaderText = "Time";
            time_log.Name = "time_log";
            time_log.ReadOnly = true;
            // 
            // log_type
            // 
            log_type.DataPropertyName = "log_type";
            log_type.HeaderText = "Log Type";
            log_type.Name = "log_type";
            log_type.ReadOnly = true;
            // 
            // DocumentLogs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 450);
            Controls.Add(groupBox1);
            Name = "DocumentLogs";
            Text = "DocumentLogs";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn document_type;
        private DataGridViewTextBoxColumn time_log;
        private DataGridViewTextBoxColumn log_type;
    }
}