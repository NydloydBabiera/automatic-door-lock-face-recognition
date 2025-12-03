namespace automatic_door_lock_face_recognition
{
    partial class DocumentDialog
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
            dgvDocument = new DataGridView();
            document_information_id = new DataGridViewTextBoxColumn();
            student_name = new DataGridViewTextBoxColumn();
            student_id = new DataGridViewTextBoxColumn();
            shelf_number = new DataGridViewTextBoxColumn();
            document_type = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDocument).BeginInit();
            SuspendLayout();
            // 
            // dgvDocument
            // 
            dgvDocument.AllowUserToAddRows = false;
            dgvDocument.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDocument.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDocument.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDocument.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocument.Columns.AddRange(new DataGridViewColumn[] { document_information_id, student_name, student_id, shelf_number, document_type });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDocument.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDocument.Location = new Point(14, 53);
            dgvDocument.Margin = new Padding(5, 6, 5, 6);
            dgvDocument.Name = "dgvDocument";
            dgvDocument.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvDocument.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvDocument.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDocument.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvDocument.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDocument.RowTemplate.Height = 50;
            dgvDocument.Size = new Size(1185, 667);
            dgvDocument.TabIndex = 6;
            dgvDocument.CellClick += dgvDocument_CellClick;
            // 
            // document_information_id
            // 
            document_information_id.DataPropertyName = "document_information_id";
            document_information_id.HeaderText = "ID";
            document_information_id.Name = "document_information_id";
            document_information_id.ReadOnly = true;
            // 
            // student_name
            // 
            student_name.DataPropertyName = "student_name";
            student_name.HeaderText = "Student";
            student_name.Name = "student_name";
            student_name.ReadOnly = true;
            student_name.Width = 250;
            // 
            // student_id
            // 
            student_id.DataPropertyName = "student_id";
            student_id.HeaderText = "Student ID";
            student_id.Name = "student_id";
            student_id.ReadOnly = true;
            student_id.Width = 250;
            // 
            // shelf_number
            // 
            shelf_number.DataPropertyName = "shelf_number";
            shelf_number.HeaderText = "Shelf number";
            shelf_number.Name = "shelf_number";
            shelf_number.ReadOnly = true;
            shelf_number.Width = 250;
            // 
            // document_type
            // 
            document_type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            document_type.DataPropertyName = "document_type";
            document_type.HeaderText = "Document";
            document_type.Name = "document_type";
            document_type.ReadOnly = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 6);
            textBox1.Margin = new Padding(5, 6, 5, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1185, 35);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // DocumentDialog
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 742);
            Controls.Add(textBox1);
            Controls.Add(dgvDocument);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "DocumentDialog";
            Text = "DocumentDialog";
            Load += DocumentDialog_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDocument).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDocument;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn document_information_id;
        private DataGridViewTextBoxColumn student_name;
        private DataGridViewTextBoxColumn student_id;
        private DataGridViewTextBoxColumn shelf_number;
        private DataGridViewTextBoxColumn document_type;
    }
}