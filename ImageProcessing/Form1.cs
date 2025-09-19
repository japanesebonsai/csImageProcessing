using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        Bitmap imageA, imageB, colorgreen;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (imageA != null)
            {
                imageB = new Bitmap(imageA.Width, imageA.Height);
                for (int i = 0; i < imageA.Width; i++)
                {
                    for (int j = 0; j < imageA.Height; j++)
                    {
                        Color c = imageA.GetPixel(i, j);
                        imageB.SetPixel(i, j, c); ;
                    }
                }
                pictureBox2.Image = imageB;
            }
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Open Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageA = new Bitmap(openFileDialog.FileName);
                    pictureBox1.Image = imageA;
                }
            }
        }

        private void buttonGreyscale_Click(object sender, EventArgs e)
        {
            if (imageA != null)
            {
                imageB = new Bitmap(imageA.Width, imageA.Height);
                for (int i = 0; i < imageA.Width; i++)
                {
                    for (int j = 0; j < imageA.Height; j++)
                    {
                        Color pixel = imageA.GetPixel(i, j);
                        int gray = (pixel.R + pixel.G + pixel.B) / 3;
                        Color greyscaled = Color.FromArgb(gray, gray, gray);

                        imageB.SetPixel(i, j, greyscaled);
                    }
                }
                pictureBox2.Image = imageB;
            }
        }

        private void buttonColorInversion_Click(object sender, EventArgs e)
        {
            if (imageA != null)
            {
                imageB = new Bitmap(imageA.Width, imageA.Height);
                for (int i = 0; i < imageA.Width; i++)
                {
                    for (int j = 0; j < imageA.Height; j++)
                    {
                        Color pixel = imageA.GetPixel(i, j);
                        Color inverted = Color.FromArgb(255-pixel.R, 255-pixel.G, 255-pixel.B);

                        imageB.SetPixel(i, j, inverted);
                    }
                }
                pictureBox2.Image = imageB;
            }
        }

        private void buttonHistogram_Click(object sender, EventArgs e)
        {
            if (imageA != null)
            {
                imageB = new Bitmap(imageA.Width, imageA.Height);
                int[] freq = new int[256];

                for (int i = 0; i < imageA.Width; i++)
                {
                    for (int j = 0; j < imageA.Height; j++)
                    {
                        Color pixel = imageA.GetPixel(i, j);
                        int gray = (pixel.R + pixel.G + pixel.B) / 3;
                        freq[gray]++;
                    }
                }

                Bitmap histogram = new Bitmap(256, 200);

                int maxFreq = freq.Max();

                using (Graphics g = Graphics.FromImage(histogram))
                {
                    g.Clear(Color.Transparent);

                    for (int x = 0; x < 256; x++)
                    {
                        int barHeight = (int)((freq[x] / (float)maxFreq) * histogram.Height);
                        g.DrawLine(Pens.Gray, x, histogram.Height, x, histogram.Height - barHeight);
                    }
                }

                pictureBox2.Image = histogram;

            }

        }

        private void buttonSepia_Click(object sender, EventArgs e)
        {
            if (imageA != null)
            {
                imageB = new Bitmap(imageA.Width, imageA.Height);
                for (int i = 0; i < imageA.Width; i++)
                {
                    for (int j = 0; j < imageA.Height; j++)
                    {
                        Color pixel = imageA.GetPixel(i, j);
                        int r = (int)((0.393 * pixel.R) + (0.769 * pixel.G) + (0.189 * pixel.B));
                        int g = (int)((0.349 * pixel.R) + (0.686 * pixel.G) + (0.168 * pixel.B));
                        int b = (int)((0.272 * pixel.R) + (0.534 * pixel.G) + (0.131 * pixel.B));

                        r = Math.Min(255, Math.Max(0, r));
                        g = Math.Min(255, Math.Max(0, g));
                        b = Math.Min(255, Math.Max(0, b));
                        Color sepia = Color.FromArgb(r, g, b);

                        imageB.SetPixel(i, j, sepia);
                    }
                }
                pictureBox2.Image = imageB;
            }
        }
    }
}
