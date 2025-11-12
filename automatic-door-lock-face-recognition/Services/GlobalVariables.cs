using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automatic_door_lock_face_recognition.Services
{
    public class GlobalVariables
    {
        public static int PersonnelId { get; set; }
        public static string DbConnString { get; set; } = "Host=localhost;Username=postgres;Password=postgres1234;Database=records_system;";

        public static FaceRecognitionService FaceService;
        public static Dictionary<int, string> LabelToName;
        //public static bool IsTrained => FaceService != null && LabelToName != null && LabelToName.Count > 0;
        public static bool IsTrained { get; set; }
        public static string TrainedModelPath { get; set; }
        public static string LabelsPath { get; set; }

    }
}
