using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCamLib;

namespace ImageProcessing.Models
{
    public class ImageModel
    {
        public Bitmap ImageA { get; set; }
        public Bitmap ImageB { get; set; }
        public Bitmap ImageC { get; set; }
        public Device CameraDevice { get; set; }
    }
}
