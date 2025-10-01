using ImageProcessing.Models;
using ImageProcessing.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageProcessing.Controllers
{
    public class CameraController
    {
        private readonly CameraService _cameraService;
        private readonly SourceModel _model;

        public CameraController(SourceModel model)
        {
            _model = model;
            _cameraService = new CameraService();
        }

        public void TurnOn() => _cameraService.StartCamera();
        public void TurnOff()
        {
            _cameraService.StopCamera();
            _model.CurrentFrame?.Dispose();
            _model.CurrentFrame = null;
        }

        public void UpdateFrame()
        {
            Bitmap frame = _cameraService.GetFrame();
            if (frame != null)
            {
                _model.CurrentFrame?.Dispose();
                _model.CurrentFrame = (Bitmap)frame.Clone();

                _model.OriginalImage?.Dispose();
                _model.OriginalImage = (Bitmap)_model.CurrentFrame.Clone();

                _model.ProcessedImage?.Dispose();
                _model.ProcessedImage = (Bitmap)_model.CurrentFrame.Clone();
            }
        }

        public Bitmap GetCurrentFrame() => _model.CurrentFrame;
    }
}
