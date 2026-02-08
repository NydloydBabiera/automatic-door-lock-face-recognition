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
            dgvPersonnels = new DataGridView();
            personnel_information_id = new DataGridViewTextBoxColumn();
            first_name = new DataGridViewTextBoxColumn();
            middle_name = new DataGridViewTextBoxColumn();
            last_name = new DataGridViewTextBoxColumn();
            designation = new DataGridViewTextBoxColumn();
            textBox6 = new TextBox();
            pictureBox1 = new PictureBox();
            btnCancel = new Button();
            btnReloadCamera = new Button();
            btnImageSaving = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            txtDesignation = new TextBox();
            txtLastName = new TextBox();
            txtMiddleName = new TextBox();
            txtFirstName = new TextBox();
            lblCameraStream = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvPersonnels).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPersonnels
            // 
            dgvPersonnels.AllowUserToAddRows = false;
            dgvPersonnels.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPersonnels.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPersonnels.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPersonnels.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPersonnels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonnels.Columns.AddRange(new DataGridViewColumn[] { personnel_information_id, first_name, middle_name, last_name, designation });
            dgvPersonnels.Location = new Point(18, 211);
            dgvPersonnels.Name = "dgvPersonnels";
            dgvPersonnels.ReadOnly = true;
            dgvPersonnels.RowHeadersVisible = false;
            dgvPersonnels.Size = new Size(778, 220);
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
            first_name.Width = 170;
            // 
            // middle_name
            // 
            middle_name.DataPropertyName = "middle_name";
            middle_name.HeaderText = "Middle name";
            middle_name.Name = "middle_name";
            middle_name.ReadOnly = true;
            middle_name.Width = 170;
            // 
            // last_name
            // 
            last_name.DataPropertyName = "last_name";
            last_name.HeaderText = "Last name";
            last_name.Name = "last_name";
            last_name.ReadOnly = true;
            last_name.Width = 170;
            // 
            // designation
            // 
            designation.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            designation.DataPropertyName = "designation";
            designation.HeaderText = "Designation";
            designation.Name = "designation";
            designation.ReadOnly = true;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(18, 176);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Search personnel";
            textBox6.Size = new Size(778, 29);
            textBox6.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(817, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(515, 356);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(573, 135);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(129, 37);
            btnCancel.TabIndex = 35;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnReloadCamera
            // 
            btnReloadCamera.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReloadCamera.Location = new Point(1067, 400);
            btnReloadCamera.Name = "btnReloadCamera";
            btnReloadCamera.Size = new Size(238, 31);
            btnReloadCamera.TabIndex = 34;
            btnReloadCamera.Text = "RELOAD CAMERA";
            btnReloadCamera.UseVisualStyleBackColor = true;
            btnReloadCamera.Click += btnReloadCamera_Click_1;
            // 
            // btnImageSaving
            // 
            btnImageSaving.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnImageSaving.Location = new Point(841, 400);
            btnImageSaving.Name = "btnImageSaving";
            btnImageSaving.Size = new Size(220, 31);
            btnImageSaving.TabIndex = 32;
            btnImageSaving.Text = "CAPTURE IMAGE";
            btnImageSaving.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(452, 135);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 37);
            btnDelete.TabIndex = 31;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(331, 135);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(115, 37);
            btnEdit.TabIndex = 30;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(210, 135);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 37);
            btnSave.TabIndex = 29;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(89, 135);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 37);
            btnAdd.TabIndex = 28;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtDesignation
            // 
            txtDesignation.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDesignation.Location = new Point(6, 26);
            txtDesignation.Name = "txtDesignation";
            txtDesignation.Size = new Size(358, 25);
            txtDesignation.TabIndex = 25;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(6, 27);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(358, 25);
            txtLastName.TabIndex = 23;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMiddleName.Location = new Point(6, 26);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(358, 25);
            txtMiddleName.TabIndex = 21;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(6, 26);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(358, 25);
            txtFirstName.TabIndex = 19;
            // 
            // lblCameraStream
            // 
            lblCameraStream.AutoSize = true;
            lblCameraStream.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCameraStream.Location = new Point(1044, 14);
            lblCameraStream.Name = "lblCameraStream";
            lblCameraStream.Size = new Size(54, 21);
            lblCameraStream.TabIndex = 33;
            lblCameraStream.Text = "label6";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 58);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "First Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtMiddleName);
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(388, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(370, 58);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "Middle Name";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtLastName);
            groupBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(388, 75);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(370, 58);
            groupBox3.TabIndex = 38;
            groupBox3.TabStop = false;
            groupBox3.Text = "Last Name";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtDesignation);
            groupBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(12, 76);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(370, 57);
            groupBox4.TabIndex = 38;
            groupBox4.TabStop = false;
            groupBox4.Text = "Designation";
            // 
            // UserEnrollmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1344, 447);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnReloadCamera);
            Controls.Add(btnImageSaving);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(lblCameraStream);
            Controls.Add(textBox6);
            Controls.Add(dgvPersonnels);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserEnrollmentForm";
            Text = "UserEnrollmentForm";
            FormClosing += UserEnrollmentForm_FormClosing;
            Load += UserEnrollmentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersonnels).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private TextBox txtPhoneNo;
        private DataGridView dgvPersonnels;
        private TextBox textBox6;
        private PictureBox pictureBox1;
        private Button btnCancel;
        private Button btnReloadCamera;
        private Button btnImageSaving;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSave;
        private Button btnAdd;
        private TextBox txtDesignation;
        private TextBox txtLastName;
        private TextBox txtMiddleName;
        private TextBox txtFirstName;
        private Label lblCameraStream;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DataGridViewTextBoxColumn personnel_information_id;
        private DataGridViewTextBoxColumn first_name;
        private DataGridViewTextBoxColumn middle_name;
        private DataGridViewTextBoxColumn last_name;
        private DataGridViewTextBoxColumn designation;
    }
}