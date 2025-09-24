using ImageProcessing.Controllers;
using ImageProcessing.Models;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using WebCamLib;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        private ImageModel _model;
        private ImageController _controller;
        private CameraModel _cameraModel;
        private CameraController _cameraController;
        private Device[] devices;

        public Form1()
        {
            InitializeComponent();

            _model = new ImageModel();
            _controller = new ImageController(_model);
            _cameraModel = new CameraModel();
            _cameraController = new CameraController(_cameraModel);
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
            devices = DeviceManager.GetAllDevices();
            _cameraController.TurnOn(devices, pictureBox1);
        }

        private void turnOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _cameraController.TurnOff();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _controller.Copy();
        }

        private void buttonGreyscale_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _controller.Greyscale();
        }

        private void buttonColorInversion_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _controller.Inversion();
        }

        private void buttonSepia_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _controller.Sepia();
        }

        private void buttonHistogram_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _controller.Histogram();
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = _controller.Subtract();
        }

        private void buttonCameraCopy_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _cameraController.Copy();
        }
        private void buttonCameraGreyscale_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _cameraController.Greyscale();
        }
        private void buttonCameraInversion_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _cameraController.Inversion();
        }
        private void buttonCameraSepia_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _cameraController.Sepia();
        }
        private void buttonCameraHistogram_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _cameraController.Histogram();
        }
        private void buttonCameraSubtract_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = _cameraController.Subtract();
        }
    }
}
