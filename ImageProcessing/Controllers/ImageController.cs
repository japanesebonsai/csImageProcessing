using ImageProcessing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ImageProcessing.Controllers
{
    public class ImageController
    {
        private readonly ImageModel _model;

        public ImageController(ImageModel model)
        {
            _model = model;
        }

        private int GetGrayValue(Color c)
        {
            return(c.R + c.G + c.B) / 3;
        }
        public Bitmap Copy()
        {
            if (_model.ImageA == null) return null;

            Bitmap result = new Bitmap(_model.ImageA.Width, _model.ImageA.Height);
            for (int i = 0; i < result.Width; i++)
            {
                for (int j = 0; j < result.Height; j++)
                {
                    result.SetPixel(i, j, _model.ImageA.GetPixel(i, j));
                }
            }
            _model.ImageB = result;
            return result;
        }

        public Bitmap Greyscale()
        {
            if (_model.ImageA == null) return null;

            Bitmap result = new Bitmap(_model.ImageA.Width, _model.ImageA.Height);
            for (int i = 0; i < result.Width; i++)
            {
                for (int j = 0; j < result.Height; j++)
                {
                    Color pixel = _model.ImageA.GetPixel(i, j);
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;
                    result.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }
            _model.ImageB = result;
            return result;
        }

        public Bitmap Inversion()
        {
            if (_model.ImageA == null) return null;
                
                Bitmap result = new Bitmap (_model.ImageA.Width, _model.ImageA.Height);
                for (int i = 0; i < _model.ImageA.Width; i++)
                {
                    for (int j = 0; j < _model.ImageA.Height; j++)
                    {
                        Color pixel = _model.ImageA.GetPixel(i, j);
                        Color inverted = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);

                        result.SetPixel(i, j, inverted);
                    }
                }
                _model.ImageB = result;
                return result;
        }

        public Bitmap Histogram()
        {
            if (_model.ImageA == null) return null;
           
            int[] freq = new int[256];

            for (int i = 0; i < _model.ImageA.Width; i++)
            {
                for (int j = 0; j < _model.ImageA.Height; j++)
                {
                    Color pixel = _model.ImageA.GetPixel(i, j);
                    freq[GetGrayValue(pixel)]++;
                }
            }

            Bitmap result = new Bitmap(256, 200);

            int maxFreq = freq.Max();

            using (Graphics g = Graphics.FromImage(result))
            {
                g.Clear(Color.Transparent);

                for (int x = 0; x < 256; x++)
                {
                    int barHeight = (int)((freq[x] / (float)maxFreq) * result.Height);
                    g.DrawLine(Pens.Gray, x, result.Height, x, result.Height - barHeight);
                }
            }

            _model.ImageB = result;
            return result;
        }

        public Bitmap Sepia()
        {
            if (_model.ImageA == null) return null;
 
            Bitmap result = new Bitmap(_model.ImageA.Width, _model.ImageA.Height);
            for (int i = 0; i < _model.ImageA.Width; i++)
            {
                for (int j = 0; j < _model.ImageA.Height; j++)
                {
                    Color pixel = _model.ImageA.GetPixel(i, j);
                    int r = (int)((0.393 * pixel.R) + (0.769 * pixel.G) + (0.189 * pixel.B));
                    int g = (int)((0.349 * pixel.R) + (0.686 * pixel.G) + (0.168 * pixel.B));
                    int b = (int)((0.272 * pixel.R) + (0.534 * pixel.G) + (0.131 * pixel.B));

                    r = Math.Min(255, Math.Max(0, r));
                    g = Math.Min(255, Math.Max(0, g));
                    b = Math.Min(255, Math.Max(0, b));
                    Color sepia = Color.FromArgb(r, g, b);

                    result.SetPixel(i, j, sepia);
                }
            }
            _model.ImageB = result;
            return result;
        }

        public Bitmap Subtract()
        {
            if (_model.ImageA == null || _model.ImageB == null) return null;

            Color myGreen = Color.FromArgb(0, 255, 0);
            int grayGreen = GetGrayValue(myGreen);
            int threshold = 16;

            int width = Math.Min(_model.ImageA.Width, _model.ImageB.Width);
            int height = Math.Min(_model.ImageA.Height, _model.ImageB.Height);

            Bitmap result = new Bitmap(width, height);

            for (int x = 0; x < width; ++x)
            {
                for (int y = 0; y < height; ++y)
                {
                    Color pixel = _model.ImageA.GetPixel(x, y);
                    Color backpixel = _model.ImageB.GetPixel(x, y);

                    int gray = GetGrayValue(pixel);
                    int subtractValue = Math.Abs(gray - grayGreen);

                    result.SetPixel(x, y, subtractValue < threshold ? backpixel : pixel);
                }
            }

            _model.ImageC = result;
            return result;
        }
    }
}