using automatic_door_lock_face_recognition.Services;
using System.IO.Ports;

namespace automatic_door_lock_face_recognition
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]     
        static void Main()
        {

            //CameraService.Instance.Start(GlobalVariables.CameralUrl);
           
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new DocumentDialog(GlobalVariables.port));
        }
    }
}