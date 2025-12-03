using System;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Threading.Tasks;

namespace automatic_door_lock_face_recognition.Services
{
    internal class CameraService : IDisposable
    {
        public static CameraService Instance { get; } = new CameraService();
        private VideoCapture _capture;
        private bool _running;

        public event Action<Mat> OnFrame;

        public void Start(string url)
        {
            Stop();
            _capture = new VideoCapture(url);
            _capture.Set(Emgu.CV.CvEnum.CapProp.Fps, 15);
            //_capture.Set(Emgu.CV.CvEnum.CapProp.FrameWidth, 640);
            _running = true;
            Task.Run(FrameLoop);
        }

        private async Task FrameLoop()
        {
            while (_running)
            {
                try
                {
                    using (Mat frame = _capture.QueryFrame())
                    {
                        if (frame != null && !frame.IsEmpty)
                        {
                            // raise copy to avoid reuse issues
                            Mat copy = frame.Clone();
                            OnFrame?.Invoke(copy);
                            copy.Dispose();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("FrameLoop exception: " + ex.Message);
                }

                await Task.Delay(33); // ~30fps throttle
            }
        }

        public void Stop()
        {
            _running = false;
            if (_capture != null)
            {
                _capture.Dispose();
                _capture = null;
            }
        }

        public void Dispose()
        {
            Stop();
        }
    }
}
