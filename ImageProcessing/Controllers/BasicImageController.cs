using ImageProcessing.Models;
using ImageProcessing.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageProcessing.Controllers
{
    public class BasicImageController
    {
        private readonly SourceModel _model;
        private readonly BasicImageService _service;

        public BasicImageController(SourceModel model)
        {
            _model = model;
            _service = new BasicImageService(_model);
        }

        private bool CheckImages(bool checkB = false)
        {
            if (_model.OriginalImage == null)
            {
                MessageBox.Show("Must load a source to proceed.");
                return false;
            }
            if (checkB && _model.ProcessedImage == null)
            {
                MessageBox.Show("Must load a source to be subtracted.");
                return false;
            }
            return true;
        }

        public Bitmap Copy() => CheckImages() ? _service.Copy() : null;
        public Bitmap Greyscale() => CheckImages() ? _service.Greyscale() : null;
        public Bitmap Inversion() => CheckImages() ? _service.Inversion() : null;
        public Bitmap Histogram() => CheckImages() ? _service.Histogram() : null;
        public Bitmap Sepia() => CheckImages() ? _service.Sepia() : null;
        public Bitmap Subtract() => CheckImages(checkB: true) ? _service.Subtract() : null;
    }
}
