namespace CITRIS_Screen_Selector_Drag_and_Drop
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
            this.help = new System.Windows.Forms.Label();
            this.alloff = new System.Windows.Forms.Label();
            this.tv2_display = new System.Windows.Forms.Label();
            this.podium = new System.Windows.Forms.Label();
            this.laptop = new System.Windows.Forms.Label();
            this.polycom_out = new System.Windows.Forms.Label();
            this.doccam = new System.Windows.Forms.Label();
            this.desktop1 = new System.Windows.Forms.Label();
            this.polycom_in = new System.Windows.Forms.Label();
            this.desktop2 = new System.Windows.Forms.Label();
            this.help_instructions = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.key = new System.Windows.Forms.PictureBox();
            this.tv1_display = new System.Windows.Forms.Label();
            this.close_podium = new System.Windows.Forms.Label();
            this.x_proj1 = new System.Windows.Forms.Label();
            this.x_proj2 = new System.Windows.Forms.Label();
            this.x_proj3 = new System.Windows.Forms.Label();
            this.TURNON = new System.Windows.Forms.Button();
            this.TURNOFF = new System.Windows.Forms.Button();
            this.PROJ1 = new System.Windows.Forms.Button();
            this.PROJ2 = new System.Windows.Forms.Button();
            this.PROJ3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.key)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.Transparent;
            this.help.Cursor = System.Windows.Forms.Cursors.Default;
            this.help.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help.Image = ((System.Drawing.Image)(resources.GetObject("help.Image")));
            this.help.Location = new System.Drawing.Point(940, 749);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(77, 77);
            this.help.TabIndex = 17;
            this.help.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.help.MouseClick += new System.Windows.Forms.MouseEventHandler(this.help_MouseClick);
            // 
            // alloff
            // 
            this.alloff.BackColor = System.Drawing.Color.Transparent;
            this.alloff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alloff.Image = ((System.Drawing.Image)(resources.GetObject("alloff.Image")));
            this.alloff.Location = new System.Drawing.Point(1537, 557);
            this.alloff.Name = "alloff";
            this.alloff.Size = new System.Drawing.Size(159, 151);
            this.alloff.TabIndex = 19;
            this.alloff.Text = "Clear All Displays";
            this.alloff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.alloff.Click += new System.EventHandler(this.alloff_Click);
            this.alloff.MouseClick += new System.Windows.Forms.MouseEventHandler(this.offOutputs_Click);
            // 
            // tv2_display
            // 
            this.tv2_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv2_display.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tv2_display.Image = ((System.Drawing.Image)(resources.GetObject("tv2_display.Image")));
            this.tv2_display.Location = new System.Drawing.Point(592, 270);
            this.tv2_display.Name = "tv2_display";
            this.tv2_display.Size = new System.Drawing.Size(733, 392);
            this.tv2_display.TabIndex = 20;
            this.tv2_display.Text = "Projector 2/Large";
            this.tv2_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tv2_display.Click += new System.EventHandler(this.output_MouseClick);
            // 
            // podium
            // 
            this.podium.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.podium.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.podium.Image = ((System.Drawing.Image)(resources.GetObject("podium.Image")));
            this.podium.Location = new System.Drawing.Point(73, 563);
            this.podium.Name = "podium";
            this.podium.Size = new System.Drawing.Size(181, 171);
            this.podium.TabIndex = 21;
            this.podium.Text = "Podium";
            this.podium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.podium.Click += new System.EventHandler(this.podium_Click);
            // 
            // laptop
            // 
            this.laptop.BackColor = System.Drawing.Color.Transparent;
            this.laptop.Image = ((System.Drawing.Image)(resources.GetObject("laptop.Image")));
            this.laptop.Location = new System.Drawing.Point(62, 80);
            this.laptop.Name = "laptop";
            this.laptop.Size = new System.Drawing.Size(107, 108);
            this.laptop.TabIndex = 24;
            // 
            // polycom_out
            // 
            this.polycom_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polycom_out.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.polycom_out.Image = ((System.Drawing.Image)(resources.GetObject("polycom_out.Image")));
            this.polycom_out.Location = new System.Drawing.Point(1405, 270);
            this.polycom_out.Name = "polycom_out";
            this.polycom_out.Size = new System.Drawing.Size(405, 228);
            this.polycom_out.TabIndex = 26;
            this.polycom_out.Text = "Projector 3";
            this.polycom_out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.polycom_out.Click += new System.EventHandler(this.output_MouseClick);
            // 
            // doccam
            // 
            this.doccam.BackColor = System.Drawing.Color.Transparent;
            this.doccam.Image = ((System.Drawing.Image)(resources.GetObject("doccam.Image")));
            this.doccam.Location = new System.Drawing.Point(404, 89);
            this.doccam.Name = "doccam";
            this.doccam.Size = new System.Drawing.Size(153, 99);
            this.doccam.TabIndex = 27;
            // 
            // desktop1
            // 
            this.desktop1.BackColor = System.Drawing.Color.Transparent;
            this.desktop1.Image = ((System.Drawing.Image)(resources.GetObject("desktop1.Image")));
            this.desktop1.Location = new System.Drawing.Point(1242, 90);
            this.desktop1.Name = "desktop1";
            this.desktop1.Size = new System.Drawing.Size(158, 108);
            this.desktop1.TabIndex = 29;
            // 
            // polycom_in
            // 
            this.polycom_in.BackColor = System.Drawing.Color.Transparent;
            this.polycom_in.Image = ((System.Drawing.Image)(resources.GetObject("polycom_in.Image")));
            this.polycom_in.Location = new System.Drawing.Point(872, 89);
            this.polycom_in.Name = "polycom_in";
            this.polycom_in.Size = new System.Drawing.Size(130, 106);
            this.polycom_in.TabIndex = 28;
            // 
            // desktop2
            // 
            this.desktop2.BackColor = System.Drawing.Color.Transparent;
            this.desktop2.Image = ((System.Drawing.Image)(resources.GetObject("desktop2.Image")));
            this.desktop2.Location = new System.Drawing.Point(1652, 90);
            this.desktop2.Name = "desktop2";
            this.desktop2.Size = new System.Drawing.Size(158, 98);
            this.desktop2.TabIndex = 30;
            // 
            // help_instructions
            // 
            this.help_instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_instructions.Location = new System.Drawing.Point(599, 829);
            this.help_instructions.Multiline = true;
            this.help_instructions.Name = "help_instructions";
            this.help_instructions.ReadOnly = true;
            this.help_instructions.Size = new System.Drawing.Size(726, 229);
            this.help_instructions.TabIndex = 18;
            this.help_instructions.Text = resources.GetString("help_instructions.Text");
            this.help_instructions.Visible = false;
            // 
            // key
            // 
            this.key.BackColor = System.Drawing.Color.Transparent;
            this.key.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("key.BackgroundImage")));
            this.key.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.key.Location = new System.Drawing.Point(963, 981);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(22, 27);
            this.key.TabIndex = 39;
            this.key.TabStop = false;
            this.key.Visible = false;
            this.key.MouseDown += new System.Windows.Forms.MouseEventHandler(this.egg_MouseDown);
            this.key.MouseMove += new System.Windows.Forms.MouseEventHandler(this.egg_MouseMove);
            this.key.MouseUp += new System.Windows.Forms.MouseEventHandler(this.egg_MouseUp);
            // 
            // tv1_display
            // 
            this.tv1_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv1_display.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tv1_display.Image = ((System.Drawing.Image)(resources.GetObject("tv1_display.Image")));
            this.tv1_display.Location = new System.Drawing.Point(108, 270);
            this.tv1_display.Name = "tv1_display";
            this.tv1_display.Size = new System.Drawing.Size(405, 228);
            this.tv1_display.TabIndex = 16;
            this.tv1_display.Text = "Projector 1";
            this.tv1_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tv1_display.Click += new System.EventHandler(this.output_MouseClick);
            // 
            // close_podium
            // 
            this.close_podium.Image = ((System.Drawing.Image)(resources.GetObject("close_podium.Image")));
            this.close_podium.Location = new System.Drawing.Point(203, 563);
            this.close_podium.Name = "close_podium";
            this.close_podium.Size = new System.Drawing.Size(51, 54);
            this.close_podium.TabIndex = 40;
            this.close_podium.Visible = false;
            this.close_podium.Click += new System.EventHandler(this.output_MouseClick);
            // 
            // x_proj1
            // 
            this.x_proj1.Image = ((System.Drawing.Image)(resources.GetObject("x_proj1.Image")));
            this.x_proj1.Location = new System.Drawing.Point(456, 270);
            this.x_proj1.Name = "x_proj1";
            this.x_proj1.Size = new System.Drawing.Size(57, 53);
            this.x_proj1.TabIndex = 41;
            this.x_proj1.Visible = false;
            this.x_proj1.Click += new System.EventHandler(this.output_MouseClick);
            // 
            // x_proj2
            // 
            this.x_proj2.Image = ((System.Drawing.Image)(resources.GetObject("x_proj2.Image")));
            this.x_proj2.Location = new System.Drawing.Point(1274, 270);
            this.x_proj2.Name = "x_proj2";
            this.x_proj2.Size = new System.Drawing.Size(51, 54);
            this.x_proj2.TabIndex = 42;
            this.x_proj2.Visible = false;
            this.x_proj2.Click += new System.EventHandler(this.output_MouseClick);
            // 
            // x_proj3
            // 
            this.x_proj3.Image = ((System.Drawing.Image)(resources.GetObject("x_proj3.Image")));
            this.x_proj3.Location = new System.Drawing.Point(1759, 270);
            this.x_proj3.Name = "x_proj3";
            this.x_proj3.Size = new System.Drawing.Size(51, 54);
            this.x_proj3.TabIndex = 43;
            this.x_proj3.Visible = false;
            this.x_proj3.Click += new System.EventHandler(this.output_MouseClick);
            // 
            // TURNON
            // 
            this.TURNON.Image = ((System.Drawing.Image)(resources.GetObject("TURNON.Image")));
            this.TURNON.Location = new System.Drawing.Point(774, 676);
            this.TURNON.Name = "TURNON";
            this.TURNON.Size = new System.Drawing.Size(116, 54);
            this.TURNON.TabIndex = 44;
            this.TURNON.UseVisualStyleBackColor = true;
            this.TURNON.Click += new System.EventHandler(this.TURNON_Click);
            // 
            // TURNOFF
            // 
            this.TURNOFF.Image = ((System.Drawing.Image)(resources.GetObject("TURNOFF.Image")));
            this.TURNOFF.Location = new System.Drawing.Point(1051, 676);
            this.TURNOFF.Name = "TURNOFF";
            this.TURNOFF.Size = new System.Drawing.Size(115, 54);
            this.TURNOFF.TabIndex = 45;
            this.TURNOFF.UseVisualStyleBackColor = true;
            this.TURNOFF.Click += new System.EventHandler(this.TURNOFF_Click);
            // 
            // PROJ1
            // 
            this.PROJ1.Image = ((System.Drawing.Image)(resources.GetObject("PROJ1.Image")));
            this.PROJ1.Location = new System.Drawing.Point(444, 510);
            this.PROJ1.Name = "PROJ1";
            this.PROJ1.Size = new System.Drawing.Size(69, 44);
            this.PROJ1.TabIndex = 46;
            this.PROJ1.UseVisualStyleBackColor = true;
            this.PROJ1.Click += new System.EventHandler(this.PROJ1_Click);
            // 
            // PROJ2
            // 
            this.PROJ2.Image = ((System.Drawing.Image)(resources.GetObject("PROJ2.Image")));
            this.PROJ2.Location = new System.Drawing.Point(1256, 676);
            this.PROJ2.Name = "PROJ2";
            this.PROJ2.Size = new System.Drawing.Size(69, 44);
            this.PROJ2.TabIndex = 47;
            this.PROJ2.UseVisualStyleBackColor = true;
            this.PROJ2.Click += new System.EventHandler(this.PROJ2_Click);
            // 
            // PROJ3
            // 
            this.PROJ3.Image = ((System.Drawing.Image)(resources.GetObject("PROJ3.Image")));
            this.PROJ3.Location = new System.Drawing.Point(1741, 511);
            this.PROJ3.Name = "PROJ3";
            this.PROJ3.Size = new System.Drawing.Size(69, 43);
            this.PROJ3.TabIndex = 48;
            this.PROJ3.UseVisualStyleBackColor = true;
            this.PROJ3.Click += new System.EventHandler(this.PROJ3_Click);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.textBox1.BackColor = System.Drawing.Color.Gray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Eras Bold ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Location = new System.Drawing.Point(65, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1745, 34);
            this.textBox1.TabIndex = 49;
            this.textBox1.Text = "DISPLAYS";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(65, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1745, 11);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Eras Bold ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox2.Location = new System.Drawing.Point(65, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1745, 34);
            this.textBox2.TabIndex = 51;
            this.textBox2.Text = "SOURCES";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.pictureBox2.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(65, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1745, 11);
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(354, 654);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(107, 140);
            this.webBrowser1.TabIndex = 53;
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // ScreenSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1070);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.PROJ3);
            this.Controls.Add(this.PROJ2);
            this.Controls.Add(this.PROJ1);
            this.Controls.Add(this.TURNOFF);
            this.Controls.Add(this.TURNON);
            this.Controls.Add(this.x_proj3);
            this.Controls.Add(this.x_proj2);
            this.Controls.Add(this.x_proj1);
            this.Controls.Add(this.close_podium);
            this.Controls.Add(this.help_instructions);
            this.Controls.Add(this.key);
            this.Controls.Add(this.desktop2);
            this.Controls.Add(this.desktop1);
            this.Controls.Add(this.doccam);
            this.Controls.Add(this.laptop);
            this.Controls.Add(this.polycom_out);
            this.Controls.Add(this.alloff);
            this.Controls.Add(this.podium);
            this.Controls.Add(this.tv2_display);
            this.Controls.Add(this.help);
            this.Controls.Add(this.tv1_display);
            this.Controls.Add(this.polycom_in);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1";
            ((System.ComponentModel.ISupportInitialize)(this.key)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label help;
        private System.Windows.Forms.TextBox help_instructions;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label alloff;
        private System.Windows.Forms.Label tv2_display;
        private System.Windows.Forms.Label podium;
        private System.Windows.Forms.Label laptop;
        private System.Windows.Forms.Label polycom_out;
        private System.Windows.Forms.Label doccam;
        private System.Windows.Forms.Label desktop1;
        private System.Windows.Forms.Label polycom_in;
        private System.Windows.Forms.Label desktop2;
        private System.Windows.Forms.PictureBox key;
        private System.Windows.Forms.Label tv1_display;
        private System.Windows.Forms.Label close_podium;
        private System.Windows.Forms.Label x_proj1;
        private System.Windows.Forms.Label x_proj2;
        private System.Windows.Forms.Label x_proj3;
        private System.Windows.Forms.Button TURNON;
        private System.Windows.Forms.Button TURNOFF;
        private System.Windows.Forms.Button PROJ1;
        private System.Windows.Forms.Button PROJ2;
        private System.Windows.Forms.Button PROJ3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

