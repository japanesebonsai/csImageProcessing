using ImageProcessing.Controllers;
using ImageProcessing.Models;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        private ImageModel _model;
        private ImageController _controller;
        private CameraController _cameraController;

        public Form1()
        {
            InitializeComponent();

            _model = new ImageModel();
            _controller = new ImageController(_model);
            _cameraController = new CameraController(_model);
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _model.ImageA = new Bitmap(dlg.FileName);
                pictureBox1.Image = _model.ImageA;
            }
        }

        private void loadBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _model.ImageB = new Bitmap(dlg.FileName);
                pictureBox2.Image = _model.ImageB;
            }
        }

        private void turnOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _cameraController.TurnOn(pictureBox1);
        }

        private void turnOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _cameraController.TurnOff();
        }

        //ImageController
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _controller.Copy();
        }

        private void greyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _controller.Greyscale();
        }

        private void colorInversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _controller.Inversion();
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _controller.Histogram();
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _controller.Sepia();
        }

        private void subtractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = _controller.Subtract();
        }

        private void laplascianToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void horzVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void allDirectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lossyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void horizontalOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verticalOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void smoothToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void meanRemovalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void embossingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var dlg = new SaveFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            dlg.Title = "Save Image";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (_model.ImageB != null)
                {
                    var ext = Path.GetExtension(dlg.FileName).ToLower();
                    var format = System.Drawing.Imaging.ImageFormat.Png;

                    switch (ext)
                    {
                        case ".jpg":
                        case ".jpeg":
                            format = System.Drawing.Imaging.ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = System.Drawing.Imaging.ImageFormat.Bmp;
                            break;
                        case ".gif":
                            format = System.Drawing.Imaging.ImageFormat.Gif;
                            break;
                    }

                    // Save ImageB
                    _model.ImageB.Save(dlg.FileName, format);
                }
                else
                {
                    MessageBox.Show("No ImageB available to save.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
