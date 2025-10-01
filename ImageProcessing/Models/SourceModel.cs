using System.Drawing;

namespace ImageProcessing.Models
{
    public class SourceModel
    {
        public Bitmap OriginalImage { get; set; }
        public Bitmap ProcessedImage { get; set; }
        public Bitmap SubtractedImage { get; set; }

        public bool IsCameraOn { get; set; }
    }
}
