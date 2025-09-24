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
        private readonly ImageModel _model;

        public CameraController(ImageModel model)
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

        public Bitmap CaptureFrame()
        {
            if (_model.CameraDevice == null) return null;

            _model.CameraDevice.Sendmessage();

            if (Clipboard.ContainsImage())
            {
                Image snap = Clipboard.GetImage();
                if (snap != null)
                {
                    Bitmap frame = new Bitmap(snap);
                    _model.ImageA = frame;
                    return frame;
                }
            }

            return null;
        }

        private int GetGrayValue(Color c) => (c.R + c.G + c.B) / 3;
        private bool CheckFrame(bool CheckB = false)
        {
            if (_model.CameraDevice == null || _model.ImageA == null)
            {
                MessageBox.Show("Camera must be turned on or supported by the driver.");
                return false;
            }

            if (CheckB && _model.ImageB == null)
            {
                MessageBox.Show("Must load an image to be subtracted.");
                return false;
            }

            return true;
        }
        public Bitmap Copy()
        {
            if (!CheckFrame()) return null;

            Bitmap result = new Bitmap(_model.ImageA.Width, _model.ImageA.Height);
            for (int x = 0; x < _model.ImageA.Width; x++)
            {
                for (int y = 0; y < _model.ImageA.Height; y++)
                {
                    result.SetPixel(x, y, _model.ImageA.GetPixel(x, y));
                }
            }
            _model.ImageB = result;
            return result;
        }

        public Bitmap Greyscale()
        {
            if (!CheckFrame()) return null;

            Bitmap result = new Bitmap(_model.ImageA.Width, _model.ImageA.Height);
            for (int x = 0; x < _model.ImageA.Width; x++)
            {
                for (int y = 0; y < _model.ImageA.Height; y++)
                {
                    Color pixel = _model.ImageA.GetPixel(x, y);
                    int gray = GetGrayValue(pixel);
                    result.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }
            _model.ImageB = result;
            return result;
        }

        public Bitmap Inversion()
        {
            if (!CheckFrame()) return null;

            Bitmap result = new Bitmap(_model.ImageA.Width, _model.ImageA.Height);
            for (int x = 0; x < _model.ImageA.Width; x++)
            {
                for (int y = 0; y < _model.ImageA.Height; y++)
                {
                    Color pixel = _model.ImageA.GetPixel(x, y);
                    Color inverted = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    result.SetPixel(x, y, inverted);
                }
            }
            _model.ImageB = result;
            return result;
        }

        public Bitmap Histogram()
        {
            if (!CheckFrame()) return null;

            int[] freq = new int[256];

            for (int x = 0; x < _model.ImageA.Width; x++)
            {
                for (int y = 0; y < _model.ImageA.Height; y++)
                {
                    Color pixel = _model.ImageA.GetPixel(x, y);
                    freq[GetGrayValue(pixel)]++;
                }
            }

            Bitmap result = new Bitmap(_model.ImageA.Width, _model.ImageA.Height);
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
            if (!CheckFrame()) return null;

            Bitmap result = new Bitmap(_model.ImageA.Width, _model.ImageA.Height);
            for (int x = 0; x < _model.ImageA.Width; x++)
            {
                for (int y = 0; y < _model.ImageA.Height; y++)
                {
                    Color pixel = _model.ImageA.GetPixel(x, y);
                    int r = (int)((0.393 * pixel.R) + (0.769 * pixel.G) + (0.189 * pixel.B));
                    int g = (int)((0.349 * pixel.R) + (0.686 * pixel.G) + (0.168 * pixel.B));
                    int b = (int)((0.272 * pixel.R) + (0.534 * pixel.G) + (0.131 * pixel.B));

                    r = Math.Min(255, Math.Max(0, r));
                    g = Math.Min(255, Math.Max(0, g));
                    b = Math.Min(255, Math.Max(0, b));
                    Color sepia = Color.FromArgb(r, g, b);

                    result.SetPixel(x, y, sepia);
                }
            }
            _model.ImageB = result;
            return result;
        }

        public Bitmap Subtract()
        {
            if (!CheckFrame(CheckB: true)) return null;

            Color myGreen = Color.FromArgb(0, 255, 0);
            int grayGreen = GetGrayValue(myGreen);
            int threshold = 16;

            int width = Math.Min(_model.ImageA.Width, _model.ImageB.Width);
            int height = Math.Min(_model.ImageA.Height, _model.ImageB.Height);

            Bitmap result = new Bitmap(width, height);
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
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
