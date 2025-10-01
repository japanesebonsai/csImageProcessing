using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Drawing;

namespace ImageProcessing.Services
{
    public class CameraService
    {
        private VideoCapture _capture;

        public bool IsRunning => _capture != null && _capture.Ptr != IntPtr.Zero;

        public void StartCamera(int cameraIndex = 0)
        {
            if (!IsRunning)
            {
                _capture = new VideoCapture(cameraIndex);
            }
        }

        public void StopCamera()
        {
            _capture?.Dispose();
            _capture = null;
        }

        public Bitmap GetFrame()
        {
            if (!IsRunning) return null;

            using (var frame = _capture.QueryFrame())
            {
                return frame?.ToBitmap();
            }
        }
    }
}
