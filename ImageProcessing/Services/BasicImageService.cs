using ImageProcessing.Models;
using ImageProcessing.Services.Utils;

namespace ImageProcessing.Services
{
    public class BasicImageService
    {
        private readonly SourceModel _model;

        public BasicImageService(SourceModel model)
        {
            _model = model;
        }

        public Bitmap Copy()
        {
            var result = new Bitmap(_model.OriginalImage);
            _model.ProcessedImage = result;
            return result;
        }

        public Bitmap Greyscale()
        {
            var result = ImageUtils.ApplyPerPixel(_model.OriginalImage, ColorUtils.ToGray);
            _model.ProcessedImage = result;
            return result;
        }

        public Bitmap Inversion()
        {
            var result = ImageUtils.ApplyPerPixel(_model.OriginalImage, ColorUtils.Invert);
            _model.ProcessedImage = result;
            return result;
        }

        public Bitmap Sepia()
        {
            var result = ImageUtils.ApplyPerPixel(_model.OriginalImage, ColorUtils.ToSepia);
            _model.ProcessedImage = result;
            return result;
        }

        public Bitmap Histogram()
        {
            int[] freq = ImageUtils.ComputeHistogram(_model.OriginalImage, ColorUtils.GetGrayValue);
            int maxFreq = freq.Max();

            Bitmap result = new Bitmap(256, 200);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.Clear(Color.Transparent);
                for (int x = 0; x < 256; x++)
                {
                    int barHeight = (int)((freq[x] / (float)maxFreq) * result.Height);
                    g.DrawLine(Pens.Gray, x, result.Height, x, result.Height - barHeight);
                }
            }

            _model.ProcessedImage = result;
            return result;
        }

        public Bitmap Subtract()
        {
            Color green = Color.FromArgb(0, 255, 0);
            int threshold = 16;

            var result = ImageUtils.Subtract(_model.OriginalImage, _model.ProcessedImage, green, threshold, ColorUtils.GetGrayValue);

            _model.SubtractedImage = result;
            return result;
        }

    }
}
