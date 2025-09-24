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
            cameraToolStripMenuItem = new ToolStripMenuItem();
            turnOnToolStripMenuItem = new ToolStripMenuItem();
            turnOffToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonCopy = new Button();
            buttonGreyscale = new Button();
            buttonColorInversion = new Button();
            buttonHistogram = new Button();
            buttonSepia = new Button();
            pictureBox3 = new PictureBox();
            buttonSubtract = new Button();
            label1 = new Label();
            label2 = new Label();
            buttonCameraCopy = new Button();
            buttonCameraGreyscale = new Button();
            buttonCameraInversion = new Button();
            buttonCameraHistogram = new Button();
            buttonCameraSepia = new Button();
            buttonCameraSubtract = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, cameraToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1264, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { loadImageToolStripMenuItem, loadBackgroundToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(37, 20);
            toolStripMenuItem1.Text = "File";
            // 
            // loadImageToolStripMenuItem
            // 
            loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            loadImageToolStripMenuItem.Size = new Size(167, 22);
            loadImageToolStripMenuItem.Text = "Load Image";
            loadImageToolStripMenuItem.Click += loadImageToolStripMenuItem_Click;
            // 
            // loadBackgroundToolStripMenuItem
            // 
            loadBackgroundToolStripMenuItem.Name = "loadBackgroundToolStripMenuItem";
            loadBackgroundToolStripMenuItem.Size = new Size(167, 22);
            loadBackgroundToolStripMenuItem.Text = "Load Background";
            loadBackgroundToolStripMenuItem.Click += loadBackgroundToolStripMenuItem_Click;
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
            turnOnToolStripMenuItem.Size = new Size(117, 22);
            turnOnToolStripMenuItem.Text = "Turn on";
            turnOnToolStripMenuItem.Click += turnOnToolStripMenuItem_Click;
            // 
            // turnOffToolStripMenuItem
            // 
            turnOffToolStripMenuItem.Name = "turnOffToolStripMenuItem";
            turnOffToolStripMenuItem.Size = new Size(117, 22);
            turnOffToolStripMenuItem.Text = "Turn off";
            turnOffToolStripMenuItem.Click += turnOffToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(8, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 232);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(427, 134);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(413, 232);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // buttonCopy
            // 
            buttonCopy.Location = new Point(42, 460);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(110, 25);
            buttonCopy.TabIndex = 3;
            buttonCopy.Text = "Copy";
            buttonCopy.UseVisualStyleBackColor = true;
            buttonCopy.Click += buttonCopy_Click;
            // 
            // buttonGreyscale
            // 
            buttonGreyscale.Location = new Point(158, 460);
            buttonGreyscale.Name = "buttonGreyscale";
            buttonGreyscale.Size = new Size(110, 25);
            buttonGreyscale.TabIndex = 4;
            buttonGreyscale.Text = "Greyscale";
            buttonGreyscale.UseVisualStyleBackColor = true;
            buttonGreyscale.Click += buttonGreyscale_Click;
            // 
            // buttonColorInversion
            // 
            buttonColorInversion.Location = new Point(274, 460);
            buttonColorInversion.Name = "buttonColorInversion";
            buttonColorInversion.Size = new Size(110, 25);
            buttonColorInversion.TabIndex = 5;
            buttonColorInversion.Text = "Inversion";
            buttonColorInversion.UseVisualStyleBackColor = true;
            buttonColorInversion.Click += buttonColorInversion_Click;
            // 
            // buttonHistogram
            // 
            buttonHistogram.Location = new Point(390, 460);
            buttonHistogram.Name = "buttonHistogram";
            buttonHistogram.Size = new Size(110, 25);
            buttonHistogram.TabIndex = 6;
            buttonHistogram.Text = "Histogram";
            buttonHistogram.UseVisualStyleBackColor = true;
            buttonHistogram.Click += buttonHistogram_Click;
            // 
            // buttonSepia
            // 
            buttonSepia.Location = new Point(42, 501);
            buttonSepia.Name = "buttonSepia";
            buttonSepia.Size = new Size(110, 25);
            buttonSepia.TabIndex = 7;
            buttonSepia.Text = "Sepia";
            buttonSepia.UseVisualStyleBackColor = true;
            buttonSepia.Click += buttonSepia_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(846, 134);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(413, 232);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // buttonSubtract
            // 
            buttonSubtract.Location = new Point(158, 501);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(110, 25);
            buttonSubtract.TabIndex = 9;
            buttonSubtract.Text = "Subtract";
            buttonSubtract.UseVisualStyleBackColor = true;
            buttonSubtract.Click += buttonSubtract_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 442);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 10;
            label1.Text = "Image";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(720, 442);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 11;
            label2.Text = "Camera";
            // 
            // buttonCameraCopy
            // 
            buttonCameraCopy.Location = new Point(720, 460);
            buttonCameraCopy.Name = "buttonCameraCopy";
            buttonCameraCopy.Size = new Size(110, 25);
            buttonCameraCopy.TabIndex = 12;
            buttonCameraCopy.Text = "Copy";
            buttonCameraCopy.UseVisualStyleBackColor = true;
            buttonCameraCopy.Click += buttonCameraCopy_Click;
            // 
            // buttonCameraGreyscale
            // 
            buttonCameraGreyscale.Location = new Point(836, 460);
            buttonCameraGreyscale.Name = "buttonCameraGreyscale";
            buttonCameraGreyscale.Size = new Size(110, 25);
            buttonCameraGreyscale.TabIndex = 13;
            buttonCameraGreyscale.Text = "Greyscale";
            buttonCameraGreyscale.UseVisualStyleBackColor = true;
            buttonCameraGreyscale.Click += buttonCameraGreyscale_Click;
            // 
            // buttonCameraInversion
            // 
            buttonCameraInversion.Location = new Point(952, 460);
            buttonCameraInversion.Name = "buttonCameraInversion";
            buttonCameraInversion.Size = new Size(110, 25);
            buttonCameraInversion.TabIndex = 14;
            buttonCameraInversion.Text = "Inversion";
            buttonCameraInversion.UseVisualStyleBackColor = true;
            buttonCameraInversion.Click += buttonCameraInversion_Click;
            // 
            // buttonCameraHistogram
            // 
            buttonCameraHistogram.Location = new Point(1068, 460);
            buttonCameraHistogram.Name = "buttonCameraHistogram";
            buttonCameraHistogram.Size = new Size(110, 25);
            buttonCameraHistogram.TabIndex = 15;
            buttonCameraHistogram.Text = "Histogram";
            buttonCameraHistogram.UseVisualStyleBackColor = true;
            buttonCameraHistogram.Click += buttonCameraHistogram_Click;
            // 
            // buttonCameraSepia
            // 
            buttonCameraSepia.Location = new Point(720, 501);
            buttonCameraSepia.Name = "buttonCameraSepia";
            buttonCameraSepia.Size = new Size(110, 25);
            buttonCameraSepia.TabIndex = 16;
            buttonCameraSepia.Text = "Sepia";
            buttonCameraSepia.UseVisualStyleBackColor = true;
            buttonCameraSepia.Click += buttonCameraSepia_Click;
            // 
            // buttonCameraSubtract
            // 
            buttonCameraSubtract.Location = new Point(836, 501);
            buttonCameraSubtract.Name = "buttonCameraSubtract";
            buttonCameraSubtract.Size = new Size(110, 25);
            buttonCameraSubtract.TabIndex = 17;
            buttonCameraSubtract.Text = "Subtract";
            buttonCameraSubtract.UseVisualStyleBackColor = true;
            buttonCameraSubtract.Click += buttonCameraSubtract_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(buttonCameraSubtract);
            Controls.Add(buttonCameraSepia);
            Controls.Add(buttonCameraHistogram);
            Controls.Add(buttonCameraInversion);
            Controls.Add(buttonCameraGreyscale);
            Controls.Add(buttonCameraCopy);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSubtract);
            Controls.Add(pictureBox3);
            Controls.Add(buttonSepia);
            Controls.Add(buttonHistogram);
            Controls.Add(buttonColorInversion);
            Controls.Add(buttonGreyscale);
            Controls.Add(buttonCopy);
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
        private Button buttonCopy;
        private Button buttonGreyscale;
        private Button buttonColorInversion;
        private Button buttonSepia;
        private Button buttonHistogram;
        private ToolStripMenuItem loadBackgroundToolStripMenuItem;
        private PictureBox pictureBox3;
        private Button buttonSubtract;
        private ToolStripMenuItem cameraToolStripMenuItem;
        private ToolStripMenuItem turnOnToolStripMenuItem;
        private ToolStripMenuItem turnOffToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Button buttonCameraCopy;
        private Button buttonCameraGreyscale;
        private Button buttonCameraInversion;
        private Button buttonCameraHistogram;
        private Button buttonCameraSepia;
        private Button buttonCameraSubtract;
    }
}
