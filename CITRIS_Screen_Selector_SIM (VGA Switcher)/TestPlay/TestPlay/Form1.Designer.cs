namespace ScreenSelector
{
    partial class ScreenSelector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenSelector));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.TV2 = new System.Windows.Forms.Button();
            this.TV1 = new System.Windows.Forms.Button();
            this.Podium = new System.Windows.Forms.Button();
            this.presentation = new System.Windows.Forms.Button();
            this.recording = new System.Windows.Forms.Button();
            this.resPC1 = new System.Windows.Forms.Button();
            this.resPC2 = new System.Windows.Forms.Button();
            this.docCam = new System.Windows.Forms.Button();
            this.polycomOut = new System.Windows.Forms.Button();
            this.laptop = new System.Windows.Forms.Button();
            this.offOutputs = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DiscardNull = true;
            this.serialPort1.PortName = "COM3";
            this.serialPort1.ReadTimeout = 128;
            this.serialPort1.ReceivedBytesThreshold = 16;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Handle_Response);
            // 
            // TV2
            // 
            this.TV2.AllowDrop = true;
            this.TV2.BackColor = System.Drawing.Color.White;
            this.TV2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TV2.BackgroundImage")));
            this.TV2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TV2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TV2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TV2.Location = new System.Drawing.Point(226, 307);
            this.TV2.Name = "TV2";
            this.TV2.Size = new System.Drawing.Size(421, 243);
            this.TV2.TabIndex = 0;
            this.TV2.Text = "TV 2";
            this.TV2.UseVisualStyleBackColor = false;
            // 
            // TV1
            // 
            this.TV1.AllowDrop = true;
            this.TV1.BackColor = System.Drawing.Color.White;
            this.TV1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TV1.BackgroundImage")));
            this.TV1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TV1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TV1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TV1.Location = new System.Drawing.Point(653, 307);
            this.TV1.Name = "TV1";
            this.TV1.Size = new System.Drawing.Size(421, 243);
            this.TV1.TabIndex = 1;
            this.TV1.Text = "TV 1";
            this.TV1.UseVisualStyleBackColor = false;
            // 
            // Podium
            // 
            this.Podium.AllowDrop = true;
            this.Podium.BackColor = System.Drawing.Color.White;
            this.Podium.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Podium.BackgroundImage")));
            this.Podium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Podium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Podium.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Podium.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Podium.Location = new System.Drawing.Point(1094, 447);
            this.Podium.Name = "Podium";
            this.Podium.Size = new System.Drawing.Size(143, 117);
            this.Podium.TabIndex = 2;
            this.Podium.Text = "Podium";
            this.Podium.UseVisualStyleBackColor = false;
            // 
            // presentation
            // 
            this.presentation.AllowDrop = true;
            this.presentation.BackColor = System.Drawing.Color.White;
            this.presentation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("presentation.BackgroundImage")));
            this.presentation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.presentation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.presentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.presentation.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.presentation.Location = new System.Drawing.Point(1094, 302);
            this.presentation.Name = "presentation";
            this.presentation.Size = new System.Drawing.Size(143, 116);
            this.presentation.TabIndex = 3;
            this.presentation.Text = "Polycom Presentation";
            this.presentation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.presentation.UseVisualStyleBackColor = false;
            // 
            // recording
            // 
            this.recording.BackColor = System.Drawing.Color.Black;
            this.recording.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("recording.BackgroundImage")));
            this.recording.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.recording.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recording.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recording.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.recording.Location = new System.Drawing.Point(58, 655);
            this.recording.Name = "recording";
            this.recording.Size = new System.Drawing.Size(68, 67);
            this.recording.TabIndex = 4;
            this.recording.Text = "Record";
            this.recording.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.recording.UseVisualStyleBackColor = false;
            // 
            // resPC1
            // 
            this.resPC1.BackColor = System.Drawing.Color.White;
            this.resPC1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resPC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resPC1.Location = new System.Drawing.Point(40, 363);
            this.resPC1.Name = "resPC1";
            this.resPC1.Size = new System.Drawing.Size(100, 67);
            this.resPC1.TabIndex = 5;
            this.resPC1.Text = "Res PC 1";
            this.resPC1.UseVisualStyleBackColor = false;
            // 
            // resPC2
            // 
            this.resPC2.BackColor = System.Drawing.Color.White;
            this.resPC2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resPC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resPC2.Location = new System.Drawing.Point(40, 436);
            this.resPC2.Name = "resPC2";
            this.resPC2.Size = new System.Drawing.Size(100, 67);
            this.resPC2.TabIndex = 6;
            this.resPC2.Text = "Res PC 2";
            this.resPC2.UseVisualStyleBackColor = false;
            // 
            // docCam
            // 
            this.docCam.BackColor = System.Drawing.Color.White;
            this.docCam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.docCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docCam.Location = new System.Drawing.Point(40, 509);
            this.docCam.Name = "docCam";
            this.docCam.Size = new System.Drawing.Size(100, 67);
            this.docCam.TabIndex = 7;
            this.docCam.Text = "Doc Cam";
            this.docCam.UseVisualStyleBackColor = false;
            // 
            // polycomOut
            // 
            this.polycomOut.BackColor = System.Drawing.Color.White;
            this.polycomOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.polycomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polycomOut.Location = new System.Drawing.Point(40, 582);
            this.polycomOut.Name = "polycomOut";
            this.polycomOut.Size = new System.Drawing.Size(100, 67);
            this.polycomOut.TabIndex = 8;
            this.polycomOut.Text = "Polycom";
            this.polycomOut.UseVisualStyleBackColor = false;
            // 
            // laptop
            // 
            this.laptop.BackColor = System.Drawing.Color.White;
            this.laptop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.laptop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laptop.Location = new System.Drawing.Point(40, 290);
            this.laptop.Name = "laptop";
            this.laptop.Size = new System.Drawing.Size(100, 67);
            this.laptop.TabIndex = 10;
            this.laptop.Text = "Laptop";
            this.laptop.UseVisualStyleBackColor = false;
            this.laptop.Click += new System.EventHandler(this.laptop_Click);
            // 
            // offOutputs
            // 
            this.offOutputs.BackColor = System.Drawing.Color.White;
            this.offOutputs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.offOutputs.Location = new System.Drawing.Point(1094, 247);
            this.offOutputs.Name = "offOutputs";
            this.offOutputs.Size = new System.Drawing.Size(143, 31);
            this.offOutputs.TabIndex = 12;
            this.offOutputs.Tag = -1;
            this.offOutputs.Text = "ALL OFF";
            this.offOutputs.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 802);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1282, 222);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1080, 560);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 236);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(550, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Destinations";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "Sources";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScreenSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.laptop);
            this.Controls.Add(this.recording);
            this.Controls.Add(this.polycomOut);
            this.Controls.Add(this.offOutputs);
            this.Controls.Add(this.docCam);
            this.Controls.Add(this.presentation);
            this.Controls.Add(this.resPC2);
            this.Controls.Add(this.resPC1);
            this.Controls.Add(this.Podium);
            this.Controls.Add(this.TV1);
            this.Controls.Add(this.TV2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenSelector";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I/O Select";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Button TV2;
        private System.Windows.Forms.Button TV1;
        private System.Windows.Forms.Button Podium;
        private System.Windows.Forms.Button presentation;
        private System.Windows.Forms.Button resPC1;
        private System.Windows.Forms.Button resPC2;
        private System.Windows.Forms.Button docCam;
        private System.Windows.Forms.Button polycomOut;
        private System.Windows.Forms.Button laptop;

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button recording;
        private System.Windows.Forms.Button offOutputs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}

