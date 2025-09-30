namespace ImageProcessing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            loadImageToolStripMenuItem = new ToolStripMenuItem();
            loadBackgroundToolStripMenuItem = new ToolStripMenuItem();
            saveImageToolStripMenuItem = new ToolStripMenuItem();
            imageProcessingToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            greyscaleToolStripMenuItem = new ToolStripMenuItem();
            colorInversionToolStripMenuItem = new ToolStripMenuItem();
            histogramToolStripMenuItem = new ToolStripMenuItem();
            sepiaToolStripMenuItem = new ToolStripMenuItem();
            subtractToolStripMenuItem = new ToolStripMenuItem();
            filterToolStripMenuItem = new ToolStripMenuItem();
            smoothToolStripMenuItem = new ToolStripMenuItem();
            gaussianBlurToolStripMenuItem = new ToolStripMenuItem();
            sharpenToolStripMenuItem = new ToolStripMenuItem();
            meanRemovalToolStripMenuItem = new ToolStripMenuItem();
            embossingToolStripMenuItem = new ToolStripMenuItem();
            laplascianToolStripMenuItem = new ToolStripMenuItem();
            horzVerticalToolStripMenuItem = new ToolStripMenuItem();
            allDirectionsToolStripMenuItem = new ToolStripMenuItem();
            lossyToolStripMenuItem = new ToolStripMenuItem();
            horizontalOnlyToolStripMenuItem = new ToolStripMenuItem();
            verticalOnlyToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            cameraToolStripMenuItem = new ToolStripMenuItem();
            turnOnToolStripMenuItem = new ToolStripMenuItem();
            turnOffToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, imageProcessingToolStripMenuItem, filterToolStripMenuItem, cameraToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1264, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { loadImageToolStripMenuItem, loadBackgroundToolStripMenuItem, saveImageToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(37, 20);
            toolStripMenuItem1.Text = "File";
            // 
            // loadImageToolStripMenuItem
            // 
            loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            loadImageToolStripMenuItem.Size = new Size(180, 22);
            loadImageToolStripMenuItem.Text = "Load Image";
            loadImageToolStripMenuItem.Click += loadImageToolStripMenuItem_Click;
            // 
            // loadBackgroundToolStripMenuItem
            // 
            loadBackgroundToolStripMenuItem.Name = "loadBackgroundToolStripMenuItem";
            loadBackgroundToolStripMenuItem.Size = new Size(180, 22);
            loadBackgroundToolStripMenuItem.Text = "Load Background";
            loadBackgroundToolStripMenuItem.Click += loadBackgroundToolStripMenuItem_Click;
            // 
            // saveImageToolStripMenuItem
            // 
            saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            saveImageToolStripMenuItem.Size = new Size(180, 22);
            saveImageToolStripMenuItem.Text = "Save Image";
            saveImageToolStripMenuItem.Click += saveImageToolStripMenuItem_Click;
            // 
            // imageProcessingToolStripMenuItem
            // 
            imageProcessingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyToolStripMenuItem, greyscaleToolStripMenuItem, colorInversionToolStripMenuItem, histogramToolStripMenuItem, sepiaToolStripMenuItem, subtractToolStripMenuItem });
            imageProcessingToolStripMenuItem.Name = "imageProcessingToolStripMenuItem";
            imageProcessingToolStripMenuItem.Size = new Size(112, 20);
            imageProcessingToolStripMenuItem.Text = "Image Processing";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(154, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // greyscaleToolStripMenuItem
            // 
            greyscaleToolStripMenuItem.Name = "greyscaleToolStripMenuItem";
            greyscaleToolStripMenuItem.Size = new Size(154, 22);
            greyscaleToolStripMenuItem.Text = "Greyscale";
            greyscaleToolStripMenuItem.Click += greyscaleToolStripMenuItem_Click;
            // 
            // colorInversionToolStripMenuItem
            // 
            colorInversionToolStripMenuItem.Name = "colorInversionToolStripMenuItem";
            colorInversionToolStripMenuItem.Size = new Size(154, 22);
            colorInversionToolStripMenuItem.Text = "Color Inversion";
            colorInversionToolStripMenuItem.Click += colorInversionToolStripMenuItem_Click;
            // 
            // histogramToolStripMenuItem
            // 
            histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            histogramToolStripMenuItem.Size = new Size(154, 22);
            histogramToolStripMenuItem.Text = "Histogram";
            histogramToolStripMenuItem.Click += histogramToolStripMenuItem_Click;
            // 
            // sepiaToolStripMenuItem
            // 
            sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            sepiaToolStripMenuItem.Size = new Size(154, 22);
            sepiaToolStripMenuItem.Text = "Sepia";
            sepiaToolStripMenuItem.Click += sepiaToolStripMenuItem_Click;
            // 
            // subtractToolStripMenuItem
            // 
            subtractToolStripMenuItem.Name = "subtractToolStripMenuItem";
            subtractToolStripMenuItem.Size = new Size(154, 22);
            subtractToolStripMenuItem.Text = "Subtract";
            subtractToolStripMenuItem.Click += subtractToolStripMenuItem_Click;
            // 
            // filterToolStripMenuItem
            // 
            filterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { smoothToolStripMenuItem, gaussianBlurToolStripMenuItem, sharpenToolStripMenuItem, meanRemovalToolStripMenuItem, embossingToolStripMenuItem });
            filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            filterToolStripMenuItem.Size = new Size(45, 20);
            filterToolStripMenuItem.Text = "Filter";
            // 
            // smoothToolStripMenuItem
            // 
            smoothToolStripMenuItem.Name = "smoothToolStripMenuItem";
            smoothToolStripMenuItem.Size = new Size(153, 22);
            smoothToolStripMenuItem.Text = "Smooth";
            smoothToolStripMenuItem.Click += smoothToolStripMenuItem_Click;
            // 
            // gaussianBlurToolStripMenuItem
            // 
            gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            gaussianBlurToolStripMenuItem.Size = new Size(153, 22);
            gaussianBlurToolStripMenuItem.Text = "Gaussian Blur";
            gaussianBlurToolStripMenuItem.Click += gaussianBlurToolStripMenuItem_Click;
            // 
            // sharpenToolStripMenuItem
            // 
            sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            sharpenToolStripMenuItem.Size = new Size(153, 22);
            sharpenToolStripMenuItem.Text = "Sharpen";
            sharpenToolStripMenuItem.Click += sharpenToolStripMenuItem_Click;
            // 
            // meanRemovalToolStripMenuItem
            // 
            meanRemovalToolStripMenuItem.Name = "meanRemovalToolStripMenuItem";
            meanRemovalToolStripMenuItem.Size = new Size(153, 22);
            meanRemovalToolStripMenuItem.Text = "Mean Removal";
            meanRemovalToolStripMenuItem.Click += meanRemovalToolStripMenuItem_Click;
            // 
            // embossingToolStripMenuItem
            // 
            embossingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { laplascianToolStripMenuItem, horzVerticalToolStripMenuItem, allDirectionsToolStripMenuItem, lossyToolStripMenuItem, horizontalOnlyToolStripMenuItem, verticalOnlyToolStripMenuItem });
            embossingToolStripMenuItem.Name = "embossingToolStripMenuItem";
            embossingToolStripMenuItem.Size = new Size(153, 22);
            embossingToolStripMenuItem.Text = "Emboss";
            embossingToolStripMenuItem.Click += embossingToolStripMenuItem_Click;
            // 
            // laplascianToolStripMenuItem
            // 
            laplascianToolStripMenuItem.Name = "laplascianToolStripMenuItem";
            laplascianToolStripMenuItem.Size = new Size(157, 22);
            laplascianToolStripMenuItem.Text = "Laplascian";
            laplascianToolStripMenuItem.Click += laplascianToolStripMenuItem_Click;
            // 
            // horzVerticalToolStripMenuItem
            // 
            horzVerticalToolStripMenuItem.Name = "horzVerticalToolStripMenuItem";
            horzVerticalToolStripMenuItem.Size = new Size(157, 22);
            horzVerticalToolStripMenuItem.Text = "Horz/Vertical";
            horzVerticalToolStripMenuItem.Click += horzVerticalToolStripMenuItem_Click;
            // 
            // allDirectionsToolStripMenuItem
            // 
            allDirectionsToolStripMenuItem.Name = "allDirectionsToolStripMenuItem";
            allDirectionsToolStripMenuItem.Size = new Size(157, 22);
            allDirectionsToolStripMenuItem.Text = "All Directions";
            allDirectionsToolStripMenuItem.Click += allDirectionsToolStripMenuItem_Click;
            // 
            // lossyToolStripMenuItem
            // 
            lossyToolStripMenuItem.Name = "lossyToolStripMenuItem";
            lossyToolStripMenuItem.Size = new Size(157, 22);
            lossyToolStripMenuItem.Text = "Lossy";
            lossyToolStripMenuItem.Click += lossyToolStripMenuItem_Click;
            // 
            // horizontalOnlyToolStripMenuItem
            // 
            horizontalOnlyToolStripMenuItem.Name = "horizontalOnlyToolStripMenuItem";
            horizontalOnlyToolStripMenuItem.Size = new Size(157, 22);
            horizontalOnlyToolStripMenuItem.Text = "Horizontal Only";
            horizontalOnlyToolStripMenuItem.Click += horizontalOnlyToolStripMenuItem_Click;
            // 
            // verticalOnlyToolStripMenuItem
            // 
            verticalOnlyToolStripMenuItem.Name = "verticalOnlyToolStripMenuItem";
            verticalOnlyToolStripMenuItem.Size = new Size(157, 22);
            verticalOnlyToolStripMenuItem.Text = "Vertical Only";
            verticalOnlyToolStripMenuItem.Click += verticalOnlyToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(8, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 232);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(427, 134);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(413, 232);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(846, 134);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(413, 232);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // cameraToolStripMenuItem
            // 
            cameraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { turnOnToolStripMenuItem, turnOffToolStripMenuItem });
            cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            cameraToolStripMenuItem.Size = new Size(60, 20);
            cameraToolStripMenuItem.Text = "Camera";
            // 
            // turnOnToolStripMenuItem
            // 
            turnOnToolStripMenuItem.Name = "turnOnToolStripMenuItem";
            turnOnToolStripMenuItem.Size = new Size(180, 22);
            turnOnToolStripMenuItem.Text = "Turn On";
            turnOnToolStripMenuItem.Click += turnOnToolStripMenuItem_Click;
            // 
            // turnOffToolStripMenuItem
            // 
            turnOffToolStripMenuItem.Name = "turnOffToolStripMenuItem";
            turnOffToolStripMenuItem.Size = new Size(180, 22);
            turnOffToolStripMenuItem.Text = "Turn Off";
            turnOnToolStripMenuItem.Click += turnOffToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem loadImageToolStripMenuItem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ToolStripMenuItem loadBackgroundToolStripMenuItem;
        private PictureBox pictureBox3;
        private ToolStripMenuItem imageProcessingToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem greyscaleToolStripMenuItem;
        private ToolStripMenuItem colorInversionToolStripMenuItem;
        private ToolStripMenuItem histogramToolStripMenuItem;
        private ToolStripMenuItem sepiaToolStripMenuItem;
        private ToolStripMenuItem subtractToolStripMenuItem;
        private ToolStripMenuItem filterToolStripMenuItem;
        private ToolStripMenuItem smoothToolStripMenuItem;
        private ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private ToolStripMenuItem sharpenToolStripMenuItem;
        private ToolStripMenuItem meanRemovalToolStripMenuItem;
        private ToolStripMenuItem embossingToolStripMenuItem;
        private ToolStripMenuItem laplascianToolStripMenuItem;
        private ToolStripMenuItem horzVerticalToolStripMenuItem;
        private ToolStripMenuItem allDirectionsToolStripMenuItem;
        private ToolStripMenuItem lossyToolStripMenuItem;
        private ToolStripMenuItem horizontalOnlyToolStripMenuItem;
        private ToolStripMenuItem verticalOnlyToolStripMenuItem;
        private ToolStripMenuItem saveImageToolStripMenuItem;
        private ToolStripMenuItem cameraToolStripMenuItem;
        private ToolStripMenuItem turnOnToolStripMenuItem;
        private ToolStripMenuItem turnOffToolStripMenuItem;
    }
}
