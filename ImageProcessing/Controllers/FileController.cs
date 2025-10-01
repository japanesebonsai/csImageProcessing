using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcessing.Models;

namespace ImageProcessing.Controllers
{
    internal class FileController
    {
        public void LoadImage(PictureBox pictureBox1, SourceModel _model)
        {
            using var dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _model.OriginalImage = new Bitmap(dlg.FileName);
                pictureBox1.Image = _model.OriginalImage;
            }
        }

        //Issue here when saving subtracted images
        public void SaveImage(PictureBox pictureBox2, SourceModel _model)
        {
            using var dlg = new SaveFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            dlg.Title = "Save Image";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (_model.ProcessedImage != null)
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

                    _model.ProcessedImage.Save(dlg.FileName, format);
                }
                else
                {
                    MessageBox.Show("No ImageB available to save.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public void LoadBackground(PictureBox pictureBox2, SourceModel _model)
        {
            using var dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _model.ProcessedImage = new Bitmap(dlg.FileName);
                pictureBox2.Image = _model.ProcessedImage;
            }
        }
    }
}
