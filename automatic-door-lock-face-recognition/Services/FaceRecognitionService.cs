using System;
using System.Collections.Generic;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using System.Drawing;
using System.IO;

namespace automatic_door_lock_face_recognition.Services
{
    public class FaceRecognitionService : IDisposable
    {
        private CascadeClassifier _faceCascade;
        private LBPHFaceRecognizer _recognizer;
        private bool _trained = false;
        public static LBPHFaceRecognizer Recognizer { get; private set; }
        private static readonly string modelPath = "trainedModel.yml";

        public FaceRecognitionService(string haarCascadeFile)
        {
            _faceCascade = new CascadeClassifier(haarCascadeFile);
            _recognizer = new LBPHFaceRecognizer(1, 8, 8, 8, 100);
        }

        public Rectangle[] DetectFaces(Mat frame)
        {
            using (var gray = new Mat())
            {
                CvInvoke.CvtColor(frame, gray, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
                var faces = _faceCascade.DetectMultiScale(gray, 1.1, 4, Size.Empty);
                return faces;
            }
        }

        public Mat ExtractFace(Mat frame, Rectangle faceRect)
        {
            var face = new Mat(frame, faceRect);
            var faceGray = new Mat();
            CvInvoke.CvtColor(face, faceGray, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            CvInvoke.Resize(faceGray, faceGray, new Size(200, 200));
            return faceGray;
        }

        public void TrainFromFiles(List<(string path, int label)> labeledFiles)
        {
            var images = new List<Mat>();
            var labels = new List<int>();
            foreach (var (path, label) in labeledFiles)
            {
                if (!File.Exists(path)) continue;
                var img = CvInvoke.Imread(path, Emgu.CV.CvEnum.ImreadModes.Grayscale);
                if (img == null || img.IsEmpty) continue;
                CvInvoke.Resize(img, img, new Size(200, 200));
                images.Add(img);
                labels.Add(label);
            }
            if (images.Count == 0)
            {
                _trained = false;
                return;
            }
            _recognizer.Train(images.ToArray(), labels.ToArray());
            _trained = true;
        }

        public (int label, double confidence) Predict(Mat faceGray)
        {
            if (!_trained)
                return (-1, double.MaxValue);

            var result = _recognizer.Predict(faceGray);
            return (result.Label, result.Distance);
        }

        // --- NEW METHODS ---
        public void SaveModel(string path)
        {
            if (!_trained) return;
            _recognizer.Write(path);
        }

        public void LoadModel(string path)
        {
            if (!File.Exists(path)) return;
            _recognizer.Read(path);
            _trained = true;
        }

        public void Dispose()
        {
            _faceCascade?.Dispose();
            _recognizer?.Dispose();
        }
     
    }
}
