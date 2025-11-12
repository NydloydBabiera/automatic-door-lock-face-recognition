namespace automatic_door_lock_face_recognition
{
    partial class FaceScan
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
            components = new System.ComponentModel.Container();
            imageList1 = new ImageList(components);
            btnConnect = new Button();
            pictureBox1 = new PictureBox();
            txtStreamUrl = new Label();
            btnStartStream = new Button();
            lblStatus = new Label();
            btnCaptureSamples = new Button();
            txtName = new TextBox();
            btnTrain = new Button();
            btnRecognize = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(32, 65);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(195, 44);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(386, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(575, 382);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtStreamUrl
            // 
            txtStreamUrl.AutoSize = true;
            txtStreamUrl.Location = new Point(526, 397);
            txtStreamUrl.Name = "txtStreamUrl";
            txtStreamUrl.Size = new Size(38, 15);
            txtStreamUrl.TabIndex = 2;
            txtStreamUrl.Text = "label1";
            // 
            // btnStartStream
            // 
            btnStartStream.Location = new Point(32, 115);
            btnStartStream.Name = "btnStartStream";
            btnStartStream.Size = new Size(195, 46);
            btnStartStream.TabIndex = 3;
            btnStartStream.Text = "Start Stream";
            btnStartStream.UseVisualStyleBackColor = true;
            btnStartStream.Click += btnStartStream_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(226, 323);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(38, 15);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "label1";
            // 
            // btnCaptureSamples
            // 
            btnCaptureSamples.Location = new Point(32, 167);
            btnCaptureSamples.Name = "btnCaptureSamples";
            btnCaptureSamples.Size = new Size(195, 35);
            btnCaptureSamples.TabIndex = 5;
            btnCaptureSamples.Text = "Capture";
            btnCaptureSamples.UseVisualStyleBackColor = true;
            btnCaptureSamples.Click += btnCaptureSamples_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(32, 394);
            txtName.Name = "txtName";
            txtName.Size = new Size(208, 23);
            txtName.TabIndex = 6;
            // 
            // btnTrain
            // 
            btnTrain.Location = new Point(32, 208);
            btnTrain.Name = "btnTrain";
            btnTrain.Size = new Size(195, 34);
            btnTrain.TabIndex = 7;
            btnTrain.Text = "Train";
            btnTrain.UseVisualStyleBackColor = true;
            btnTrain.Click += btnTrain_Click;
            // 
            // btnRecognize
            // 
            btnRecognize.Location = new Point(32, 248);
            btnRecognize.Name = "btnRecognize";
            btnRecognize.Size = new Size(195, 34);
            btnRecognize.TabIndex = 8;
            btnRecognize.Text = "Recognize";
            btnRecognize.UseVisualStyleBackColor = true;
            btnRecognize.Click += btnRecognize_Click;
            // 
            // FaceScan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 583);
            Controls.Add(btnRecognize);
            Controls.Add(btnTrain);
            Controls.Add(txtName);
            Controls.Add(btnCaptureSamples);
            Controls.Add(lblStatus);
            Controls.Add(btnStartStream);
            Controls.Add(txtStreamUrl);
            Controls.Add(pictureBox1);
            Controls.Add(btnConnect);
            Name = "FaceScan";
            Text = "FaceScan";
            Load += FaceScan_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList1;
        private Button btnConnect;
        private PictureBox pictureBox1;
        private Label txtStreamUrl;
        private Button btnStartStream;
        private Label lblStatus;
        private Button btnCaptureSamples;
        private TextBox txtName;
        private Button btnTrain;
        private Button btnRecognize;
    }
}