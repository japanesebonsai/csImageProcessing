using System;
using System.Drawing;

namespace ImageProcessing.Services.Utils
{
    public static class ImageUtils
    {
        public static Bitmap ApplyPerPixel(Bitmap source, Func<Color, Color> transform)
        {
            Bitmap result = new Bitmap(source.Width, source.Height);

            for (int x = 0; x < source.Width; x++)
                for (int y = 0; y < source.Height; y++)
                    result.SetPixel(x, y, transform(source.GetPixel(x, y)));

            return result;
        }

        public static int[] ComputeHistogram(Bitmap source, Func<Color, int> toGray)
        {
            int[] freq = new int[256];

            for (int i = 0; i < source.Width; i++)
                for (int j = 0; j < source.Height; j++)
                    freq[toGray(source.GetPixel(i, j))]++;

            return freq;
        }

        public static Bitmap Subtract(Bitmap foreground, Bitmap background, Color key, int threshold, Func<Color, int> grayFunc)
        {
            int width = Math.Min(foreground.Width, background.Width);
            int height = Math.Min(foreground.Height, background.Height);

            Bitmap result = new Bitmap(width, height);
            int grayGreen = grayFunc(key);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color fgPixel = foreground.GetPixel(x, y);
                    Color bgPixel = background.GetPixel(x, y);

                    int gray = grayFunc(fgPixel);
                    int subtractValue = Math.Abs(gray - grayGreen);

                    result.SetPixel(x, y, subtractValue < threshold ? bgPixel : fgPixel);
                }
            }

            return result;
        }
    }
}
