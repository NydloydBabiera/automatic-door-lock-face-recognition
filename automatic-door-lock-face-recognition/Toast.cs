using System;
using System.Drawing;
using System.Windows.Forms;

namespace automatic_door_lock_face_recognition
{
    public partial class Toast : Form
    {
        private System.Windows.Forms.Timer timer;

        public Toast(string title, string message, Color bgColor, int duration)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.TopMost = true;
            this.ShowInTaskbar = false;

            panelMain.BackColor = bgColor;

            lblTitle.Text = title;
            lblContent.Text = message;

            // Position bottom-right
            var screen = Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point(screen.Width - this.Width - 10, screen.Height - this.Height - 10);

            // Timer for auto close
            timer = new System.Windows.Forms.Timer();
            timer.Interval = duration;
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                this.Close();
            };
            timer.Start();
        }
    }
}
