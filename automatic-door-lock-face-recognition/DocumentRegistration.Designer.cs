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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            groupBox2 = new GroupBox();
            btnClearRfidTag = new Button();
            txtRFIDtag = new TextBox();
            dgvDocument = new DataGridView();
            document_information_id = new DataGridViewTextBoxColumn();
            student_name = new DataGridViewTextBoxColumn();
            student_id = new DataGridViewTextBoxColumn();
            course = new DataGridViewTextBoxColumn();
            shelf_number = new DataGridViewTextBoxColumn();
            row_num = new DataGridViewTextBoxColumn();
            document_rfid_tag = new DataGridViewTextBoxColumn();
            record_no = new DataGridViewTextBoxColumn();
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
            groupBox7 = new GroupBox();
            txtCourse = new TextBox();
            groupBox8 = new GroupBox();
            txtRowNo = new TextBox();
            groupBox9 = new GroupBox();
            txtRecordNo = new TextBox();
            groupBox1 = new GroupBox();
            txtMiddleName = new TextBox();
            groupBox10 = new GroupBox();
            txtLastName = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocument).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox10.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClearRfidTag);
            groupBox2.Controls.Add(txtRFIDtag);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(12, 204);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(496, 58);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "RFID Tag";
            // 
            // btnClearRfidTag
            // 
            btnClearRfidTag.ForeColor = Color.Black;
            btnClearRfidTag.Location = new Point(451, 22);
            btnClearRfidTag.Name = "btnClearRfidTag";
            btnClearRfidTag.Size = new Size(39, 30);
            btnClearRfidTag.TabIndex = 1;
            btnClearRfidTag.Text = "X";
            btnClearRfidTag.UseVisualStyleBackColor = true;
            btnClearRfidTag.Click += btnClearRfidTag_Click;
            // 
            // txtRFIDtag
            // 
            txtRFIDtag.Location = new Point(6, 23);
            txtRFIDtag.Name = "txtRFIDtag";
            txtRFIDtag.ReadOnly = true;
            txtRFIDtag.Size = new Size(453, 29);
            txtRFIDtag.TabIndex = 0;
            txtRFIDtag.TextChanged += txtRFIDtag_TextChanged;
            // 
            // dgvDocument
            // 
            dgvDocument.AllowUserToAddRows = false;
            dgvDocument.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDocument.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDocument.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDocument.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDocument.ColumnHeadersHeight = 35;
            dgvDocument.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDocument.Columns.AddRange(new DataGridViewColumn[] { document_information_id, student_name, student_id, course, shelf_number, row_num, document_rfid_tag, record_no });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDocument.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDocument.Location = new Point(3, 369);
            dgvDocument.Name = "dgvDocument";
            dgvDocument.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvDocument.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvDocument.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDocument.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvDocument.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDocument.Size = new Size(1033, 388);
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
            student_id.DataPropertyName = "student_id";
            student_id.HeaderText = "Student ID";
            student_id.Name = "student_id";
            student_id.ReadOnly = true;
            // 
            // course
            // 
            course.DataPropertyName = "course";
            course.HeaderText = "Course";
            course.Name = "course";
            course.ReadOnly = true;
            // 
            // shelf_number
            // 
            shelf_number.DataPropertyName = "shelf_number";
            shelf_number.HeaderText = "Shelf No.";
            shelf_number.Name = "shelf_number";
            shelf_number.ReadOnly = true;
            // 
            // row_num
            // 
            row_num.DataPropertyName = "row_num";
            row_num.HeaderText = "Row";
            row_num.Name = "row_num";
            row_num.ReadOnly = true;
            // 
            // document_rfid_tag
            // 
            document_rfid_tag.DataPropertyName = "document_rfid_tag";
            document_rfid_tag.HeaderText = "RFID Tag";
            document_rfid_tag.Name = "document_rfid_tag";
            document_rfid_tag.ReadOnly = true;
            document_rfid_tag.Width = 150;
            // 
            // record_no
            // 
            record_no.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            record_no.DataPropertyName = "record_no";
            record_no.HeaderText = "Record number";
            record_no.Name = "record_no";
            record_no.ReadOnly = true;
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImageLayout = ImageLayout.None;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(92, 268);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(155, 40);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(250, 268);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(155, 40);
            btnSave.TabIndex = 4;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(411, 268);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(155, 40);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(572, 268);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(155, 40);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(733, 268);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(155, 40);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtShelfNumber
            // 
            txtShelfNumber.Location = new Point(6, 21);
            txtShelfNumber.Name = "txtShelfNumber";
            txtShelfNumber.Size = new Size(484, 29);
            txtShelfNumber.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(txtShelfNumber);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(525, 76);
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
            txtStudentName.Size = new Size(298, 29);
            txtStudentName.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtStudentName);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(12, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(311, 58);
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
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(12, 76);
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
            groupBox6.ForeColor = Color.White;
            groupBox6.Location = new Point(3, 305);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1033, 58);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "Search";
            // 
            // groupBox7
            // 
            groupBox7.BackColor = Color.Transparent;
            groupBox7.Controls.Add(txtCourse);
            groupBox7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox7.ForeColor = Color.White;
            groupBox7.Location = new Point(12, 140);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(496, 58);
            groupBox7.TabIndex = 3;
            groupBox7.TabStop = false;
            groupBox7.Text = "Course";
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(6, 23);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(484, 29);
            txtCourse.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.BackColor = Color.Transparent;
            groupBox8.Controls.Add(txtRowNo);
            groupBox8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox8.ForeColor = Color.White;
            groupBox8.Location = new Point(525, 204);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(496, 58);
            groupBox8.TabIndex = 5;
            groupBox8.TabStop = false;
            groupBox8.Text = "Row number";
            // 
            // txtRowNo
            // 
            txtRowNo.Location = new Point(6, 22);
            txtRowNo.Name = "txtRowNo";
            txtRowNo.ReadOnly = true;
            txtRowNo.Size = new Size(484, 29);
            txtRowNo.TabIndex = 0;
            // 
            // groupBox9
            // 
            groupBox9.BackColor = Color.Transparent;
            groupBox9.Controls.Add(txtRecordNo);
            groupBox9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox9.ForeColor = Color.White;
            groupBox9.Location = new Point(525, 140);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(496, 58);
            groupBox9.TabIndex = 4;
            groupBox9.TabStop = false;
            groupBox9.Text = "Record number";
            // 
            // txtRecordNo
            // 
            txtRecordNo.Location = new Point(6, 22);
            txtRecordNo.Name = "txtRecordNo";
            txtRecordNo.Size = new Size(484, 29);
            txtRecordNo.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMiddleName);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(329, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 58);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Middle Name";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(6, 23);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(307, 29);
            txtMiddleName.TabIndex = 0;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(txtLastName);
            groupBox10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox10.ForeColor = Color.White;
            groupBox10.Location = new Point(655, 12);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(360, 58);
            groupBox10.TabIndex = 5;
            groupBox10.TabStop = false;
            groupBox10.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(6, 23);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(347, 29);
            txtLastName.TabIndex = 0;
            txtLastName.TextChanged += txtLastName_TextChanged;
            txtLastName.Leave += txtLastName_Leave;
            // 
            // DocumentRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1039, 761);
            Controls.Add(groupBox10);
            Controls.Add(groupBox1);
            Controls.Add(btnDelete);
            Controls.Add(groupBox8);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(groupBox7);
            Controls.Add(btnSave);
            Controls.Add(groupBox9);
            Controls.Add(btnEdit);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(dgvDocument);
            Controls.Add(groupBox2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DocumentRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DocumentRegistration";
            Load += DocumentRegistration_Load;
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
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
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
        private TextBox textBox1;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private TextBox txtCourse;
        private GroupBox groupBox8;
        private TextBox txtRowNo;
        private GroupBox groupBox9;
        private TextBox txtRecordNo;
        private GroupBox groupBox1;
        private TextBox txtMiddleName;
        private GroupBox groupBox10;
        private TextBox txtLastName;
        private DataGridViewTextBoxColumn document_information_id;
        private DataGridViewTextBoxColumn student_name;
        private DataGridViewTextBoxColumn student_id;
        private DataGridViewTextBoxColumn course;
        private DataGridViewTextBoxColumn shelf_number;
        private DataGridViewTextBoxColumn row_num;
        private DataGridViewTextBoxColumn document_rfid_tag;
        private DataGridViewTextBoxColumn record_no;
        private Button btnClearRfidTag;
    }
}