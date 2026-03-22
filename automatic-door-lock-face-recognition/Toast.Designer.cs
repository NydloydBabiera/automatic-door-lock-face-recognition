namespace automatic_door_lock_face_recognition
{
    partial class Toast
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
            panelMain = new Panel();
            lblContent = new Label();
            lblTitle = new Label();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(lblContent);
            panelMain.Controls.Add(lblTitle);
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(430, 132);
            panelMain.TabIndex = 0;
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContent.Location = new Point(13, 40);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(65, 25);
            lblContent.TabIndex = 1;
            lblContent.Text = "label1";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(4, 2);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(65, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // Toast
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 130);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Toast";
            Text = "Toast";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Label lblContent;
        private Label lblTitle;
    }
}