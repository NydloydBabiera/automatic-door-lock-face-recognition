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
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { registrationToolStripMenuItem, dataLogsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1344, 24);
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
            pictureBox1.Size = new Size(1237, 516);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(620, 40);
            label1.Name = "label1";
            label1.Size = new Size(195, 45);
            label1.TabIndex = 2;
            label1.Text = "SCAN HERE";
            // 
            // lblFaceScan
            // 
            lblFaceScan.AutoSize = true;
            lblFaceScan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFaceScan.Location = new Point(532, 630);
            lblFaceScan.Name = "lblFaceScan";
            lblFaceScan.Size = new Size(52, 21);
            lblFaceScan.TabIndex = 3;
            lblFaceScan.Text = "label2";
            // 
            // txtTag
            // 
            txtTag.Location = new Point(532, 669);
            txtTag.Name = "txtTag";
            txtTag.Size = new Size(438, 23);
            txtTag.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 721);
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
    }
}