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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            registrationToolStripMenuItem = new ToolStripMenuItem();
            personnelRegistrationToolStripMenuItem = new ToolStripMenuItem();
            documentRegistrationToolStripMenuItem = new ToolStripMenuItem();
            dataLogsToolStripMenuItem = new ToolStripMenuItem();
            documentLogsToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            documentLogsToolStripMenuItem1 = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblFaceScan = new Label();
            txtTag = new TextBox();
            button1 = new Button();
            ndtclogo = new PictureBox();
            personnelLogsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ndtclogo).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { registrationToolStripMenuItem, dataLogsToolStripMenuItem, reportsToolStripMenuItem });
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
            dataLogsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { documentLogsToolStripMenuItem });
            dataLogsToolStripMenuItem.Name = "dataLogsToolStripMenuItem";
            dataLogsToolStripMenuItem.Size = new Size(71, 20);
            dataLogsToolStripMenuItem.Text = "Data Logs";
            // 
            // documentLogsToolStripMenuItem
            // 
            documentLogsToolStripMenuItem.Name = "documentLogsToolStripMenuItem";
            documentLogsToolStripMenuItem.Size = new Size(158, 22);
            documentLogsToolStripMenuItem.Text = "Document Logs";
            documentLogsToolStripMenuItem.Click += documentLogsToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { documentLogsToolStripMenuItem1, personnelLogsToolStripMenuItem });
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(59, 20);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // documentLogsToolStripMenuItem1
            // 
            documentLogsToolStripMenuItem1.Name = "documentLogsToolStripMenuItem1";
            documentLogsToolStripMenuItem1.Size = new Size(180, 22);
            documentLogsToolStripMenuItem1.Text = "Document Logs";
            documentLogsToolStripMenuItem1.Click += documentLogsToolStripMenuItem1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(309, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(714, 516);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(309, 24);
            label1.Name = "label1";
            label1.Size = new Size(714, 74);
            label1.TabIndex = 2;
            label1.Text = "Records Security System: Automated Door Lock Using \r\nImage Processing and RFID\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblFaceScan
            // 
            lblFaceScan.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFaceScan.Location = new Point(309, 619);
            lblFaceScan.Name = "lblFaceScan";
            lblFaceScan.Size = new Size(714, 93);
            lblFaceScan.TabIndex = 3;
            lblFaceScan.Text = "label2";
            lblFaceScan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTag
            // 
            txtTag.Location = new Point(1058, 211);
            txtTag.Multiline = true;
            txtTag.Name = "txtTag";
            txtTag.Size = new Size(258, 379);
            txtTag.TabIndex = 4;
            txtTag.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(1137, 607);
            button1.Name = "button1";
            button1.Size = new Size(118, 33);
            button1.TabIndex = 5;
            button1.Text = "test add logs";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // ndtclogo
            // 
            ndtclogo.BackColor = Color.Transparent;
            ndtclogo.BackgroundImageLayout = ImageLayout.None;
            ndtclogo.Image = (Image)resources.GetObject("ndtclogo.Image");
            ndtclogo.Location = new Point(222, 27);
            ndtclogo.Name = "ndtclogo";
            ndtclogo.Size = new Size(93, 74);
            ndtclogo.SizeMode = PictureBoxSizeMode.Zoom;
            ndtclogo.TabIndex = 6;
            ndtclogo.TabStop = false;
            ndtclogo.Click += pictureBox2_Click;
            // 
            // personnelLogsToolStripMenuItem
            // 
            personnelLogsToolStripMenuItem.Name = "personnelLogsToolStripMenuItem";
            personnelLogsToolStripMenuItem.Size = new Size(180, 22);
            personnelLogsToolStripMenuItem.Text = "Personnel Logs";
            personnelLogsToolStripMenuItem.Click += personnelLogsToolStripMenuItem_Click_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1344, 721);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(txtTag);
            Controls.Add(lblFaceScan);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(ndtclogo);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ndtclogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem registrationToolStripMenuItem;
        private ToolStripMenuItem personnelRegistrationToolStripMenuItem;
        private ToolStripMenuItem documentRegistrationToolStripMenuItem;
        private ToolStripMenuItem dataLogsToolStripMenuItem;
        private ToolStripMenuItem documentLogsToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblFaceScan;
        private TextBox txtTag;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem documentLogsToolStripMenuItem1;
        private Button button1;
        private PictureBox ndtclogo;
        private ToolStripMenuItem personnelLogsToolStripMenuItem;
    }
}