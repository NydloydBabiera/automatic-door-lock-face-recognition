namespace automatic_door_lock_face_recognition
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            registrationToolStripMenuItem = new ToolStripMenuItem();
            personnelRegistrationToolStripMenuItem = new ToolStripMenuItem();
            documentRegistrationToolStripMenuItem = new ToolStripMenuItem();
            dataLogsToolStripMenuItem = new ToolStripMenuItem();
            personnelLogsToolStripMenuItem = new ToolStripMenuItem();
            documentLogsToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblFaceScan = new Label();
            txtTag = new TextBox();
            dgvDocument = new DataGridView();
            document_information_id = new DataGridViewTextBoxColumn();
            student_name = new DataGridViewTextBoxColumn();
            student_id = new DataGridViewTextBoxColumn();
            shelf_number = new DataGridViewTextBoxColumn();
            document_type = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDocument).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { registrationToolStripMenuItem, dataLogsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1229, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // registrationToolStripMenuItem
            // 
            registrationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { personnelRegistrationToolStripMenuItem, documentRegistrationToolStripMenuItem });
            registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            registrationToolStripMenuItem.Size = new Size(82, 20);
            registrationToolStripMenuItem.Text = "Registration";
            // 
            // personnelRegistrationToolStripMenuItem
            // 
            personnelRegistrationToolStripMenuItem.Name = "personnelRegistrationToolStripMenuItem";
            personnelRegistrationToolStripMenuItem.Size = new Size(196, 22);
            personnelRegistrationToolStripMenuItem.Text = "Personnel Registration";
            personnelRegistrationToolStripMenuItem.Click += personnelRegistrationToolStripMenuItem_Click;
            // 
            // documentRegistrationToolStripMenuItem
            // 
            documentRegistrationToolStripMenuItem.Name = "documentRegistrationToolStripMenuItem";
            documentRegistrationToolStripMenuItem.Size = new Size(196, 22);
            documentRegistrationToolStripMenuItem.Text = "Document Registration";
            documentRegistrationToolStripMenuItem.Click += documentRegistrationToolStripMenuItem_Click;
            // 
            // dataLogsToolStripMenuItem
            // 
            dataLogsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { personnelLogsToolStripMenuItem, documentLogsToolStripMenuItem });
            dataLogsToolStripMenuItem.Name = "dataLogsToolStripMenuItem";
            dataLogsToolStripMenuItem.Size = new Size(71, 20);
            dataLogsToolStripMenuItem.Text = "Data Logs";
            // 
            // personnelLogsToolStripMenuItem
            // 
            personnelLogsToolStripMenuItem.Name = "personnelLogsToolStripMenuItem";
            personnelLogsToolStripMenuItem.Size = new Size(158, 22);
            personnelLogsToolStripMenuItem.Text = "Personnel Logs";
            personnelLogsToolStripMenuItem.Click += personnelLogsToolStripMenuItem_Click;
            // 
            // documentLogsToolStripMenuItem
            // 
            documentLogsToolStripMenuItem.Name = "documentLogsToolStripMenuItem";
            documentLogsToolStripMenuItem.Size = new Size(158, 22);
            documentLogsToolStripMenuItem.Text = "Document Logs";
            documentLogsToolStripMenuItem.Click += documentLogsToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(61, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(502, 337);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(193, 39);
            label1.Name = "label1";
            label1.Size = new Size(190, 45);
            label1.TabIndex = 2;
            label1.Text = "FACE SCAN";
            // 
            // lblFaceScan
            // 
            lblFaceScan.AutoSize = true;
            lblFaceScan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFaceScan.Location = new Point(281, 459);
            lblFaceScan.Name = "lblFaceScan";
            lblFaceScan.Size = new Size(52, 21);
            lblFaceScan.TabIndex = 3;
            lblFaceScan.Text = "label2";
            // 
            // txtTag
            // 
            txtTag.Location = new Point(104, 509);
            txtTag.Name = "txtTag";
            txtTag.Size = new Size(438, 23);
            txtTag.TabIndex = 4;
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
            dgvDocument.Columns.AddRange(new DataGridViewColumn[] { document_information_id, student_name, student_id, shelf_number, document_type });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDocument.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDocument.Location = new Point(569, 100);
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
            dgvDocument.Size = new Size(648, 432);
            dgvDocument.TabIndex = 5;
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
            student_name.Width = 200;
            // 
            // student_id
            // 
            student_id.DataPropertyName = "student_id";
            student_id.HeaderText = "Student ID";
            student_id.Name = "student_id";
            student_id.ReadOnly = true;
            // 
            // shelf_number
            // 
            shelf_number.DataPropertyName = "shelf_number";
            shelf_number.HeaderText = "Shelf number";
            shelf_number.Name = "shelf_number";
            shelf_number.ReadOnly = true;
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
            textBox1.Location = new Point(569, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(567, 23);
            textBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(1142, 71);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(428, 39);
            button2.Name = "button2";
            button2.Size = new Size(168, 23);
            button2.TabIndex = 8;
            button2.Text = "Test Button";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 578);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(dgvDocument);
            Controls.Add(txtTag);
            Controls.Add(lblFaceScan);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDocument).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem registrationToolStripMenuItem;
        private ToolStripMenuItem personnelRegistrationToolStripMenuItem;
        private ToolStripMenuItem documentRegistrationToolStripMenuItem;
        private ToolStripMenuItem dataLogsToolStripMenuItem;
        private ToolStripMenuItem personnelLogsToolStripMenuItem;
        private ToolStripMenuItem documentLogsToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblFaceScan;
        private TextBox txtTag;
        private DataGridView dgvDocument;
        private TextBox textBox1;
        private Button button1;
        private DataGridViewTextBoxColumn document_information_id;
        private DataGridViewTextBoxColumn student_name;
        private DataGridViewTextBoxColumn student_id;
        private DataGridViewTextBoxColumn shelf_number;
        private DataGridViewTextBoxColumn document_type;
        private Button button2;
    }
}