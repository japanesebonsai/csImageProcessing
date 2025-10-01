using ImageProcessing.Models;
using ImageProcessing.Services.Utils;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing.Services
{
    public class ConvMatrixService
    {
        private readonly SourceModel _model;

        public ConvMatrixService(SourceModel model)
        {
            _model = model;
        }
        public Bitmap ApplyFilter(FilterType type)
        {
            if (_model.OriginalImage == null)
                return null;

            Bitmap bmp = (Bitmap)_model.OriginalImage.Clone();

            switch (type)
            {
                case FilterType.Smooth:
                    Smooth(bmp);
                    break;
                case FilterType.GaussianBlur:
                    GaussianBlur(bmp);
                    break;
                case FilterType.Sharpen:
                    Sharpen(bmp);
                    break;
                case FilterType.MeanRemoval:
                    MeanRemoval(bmp);
                    break;
                case FilterType.LaplascianEmboss:
                    LaplascianEmboss(bmp);
                    break;
                case FilterType.HorzVertEmboss:
                    HorzVertEmboss(bmp);
                    break;
                case FilterType.AllDirectionsEmboss:
                    AllDirectionsEmboss(bmp);
                    break;
                case FilterType.LossyEmboss:
                    LossyEmboss(bmp);
                    break;
                case FilterType.HorizontalEmboss:
                    HorizontalEmboss(bmp);
                    break;
                case FilterType.VerticalEmboss:
                    VerticalEmboss(bmp);
                    break;
                default:
                    break;
            }

            _model.ProcessedImage = bmp;
            return bmp;
        }

        public static bool Conv3x3(Bitmap b, ConvMatrixModel m)
        {
            // Avoid divide by zero errors 
            if (0 == m.Factor)
                return false; Bitmap

            // GDI+ still lies to us - the return format is BGR, NOT RGB.  
            bSrc = (Bitmap)b.Clone();

            BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmSrc = bSrc.LockBits(new Rectangle(0, 0, bSrc.Width, bSrc.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = bmData.Stride;
            int stride2 = stride * 2;

            System.IntPtr Scan0 = bmData.Scan0;
            System.IntPtr SrcScan0 = bmSrc.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                byte* pSrc = (byte*)(void*)SrcScan0;
                int nOffset = stride - b.Width * 3;
                int nWidth = b.Width - 2;
                int nHeight = b.Height - 2;

                int nPixel;
                for (int y = 0; y < nHeight; ++y)
                {
                    for (int x = 0; x < nWidth; ++x)
                    {
                        nPixel = ((((pSrc[2] * m.TopLeft) +
                            (pSrc[5] * m.TopMid) +
                            (pSrc[8] * m.TopRight) +
                            (pSrc[2 + stride] * m.MidLeft) +
                            (pSrc[5 + stride] * m.Pixel) +
                            (pSrc[8 + stride] * m.MidRight) +
                            (pSrc[2 + stride2] * m.BottomLeft) +
                            (pSrc[5 + stride2] * m.BottomMid) +
                            (pSrc[8 + stride2] * m.BottomRight))
                            / m.Factor) + m.Offset);

                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;
                        p[5 + stride] = (byte)nPixel;

                        nPixel = ((((pSrc[1] * m.TopLeft) +
                            (pSrc[4] * m.TopMid) +
                            (pSrc[7] * m.TopRight) +
                            (pSrc[1 + stride] * m.MidLeft) +
                            (pSrc[4 + stride] * m.Pixel) +
                            (pSrc[7 + stride] * m.MidRight) +
                            (pSrc[1 + stride2] * m.BottomLeft) +
                            (pSrc[4 + stride2] * m.BottomMid) +
                            (pSrc[7 + stride2] * m.BottomRight))
                            / m.Factor) + m.Offset);

                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;
                        p[4 + stride] = (byte)nPixel;

                        nPixel = ((((pSrc[0] * m.TopLeft) +
                                       (pSrc[3] * m.TopMid) +
                                       (pSrc[6] * m.TopRight) +
                                       (pSrc[0 + stride] * m.MidLeft) +
                                       (pSrc[3 + stride] * m.Pixel) +
                                       (pSrc[6 + stride] * m.MidRight) +
                                       (pSrc[0 + stride2] * m.BottomLeft) +
                                       (pSrc[3 + stride2] * m.BottomMid) +
                                       (pSrc[6 + stride2] * m.BottomRight))
                            / m.Factor) + m.Offset);



                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;
                        p[3 + stride] = (byte)nPixel;

                        p += 3;
                        pSrc += 3;
                    }
                    p += nOffset;
                    pSrc += nOffset;
                }
            }
            b.UnlockBits(bmData);
            bSrc.UnlockBits(bmSrc);

            return true;
        }


        public static bool Smooth(Bitmap b, int nWeight = 1)
        {
            ConvMatrixModel m = new ConvMatrixModel();
            m.SetAll(1);
            m.Pixel = nWeight;
            m.Factor = nWeight + 8;
            return Conv3x3(b, m);
        }

        public static bool GaussianBlur(Bitmap b, int nWeight = 4)
        {
            ConvMatrixModel m = new ConvMatrixModel();
            m.SetAll(1);
            m.Pixel = nWeight;
            m.TopMid = m.MidLeft = m.MidRight = m.BottomMid = 2;
            m.Factor = nWeight + 12;

            return Conv3x3(b, m);
        }

        public static bool Sharpen(Bitmap b, int nWeight = 11)
        {
            ConvMatrixModel m = new ConvMatrixModel();
            m.SetAll(0);
            m.Pixel = nWeight;
            m.TopMid = m.MidLeft = m.MidRight = m.BottomMid = -2;
            m.Factor = nWeight - 8;
            return Conv3x3(b, m);
        }

        public static bool MeanRemoval(Bitmap b, int nWeight = 9)
        {
            ConvMatrixModel m = new ConvMatrixModel();
            m.SetAll(-1);
            m.Pixel = nWeight;
            m.Factor = nWeight - 8;
            return Conv3x3(b, m);
        }

        public static bool LaplascianEmboss(Bitmap b, int nWeight = 4)
        {
            ConvMatrixModel m = new ConvMatrixModel();
            m.SetAll(0);
            m.TopLeft = m.TopRight = m.BottomLeft = m.BottomRight = -1;
            m.BottomRight = -1;
            m.Pixel = nWeight;
            m.Factor = nWeight - 4;
            m.Offset = 128;
            return Conv3x3(b, m);
        }

        public static bool HorzVertEmboss(Bitmap b, int nWeight = 4)
        {
            ConvMatrixModel m = new ConvMatrixModel();
            m.SetAll(0);
            m.TopMid = m.MidLeft = m.MidRight = m.BottomMid = -1;
            m.Pixel = nWeight;
            m.Factor = nWeight - 4;
            m.Offset = 128;
            return Conv3x3(b, m);
        }

        public static bool AllDirectionsEmboss(Bitmap b, int nWeight = 8)
        {
            ConvMatrixModel m = new ConvMatrixModel();
            m.SetAll(-1);
            m.Pixel = nWeight;
            m.Factor = nWeight - 8;
            m.Offset = 128;
            return Conv3x3(b, m);
        }

        public static bool LossyEmboss(Bitmap b, int nWeight = 4)
        {
            ConvMatrixModel m = new ConvMatrixModel();
            m.SetAll(-2);
            m.TopLeft = m.TopRight = m.BottomMid = 1;
            m.Pixel = nWeight;
            m.Factor = nWeight - 7;
            m.Offset = 128;
            return Conv3x3(b, m);
        }

        public static bool HorizontalEmboss(Bitmap b, int nWeight = 2)
        {
            ConvMatrixModel m = new ConvMatrixModel();
            m.SetAll(0);
            m.MidLeft = m.MidRight = -1;
            m.Pixel = nWeight;
            m.Factor = nWeight - 2;
            m.Offset = 128;
            return Conv3x3(b, m);
        }

        public static bool VerticalEmboss(Bitmap b, int nWeight = 0)
        {
            ConvMatrixModel m = new ConvMatrixModel();
            m.SetAll(0);
            m.TopMid = -1;
            m.BottomMid = 1;
            m.Pixel = nWeight;
            m.Factor = nWeight;
            m.Offset = 128;
            return Conv3x3(b, m);
        }
    }
}
