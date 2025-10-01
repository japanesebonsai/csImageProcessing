using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ImageProcessing.Models;

namespace ImageProcessing.Controllers
{
    public class FileController
    {
        public void LoadImage(PictureBox pictureBox, SourceModel model)
        {
            using var dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                model.OriginalImage?.Dispose();
                model.OriginalImage = new Bitmap(dlg.FileName);
                pictureBox.Image = (Bitmap)model.OriginalImage.Clone();
            }
        }

        public void LoadBackground(PictureBox pictureBox, SourceModel model)
        {
            using var dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                model.ProcessedImage?.Dispose();
                model.ProcessedImage = new Bitmap(dlg.FileName);
                pictureBox.Image = (Bitmap)model.ProcessedImage.Clone();
            }
        }

        public void SaveImage(PictureBox pictureBox, SourceModel model)
        {
            if (model.ProcessedImage == null)
            {
                MessageBox.Show("No processed image available to save.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var dlg = new SaveFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            dlg.Title = "Save Image";

            if (dlg.ShowDialog() == DialogResult.OK)
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

                model.ProcessedImage.Save(dlg.FileName, format);
            }
        }
    }
}
