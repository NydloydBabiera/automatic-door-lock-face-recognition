using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public enum CustomMessageBoxButtons
{
    OK,
    YesNo,
    YesNoCancel,
    OKCancel
}

public enum CustomDialogResult
{
    None,
    OK,
    Yes,
    No,
    Cancel
}

namespace automatic_door_lock_face_recognition
{
    public partial class MessagePopup : Form
    {
        public CustomDialogResult Result { get; private set; } = CustomDialogResult.None;
        public MessagePopup(string message, string title, CustomMessageBoxButtons buttons, string type)
        {
            InitializeComponent();

            lblMessage.Text = message;
            lblTitle.Text = title;
            lblMessage.AutoSize = true;
            lblMessage.MaximumSize = new Size(450, 0);

            ConfigureButtons(buttons);
            HeaderColor(type);
            pictureBox1.Visible = false;
            int currentX = lblMessage.Location.X;
            int currentY = lblMessage.Location.Y;
            lblMessage.Location = new Point(currentX, currentY - 20);
            if (title == "Welcome")
            {
                pictureBox1.Visible = true;

                lblMessage.Location = new Point(currentX + 200, currentY - 10);
            }
            if(title == "📄 Retrieved Record" || title == "📄 Return Record")
            {
                lblMessage.Font = new Font(lblMessage.Font.FontFamily, 13);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void HeaderColor(string type)
        {
            switch (type)
            {
                case "Error":
                    panel1.BackColor = Color.Red;
                    lblTitle.ForeColor = Color.White;
                    break;
                case "Warning":
                    panel1.BackColor = Color.FromArgb(255, 140, 0);
                    break;
                case "Info":
                    panel1.BackColor = Color.Beige;
                    break;
                case "Retrieve":
                    panel1.BackColor = Color.FromArgb(186, 224, 202);
                    break;
                case "Return":
                    panel1.BackColor = Color.FromArgb(159, 237, 232);
                    break;
                default:
                    panel1.BackColor = Color.FromArgb(0, 120, 215);
                    break;
            }
        }
        private void ConfigureButtons(CustomMessageBoxButtons buttons)
        {
            btn1.Visible = btn2.Visible = false;

            switch (buttons)
            {
                case CustomMessageBoxButtons.OK:
                    SetupButton(btn2, "OK", CustomDialogResult.OK);
                    break;

                case CustomMessageBoxButtons.YesNo:
                    SetupButton(btn1, "Yes", CustomDialogResult.Yes);
                    SetupButton(btn2, "No", CustomDialogResult.No);
                    break;

                case CustomMessageBoxButtons.YesNoCancel:
                    SetupButton(btn1, "Yes", CustomDialogResult.Yes);
                    SetupButton(btn2, "No", CustomDialogResult.No);
                    break;

                case CustomMessageBoxButtons.OKCancel:
                    SetupButton(btn1, "OK", CustomDialogResult.OK);
                    SetupButton(btn2, "Cancel", CustomDialogResult.Cancel);
                    break;
            }
        }
        private void SetupButton(Button btn, string text, CustomDialogResult result)
        {
            btn.Text = text;
            btn.Visible = true;

            btn.Click += (s, e) =>
            {
                Result = result;
                this.Close();
            };
        }

        private void MessagePopup_Load(object sender, EventArgs e)
        {

        }
    }
}
