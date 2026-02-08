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
            groupBox7 = new GroupBox();
            txtCourse = new TextBox();
            groupBox8 = new GroupBox();
            txtRowNo = new TextBox();
            groupBox9 = new GroupBox();
            txtRecordNo = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocument).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtRFIDtag);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 201);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDocument.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDocument.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDocument.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocument.Columns.AddRange(new DataGridViewColumn[] { document_information_id, document_type, document_rfid_tag, shelf_number, student_name, student_id });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDocument.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDocument.Location = new Point(6, 329);
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
            dgvDocument.Size = new Size(1024, 388);
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
            btnAdd.Location = new Point(521, 222);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 31);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(621, 222);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 31);
            btnSave.TabIndex = 4;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(725, 222);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(96, 31);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(827, 222);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 31);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(926, 221);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 31);
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
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(txtShelfNumber);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(519, 12);
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
            groupBox4.Location = new Point(12, 12);
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
            groupBox6.Location = new Point(12, 265);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1024, 58);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "Search";
            // 
            // groupBox7
            // 
            groupBox7.BackColor = Color.Transparent;
            groupBox7.Controls.Add(txtCourse);
            groupBox7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox7.Location = new Point(12, 137);
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
            groupBox8.Location = new Point(519, 134);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(496, 58);
            groupBox8.TabIndex = 5;
            groupBox8.TabStop = false;
            groupBox8.Text = "Row number";
            // 
            // txtRowNo
            // 
            txtRowNo.Location = new Point(6, 23);
            txtRowNo.Name = "txtRowNo";
            txtRowNo.Size = new Size(484, 29);
            txtRowNo.TabIndex = 0;
            // 
            // groupBox9
            // 
            groupBox9.BackColor = Color.Transparent;
            groupBox9.Controls.Add(txtRecordNo);
            groupBox9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox9.Location = new Point(519, 76);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(496, 58);
            groupBox9.TabIndex = 4;
            groupBox9.TabStop = false;
            groupBox9.Text = "Record number";
            // 
            // txtRecordNo
            // 
            txtRecordNo.Location = new Point(6, 23);
            txtRecordNo.Name = "txtRecordNo";
            txtRecordNo.Size = new Size(484, 29);
            txtRecordNo.TabIndex = 0;
            // 
            // DocumentRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1039, 721);
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
            Name = "DocumentRegistration";
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
        private DataGridViewTextBoxColumn document_information_id;
        private DataGridViewTextBoxColumn document_type;
        private DataGridViewTextBoxColumn document_rfid_tag;
        private DataGridViewTextBoxColumn shelf_number;
        private DataGridViewTextBoxColumn student_name;
        private DataGridViewTextBoxColumn student_id;
        private TextBox textBox1;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private TextBox txtCourse;
        private GroupBox groupBox8;
        private TextBox txtRowNo;
        private GroupBox groupBox9;
        private TextBox txtRecordNo;
    }
}