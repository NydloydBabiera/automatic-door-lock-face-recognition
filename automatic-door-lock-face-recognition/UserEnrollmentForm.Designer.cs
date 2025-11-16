namespace automatic_door_lock_face_recognition
{
    partial class UserEnrollmentForm
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
            groupBox1 = new GroupBox();
            btnCancel = new Button();
            btnReloadCamera = new Button();
            btnImageSaving = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            txtPhoneNo = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label2 = new Label();
            txtMiddleName = new TextBox();
            label1 = new Label();
            txtFirstName = new TextBox();
            lblCameraStream = new Label();
            dgvPersonnels = new DataGridView();
            personnel_information_id = new DataGridViewTextBoxColumn();
            first_name = new DataGridViewTextBoxColumn();
            middle_name = new DataGridViewTextBoxColumn();
            last_name = new DataGridViewTextBoxColumn();
            email_address = new DataGridViewTextBoxColumn();
            phone_number = new DataGridViewTextBoxColumn();
            textBox6 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPersonnels).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnReloadCamera);
            groupBox1.Controls.Add(btnImageSaving);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPhoneNo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMiddleName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(lblCameraStream);
            groupBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1067, 388);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personnel Registration";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(202, 252);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(129, 37);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnReloadCamera
            // 
            btnReloadCamera.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReloadCamera.Location = new Point(252, 295);
            btnReloadCamera.Name = "btnReloadCamera";
            btnReloadCamera.Size = new Size(238, 31);
            btnReloadCamera.TabIndex = 17;
            btnReloadCamera.Text = "RELOAD CAMERA";
            btnReloadCamera.UseVisualStyleBackColor = true;
            btnReloadCamera.Click += btnReloadCamera_Click;
            // 
            // btnImageSaving
            // 
            btnImageSaving.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnImageSaving.Location = new Point(26, 295);
            btnImageSaving.Name = "btnImageSaving";
            btnImageSaving.Size = new Size(220, 31);
            btnImageSaving.TabIndex = 15;
            btnImageSaving.Text = "CAPTURE IMAGE";
            btnImageSaving.UseVisualStyleBackColor = true;
            btnImageSaving.Click += btnImageSaving_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(389, 216);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 31);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(268, 216);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(115, 31);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(147, 216);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 31);
            btnSave.TabIndex = 12;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(26, 216);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 31);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(538, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(515, 356);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 181);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 9;
            label5.Text = "Phone no.:";
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNo.Location = new Point(147, 181);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(343, 25);
            txtPhoneNo.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 147);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 7;
            label4.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(147, 147);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(343, 25);
            txtEmail.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 116);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 5;
            label3.Text = "Lastname:";
            label3.Click += label3_Click;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(147, 116);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(343, 25);
            txtLastName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 85);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 3;
            label2.Text = "Middlename:";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMiddleName.Location = new Point(147, 85);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(343, 25);
            txtMiddleName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 54);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 1;
            label1.Text = "Firstname:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(147, 54);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(343, 25);
            txtFirstName.TabIndex = 0;
            // 
            // lblCameraStream
            // 
            lblCameraStream.AutoSize = true;
            lblCameraStream.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCameraStream.Location = new Point(181, 348);
            lblCameraStream.Name = "lblCameraStream";
            lblCameraStream.Size = new Size(54, 21);
            lblCameraStream.TabIndex = 16;
            lblCameraStream.Text = "label6";
            // 
            // dgvPersonnels
            // 
            dgvPersonnels.AllowUserToAddRows = false;
            dgvPersonnels.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPersonnels.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPersonnels.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPersonnels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonnels.Columns.AddRange(new DataGridViewColumn[] { personnel_information_id, first_name, middle_name, last_name, email_address, phone_number });
            dgvPersonnels.Location = new Point(12, 441);
            dgvPersonnels.Name = "dgvPersonnels";
            dgvPersonnels.ReadOnly = true;
            dgvPersonnels.RowHeadersVisible = false;
            dgvPersonnels.Size = new Size(1067, 282);
            dgvPersonnels.TabIndex = 11;
            dgvPersonnels.CellClick += dgvPersonnels_CellClick;
            dgvPersonnels.CellContentClick += dgvPersonnels_CellContentClick;
            // 
            // personnel_information_id
            // 
            personnel_information_id.DataPropertyName = "personnel_information_id";
            personnel_information_id.HeaderText = "ID";
            personnel_information_id.Name = "personnel_information_id";
            personnel_information_id.ReadOnly = true;
            // 
            // first_name
            // 
            first_name.DataPropertyName = "first_name";
            first_name.HeaderText = "First name";
            first_name.Name = "first_name";
            first_name.ReadOnly = true;
            first_name.Width = 200;
            // 
            // middle_name
            // 
            middle_name.DataPropertyName = "middle_name";
            middle_name.HeaderText = "Middle name";
            middle_name.Name = "middle_name";
            middle_name.ReadOnly = true;
            middle_name.Width = 200;
            // 
            // last_name
            // 
            last_name.DataPropertyName = "last_name";
            last_name.HeaderText = "Last name";
            last_name.Name = "last_name";
            last_name.ReadOnly = true;
            last_name.Width = 200;
            // 
            // email_address
            // 
            email_address.DataPropertyName = "email_address";
            email_address.HeaderText = "Email";
            email_address.Name = "email_address";
            email_address.ReadOnly = true;
            email_address.Width = 200;
            // 
            // phone_number
            // 
            phone_number.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            phone_number.DataPropertyName = "phone_number";
            phone_number.HeaderText = "Contact Number";
            phone_number.Name = "phone_number";
            phone_number.ReadOnly = true;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(12, 406);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(1067, 29);
            textBox6.TabIndex = 12;
            // 
            // UserEnrollmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 735);
            Controls.Add(textBox6);
            Controls.Add(dgvPersonnels);
            Controls.Add(groupBox1);
            Name = "UserEnrollmentForm";
            Text = "UserEnrollmentForm";
            Load += UserEnrollmentForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPersonnels).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtFirstName;
        private Label label5;
        private TextBox txtPhoneNo;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtMiddleName;
        private PictureBox pictureBox1;
        private DataGridView dgvPersonnels;
        private TextBox textBox6;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSave;
        private Button btnImageSaving;
        private Label lblCameraStream;
        private Button btnReloadCamera;
        private DataGridViewTextBoxColumn personnel_information_id;
        private DataGridViewTextBoxColumn first_name;
        private DataGridViewTextBoxColumn middle_name;
        private DataGridViewTextBoxColumn last_name;
        private DataGridViewTextBoxColumn email_address;
        private DataGridViewTextBoxColumn phone_number;
        private Button btnCancel;
    }
}