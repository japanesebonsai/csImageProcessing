using ImageProcessing.Models;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageProcessing.Controllers
{
    public class CameraController : IDisposable
    {
        private readonly ImageModel _model;
        private VideoCapture? _capture;
        private PictureBox? _displayBox;
        private Mat? _frame;
        private System.Windows.Forms.Timer? _timer;

        public CameraController(ImageModel model)
        {
            _model = model;
        }

        public void TurnOn(Control displayControl)
        {
            _displayBox = displayControl as PictureBox
                          ?? throw new ArgumentException("Display control must be a PictureBox");

            _capture = new VideoCapture(0);
            if (!_capture.IsOpened())
            {
                MessageBox.Show("Unable to access camera.");
                return;
            }

            _frame = new Mat();

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 33; 
            _timer.Tick += (s, e) => ProcessFrame();
            _timer.Start();
        }

        public void TurnOff()
        {
            _timer?.Stop();
            _timer?.Dispose();
            _timer = null;

            _capture?.Release();
            _capture?.Dispose();
            _capture = null;

            _frame?.Dispose();
            _frame = null;

            if (_displayBox != null)
            {
                _displayBox.Image?.Dispose();
                _displayBox.Image = null;
            }
        }

        private void ProcessFrame()
        {
            if (_capture == null || !_capture.IsOpened() || _frame == null)
                return;

            _capture.Read(_frame);
            if (!_frame.Empty())
            {
                _displayBox!.Image?.Dispose();
                _model.ImageA = BitmapConverter.ToBitmap(_frame);
                _displayBox.Image = _model.ImageA;
            }
        }

        public Bitmap? CaptureFrame()
        {
            if (_frame != null && !_frame.Empty())
            {
                return BitmapConverter.ToBitmap(_frame.Clone());
            }
            return null;
        }

        public void Dispose()
        {
            TurnOff();
        }
    }
}
