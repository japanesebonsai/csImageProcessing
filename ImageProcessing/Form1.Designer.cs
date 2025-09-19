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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonCopy = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            buttonGreyscale = new Button();
            buttonColorInversion = new Button();
            buttonHistogram = new Button();
            buttonSepia = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(833, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { loadImageToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(37, 20);
            toolStripMenuItem1.Text = "File";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // loadImageToolStripMenuItem
            // 
            loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            loadImageToolStripMenuItem.Size = new Size(136, 22);
            loadImageToolStripMenuItem.Text = "Load Image";
            loadImageToolStripMenuItem.Click += loadImageToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(42, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(324, 365);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(418, 58);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(324, 365);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // buttonCopy
            // 
            buttonCopy.Location = new Point(42, 460);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(75, 23);
            buttonCopy.TabIndex = 3;
            buttonCopy.Text = "Copy";
            buttonCopy.UseVisualStyleBackColor = true;
            buttonCopy.Click += buttonCopy_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // buttonGreyscale
            // 
            buttonGreyscale.Location = new Point(123, 460);
            buttonGreyscale.Name = "buttonGreyscale";
            buttonGreyscale.Size = new Size(75, 23);
            buttonGreyscale.TabIndex = 4;
            buttonGreyscale.Text = "Greyscale";
            buttonGreyscale.UseVisualStyleBackColor = true;
            buttonGreyscale.Click += buttonGreyscale_Click;
            // 
            // buttonColorInversion
            // 
            buttonColorInversion.Location = new Point(204, 460);
            buttonColorInversion.Name = "buttonColorInversion";
            buttonColorInversion.Size = new Size(75, 23);
            buttonColorInversion.TabIndex = 5;
            buttonColorInversion.Text = "Inversion";
            buttonColorInversion.UseVisualStyleBackColor = true;
            buttonColorInversion.Click += buttonColorInversion_Click;
            // 
            // buttonHistogram
            // 
            buttonHistogram.Location = new Point(285, 460);
            buttonHistogram.Name = "buttonHistogram";
            buttonHistogram.Size = new Size(75, 23);
            buttonHistogram.TabIndex = 6;
            buttonHistogram.Text = "Histogram";
            buttonHistogram.UseVisualStyleBackColor = true;
            buttonHistogram.Click += buttonHistogram_Click;
            // 
            // buttonSepia
            // 
            buttonSepia.Location = new Point(366, 460);
            buttonSepia.Name = "buttonSepia";
            buttonSepia.Size = new Size(75, 23);
            buttonSepia.TabIndex = 7;
            buttonSepia.Text = "Sepia";
            buttonSepia.UseVisualStyleBackColor = true;
            buttonSepia.Click += buttonSepia_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 590);
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
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
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
        private FileSystemWatcher fileSystemWatcher1;
        private Button buttonGreyscale;
        private Button buttonColorInversion;
        private Button buttonSepia;
        private Button buttonHistogram;
    }
}
