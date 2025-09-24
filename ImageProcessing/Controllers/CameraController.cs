using ImageProcessing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCamLib;

namespace ImageProcessing.Controllers
{
    public class CameraController
    {
        private readonly CameraModel _model;

        public CameraController(CameraModel model)
        {
            _model = model;
        }

        public void TurnOn(Device[] devices, Control displayControl)
        {
            if (devices == null) return;

            _model.CameraDevice = devices[0];
            _model.CameraDevice.ShowWindow(displayControl);
        }

        public void TurnOff()
        {
            _model.CameraDevice?.Stop();
        }

        private int GetGrayValue(Color c) => (c.R + c.G + c.B) / 3;
        public Bitmap Copy()
        {
            return null;
        }

        public Bitmap Greyscale()
        {
            return null;
        }

        public Bitmap Inversion()
        {
            return null;
        }

        public Bitmap Histogram()
        {
            return null;
        }

        public Bitmap Sepia()
        {
            return null;
        }

        public Bitmap Subtract()
        {
            return null;
        }
    }
}
