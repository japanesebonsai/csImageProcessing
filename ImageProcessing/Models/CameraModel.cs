using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCamLib;

namespace ImageProcessing.Models
{
    public class CameraModel
    {
        public Bitmap CurrentFrame { get; set; } 
        public Bitmap ProcessedFrame { get; set; } 
        public Device CameraDevice { get; set; }
    }
}
