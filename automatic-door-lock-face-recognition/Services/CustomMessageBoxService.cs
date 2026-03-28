using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automatic_door_lock_face_recognition.Services
{
    public static class CustomMessageBoxService
    {
        public static CustomDialogResult Show(
            string message,
            string title = "Message",
            string msgType = "Info",
            CustomMessageBoxButtons buttons = CustomMessageBoxButtons.OK)
        {
            using (var form = new MessagePopup(message, title, buttons, msgType))
            {
                form.StartPosition = FormStartPosition.CenterScreen;
                form.ShowDialog();
                return form.Result;
            }
        }
    }
}
