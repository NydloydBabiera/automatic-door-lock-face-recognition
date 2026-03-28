namespace automatic_door_lock_face_recognition
{
    partial class MessagePopup
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
            panel1 = new Panel();
            lblTitle = new Label();
            lblMessage = new Label();
            btn1 = new Button();
            btn2 = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 50);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(83, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            lblTitle.Click += label1_Click;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(12, 79);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(175, 51);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "label1";
            // 
            // btn1
            // 
            btn1.FlatAppearance.BorderColor = Color.White;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Location = new Point(407, 220);
            btn1.Name = "btn1";
            btn1.Size = new Size(107, 36);
            btn1.TabIndex = 2;
            btn1.Text = "button1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.FlatAppearance.BorderColor = Color.White;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Location = new Point(520, 220);
            btn2.Name = "btn2";
            btn2.Size = new Size(107, 36);
            btn2.TabIndex = 3;
            btn2.Text = "button2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._9187604;
            pictureBox1.Location = new Point(114, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // MessagePopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(649, 268);
            Controls.Add(pictureBox1);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(lblMessage);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MessagePopup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MessagePopup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Label lblMessage;
        private Button btn1;
        private Button btn2;
        private PictureBox pictureBox1;
    }
}