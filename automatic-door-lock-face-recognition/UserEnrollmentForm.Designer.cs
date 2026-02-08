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
            label4 = new Label();
            txtDesignation = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label2 = new Label();
            txtMiddleName = new TextBox();
            label1 = new Label();
            txtFirstName = new TextBox();
            lblCameraStream = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPersonnels).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            dgvPersonnels.Columns.AddRange(new DataGridViewColumn[] { personnel_information_id, first_name, middle_name, last_name, designation });
            dgvPersonnels.Location = new Point(12, 425);
            dgvPersonnels.Name = "dgvPersonnels";
            dgvPersonnels.ReadOnly = true;
            dgvPersonnels.RowHeadersVisible = false;
            dgvPersonnels.Size = new Size(1320, 282);
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
            textBox6.Location = new Point(12, 390);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(1320, 29);
            textBox6.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(817, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(515, 356);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(211, 270);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(129, 37);
            btnCancel.TabIndex = 35;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnReloadCamera
            // 
            btnReloadCamera.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReloadCamera.Location = new Point(261, 313);
            btnReloadCamera.Name = "btnReloadCamera";
            btnReloadCamera.Size = new Size(238, 31);
            btnReloadCamera.TabIndex = 34;
            btnReloadCamera.Text = "RELOAD CAMERA";
            btnReloadCamera.UseVisualStyleBackColor = true;
            // 
            // btnImageSaving
            // 
            btnImageSaving.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnImageSaving.Location = new Point(35, 313);
            btnImageSaving.Name = "btnImageSaving";
            btnImageSaving.Size = new Size(220, 31);
            btnImageSaving.TabIndex = 32;
            btnImageSaving.Text = "CAPTURE IMAGE";
            btnImageSaving.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(398, 234);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 31);
            btnDelete.TabIndex = 31;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(277, 234);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(115, 31);
            btnEdit.TabIndex = 30;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(156, 234);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 31);
            btnSave.TabIndex = 29;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(35, 234);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 31);
            btnAdd.TabIndex = 28;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 165);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 26;
            label4.Text = "Designation:";
            // 
            // txtDesignation
            // 
            txtDesignation.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDesignation.Location = new Point(156, 165);
            txtDesignation.Name = "txtDesignation";
            txtDesignation.Size = new Size(343, 25);
            txtDesignation.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 134);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 24;
            label3.Text = "Lastname:";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(156, 134);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(343, 25);
            txtLastName.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 103);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 22;
            label2.Text = "Middlename:";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMiddleName.Location = new Point(156, 103);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(343, 25);
            txtMiddleName.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 72);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 20;
            label1.Text = "Firstname:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(156, 72);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(343, 25);
            txtFirstName.TabIndex = 19;
            // 
            // lblCameraStream
            // 
            lblCameraStream.AutoSize = true;
            lblCameraStream.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCameraStream.Location = new Point(190, 366);
            lblCameraStream.Name = "lblCameraStream";
            lblCameraStream.Size = new Size(54, 21);
            lblCameraStream.TabIndex = 33;
            lblCameraStream.Text = "label6";
            // 
            // UserEnrollmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 721);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnReloadCamera);
            Controls.Add(btnImageSaving);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(txtDesignation);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtMiddleName);
            Controls.Add(label1);
            Controls.Add(txtFirstName);
            Controls.Add(lblCameraStream);
            Controls.Add(textBox6);
            Controls.Add(dgvPersonnels);
            Name = "UserEnrollmentForm";
            Text = "UserEnrollmentForm";
            FormClosing += UserEnrollmentForm_FormClosing;
            Load += UserEnrollmentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersonnels).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private TextBox txtPhoneNo;
        private DataGridView dgvPersonnels;
        private TextBox textBox6;
        private DataGridViewTextBoxColumn personnel_information_id;
        private DataGridViewTextBoxColumn first_name;
        private DataGridViewTextBoxColumn middle_name;
        private DataGridViewTextBoxColumn last_name;
        private DataGridViewTextBoxColumn designation;
        private PictureBox pictureBox1;
        private Button btnCancel;
        private Button btnReloadCamera;
        private Button btnImageSaving;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSave;
        private Button btnAdd;
        private Label label4;
        private TextBox txtDesignation;
        private Label label3;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtMiddleName;
        private Label label1;
        private TextBox txtFirstName;
        private Label lblCameraStream;
    }
}