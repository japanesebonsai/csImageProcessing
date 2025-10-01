using System.Drawing;

namespace ImageProcessing.Services.Utils
{
    public static class ColorUtils
    {
        public static int GetGrayValue(Color c) => (c.R + c.G + c.B) / 3;

        public static Color ToGray(Color c)
        {
            int gray = GetGrayValue(c);
            return Color.FromArgb(gray, gray, gray);
        }

        public static Color Invert(Color c) =>
            Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);

        public static Color ToSepia(Color c)
        {
            int r = (int)((0.393 * c.R) + (0.769 * c.G) + (0.189 * c.B));
            int g = (int)((0.349 * c.R) + (0.686 * c.G) + (0.168 * c.B));
            int b = (int)((0.272 * c.R) + (0.534 * c.G) + (0.131 * c.B));

            return Color.FromArgb(
                Math.Min(255, r),
                Math.Min(255, g),
                Math.Min(255, b));
        }
    }
}
