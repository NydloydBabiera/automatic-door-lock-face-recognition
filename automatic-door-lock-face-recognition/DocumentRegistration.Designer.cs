namespace automatic_door_lock_face_recognition
{
    partial class DocumentRegistration
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            txtDocumentType = new TextBox();
            groupBox2 = new GroupBox();
            txtRFIDtag = new TextBox();
            dgvDocument = new DataGridView();
            document_information_id = new DataGridViewTextBoxColumn();
            document_type = new DataGridViewTextBoxColumn();
            document_rfid_tag = new DataGridViewTextBoxColumn();
            shelf_number = new DataGridViewTextBoxColumn();
            student_name = new DataGridViewTextBoxColumn();
            student_id = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnSave = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            txtShelfNumber = new TextBox();
            groupBox3 = new GroupBox();
            txtStudentName = new TextBox();
            groupBox4 = new GroupBox();
            txtStudentID = new TextBox();
            groupBox5 = new GroupBox();
            textBox1 = new TextBox();
            groupBox6 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocument).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDocumentType);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 58);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Document Type";
            // 
            // txtDocumentType
            // 
            txtDocumentType.Location = new Point(6, 23);
            txtDocumentType.Name = "txtDocumentType";
            txtDocumentType.Size = new Size(484, 29);
            txtDocumentType.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtRFIDtag);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(496, 58);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "RFID Tag";
            // 
            // txtRFIDtag
            // 
            txtRFIDtag.Location = new Point(6, 23);
            txtRFIDtag.Name = "txtRFIDtag";
            txtRFIDtag.Size = new Size(484, 29);
            txtRFIDtag.TabIndex = 0;
            // 
            // dgvDocument
            // 
            dgvDocument.AllowUserToAddRows = false;
            dgvDocument.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDocument.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvDocument.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvDocument.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocument.Columns.AddRange(new DataGridViewColumn[] { document_information_id, document_type, document_rfid_tag, shelf_number, student_name, student_id });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvDocument.DefaultCellStyle = dataGridViewCellStyle8;
            dgvDocument.Location = new Point(6, 287);
            dgvDocument.Name = "dgvDocument";
            dgvDocument.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvDocument.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvDocument.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDocument.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvDocument.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDocument.Size = new Size(1024, 367);
            dgvDocument.TabIndex = 2;
            dgvDocument.CellClick += dgvDocument_CellClick;
            // 
            // document_information_id
            // 
            document_information_id.DataPropertyName = "document_information_id";
            document_information_id.HeaderText = "ID";
            document_information_id.Name = "document_information_id";
            document_information_id.ReadOnly = true;
            // 
            // document_type
            // 
            document_type.DataPropertyName = "document_type";
            document_type.HeaderText = "Type";
            document_type.Name = "document_type";
            document_type.ReadOnly = true;
            document_type.Width = 150;
            // 
            // document_rfid_tag
            // 
            document_rfid_tag.DataPropertyName = "document_rfid_tag";
            document_rfid_tag.HeaderText = "RFID Tag";
            document_rfid_tag.Name = "document_rfid_tag";
            document_rfid_tag.ReadOnly = true;
            document_rfid_tag.Width = 250;
            // 
            // shelf_number
            // 
            shelf_number.DataPropertyName = "shelf_number";
            shelf_number.HeaderText = "Shelf No.";
            shelf_number.Name = "shelf_number";
            shelf_number.ReadOnly = true;
            // 
            // student_name
            // 
            student_name.DataPropertyName = "student_name";
            student_name.HeaderText = "Student Name";
            student_name.Name = "student_name";
            student_name.ReadOnly = true;
            student_name.Width = 250;
            // 
            // student_id
            // 
            student_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            student_id.DataPropertyName = "student_id";
            student_id.HeaderText = "Student ID";
            student_id.Name = "student_id";
            student_id.ReadOnly = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(534, 177);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 37);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(634, 177);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 37);
            btnSave.TabIndex = 4;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(738, 177);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(96, 37);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(840, 177);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 37);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(939, 177);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 37);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtShelfNumber
            // 
            txtShelfNumber.Location = new Point(6, 23);
            txtShelfNumber.Name = "txtShelfNumber";
            txtShelfNumber.Size = new Size(484, 29);
            txtShelfNumber.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtShelfNumber);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 159);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(496, 58);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Shelf number";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(6, 23);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(484, 29);
            txtStudentName.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtStudentName);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(525, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(496, 58);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Student Name";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(6, 23);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(484, 29);
            txtStudentID.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtStudentID);
            groupBox5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(525, 86);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(496, 58);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Student ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 23);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search for name. RFID tag, shelf no., student name, student id";
            textBox1.Size = new Size(1003, 29);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(textBox1);
            groupBox6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox6.Location = new Point(6, 223);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1024, 58);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "Search";
            // 
            // DocumentRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 666);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(dgvDocument);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "DocumentRegistration";
            Text = "DocumentRegistration";
            Load += DocumentRegistration_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocument).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDocumentType;
        private GroupBox groupBox2;
        private TextBox txtRFIDtag;
        private DataGridView dgvDocument;
        private Button btnAdd;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnCancel;
        private TextBox txtShelfNumber;
        private GroupBox groupBox3;
        private TextBox txtStudentName;
        private GroupBox groupBox4;
        private TextBox txtStudentID;
        private GroupBox groupBox5;
        private DataGridViewTextBoxColumn document_information_id;
        private DataGridViewTextBoxColumn document_type;
        private DataGridViewTextBoxColumn document_rfid_tag;
        private DataGridViewTextBoxColumn shelf_number;
        private DataGridViewTextBoxColumn student_name;
        private DataGridViewTextBoxColumn student_id;
        private TextBox textBox1;
        private GroupBox groupBox6;
    }
}