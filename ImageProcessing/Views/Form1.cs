using ImageProcessing.Controllers;
using ImageProcessing.Models;
using ImageProcessing.Services.Utils;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        private SourceModel _model;
        private BasicImageController _basicImageController;
        private ConvMatrixController _convMatrixController;
        private CameraController _cameraController;
        private FileController _fileController;
        private readonly System.Windows.Forms.Timer _timer;

        public Form1()
        {
            InitializeComponent();

            _model = new SourceModel();
            _basicImageController = new BasicImageController(_model);
            _convMatrixController = new ConvMatrixController(_model);
            _cameraController = new CameraController(_model);
            _fileController = new FileController();

            _timer = new System.Windows.Forms.Timer { Interval = 30 };
            _timer.Tick += DisplayCameraFrame;
        }

        // FileController
        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fileController.LoadImage(pictureBox1, _model);
        }

        private void loadBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fileController.LoadBackground(pictureBox2, _model);
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fileController.SaveImage(pictureBox2, _model);
        }

        //CameraController
        private void turnOnCameraButton_Click(object sender, EventArgs e)
        {
            _cameraController.TurnOn();
            _timer.Start();
        }


        private void turnOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            _cameraController.TurnOff();
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = null;
        }
        private void DisplayCameraFrame(object sender, EventArgs e)
        {
            _cameraController.UpdateFrame();
            if (_model.CurrentFrame != null)
            {
                pictureBox1.Image?.Dispose();
                pictureBox1.Image = (Bitmap)_model.CurrentFrame.Clone();
            }
        }

        // BasicImageController
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _basicImageController.Copy();
        }

        private void greyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _basicImageController.Greyscale();
        }

        private void colorInversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _basicImageController.Inversion();
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _basicImageController.Histogram();
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _basicImageController.Sepia();
        }

        private void subtractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = _basicImageController.Subtract();
        }

        // ConvMatrixController
        private void laplascianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _convMatrixController.ApplyFilter(FilterType.LaplascianEmboss);
        }

        private void horzVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _convMatrixController.ApplyFilter(FilterType.HorzVertEmboss);
        }

        private void allDirectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _convMatrixController.ApplyFilter(FilterType.AllDirectionsEmboss);
        }

        private void lossyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _convMatrixController.ApplyFilter(FilterType.LossyEmboss);
        }

        private void horizontalOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _convMatrixController.ApplyFilter(FilterType.HorizontalEmboss);
        }

        private void verticalOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _convMatrixController.ApplyFilter(FilterType.VerticalEmboss);
        }

        private void smoothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _convMatrixController.ApplyFilter(FilterType.Smooth);
        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _convMatrixController.ApplyFilter(FilterType.GaussianBlur);
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _convMatrixController.ApplyFilter(FilterType.Sharpen);
        }

        private void meanRemovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _convMatrixController.ApplyFilter(FilterType.MeanRemoval);
        }
    }
}
