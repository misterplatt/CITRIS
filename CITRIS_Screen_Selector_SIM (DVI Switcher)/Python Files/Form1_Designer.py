import clr

class ScreenSelector(object):
	def __init__(self):
		# <summary>
		# Required designer variable.
		# </summary>
		self._components = None

	def Dispose(self, disposing):
		""" <summary>
		 Clean up any resources being used.
		 </summary>
		 <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		"""
		if disposing and (self._components != None):
			self._components.Dispose()
		self.Dispose(disposing)

	def InitializeComponent(self):
		""" <summary>
		 Required method for Designer support - do not modify
		 the contents of this method with the code editor.
		 </summary>
		"""
		self._components = System.ComponentModel.Container()
		resources = System.ComponentModel.ComponentResourceManager(clr.GetClrType(ScreenSelector))
		self._help = System.Windows.Forms.Label()
		self._alloff = System.Windows.Forms.Label()
		self._tv2_display = System.Windows.Forms.Label()
		self._podium = System.Windows.Forms.Label()
		self._laptop = System.Windows.Forms.Label()
		self._polycom_out = System.Windows.Forms.Label()
		self._doccam = System.Windows.Forms.Label()
		self._desktop1 = System.Windows.Forms.Label()
		self._polycom_in = System.Windows.Forms.Label()
		self._desktop2 = System.Windows.Forms.Label()
		self._help_instructions = System.Windows.Forms.TextBox()
		self._serialPort1 = System.IO.Ports.SerialPort(self._components)
		self._key = System.Windows.Forms.PictureBox()
		self._tv1_display = System.Windows.Forms.Label()
		((self._key)).BeginInit()
		self.SuspendLayout()
		# 
		# help
		# 
		self._help.BackColor = System.Drawing.Color.Transparent
		self._help.Cursor = System.Windows.Forms.Cursors.Default
		self._help.Font = System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((0)))
		self._help.Image = ((resources.GetObject("help.Image")))
		self._help.Location = System.Drawing.Point(1203, 2)
		self._help.Name = "help"
		self._help.Size = System.Drawing.Size(77, 77)
		self._help.TabIndex = 17
		self._help.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		self._help.MouseClick += self._help_MouseClick
		# 
		# alloff
		# 
		self._alloff.BackColor = System.Drawing.Color.Transparent
		self._alloff.Font = System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((0)))
		self._alloff.Image = ((resources.GetObject("alloff.Image")))
		self._alloff.Location = System.Drawing.Point(695, 601)
		self._alloff.Name = "alloff"
		self._alloff.Size = System.Drawing.Size(159, 151)
		self._alloff.TabIndex = 19
		self._alloff.Text = "Power Off All Displays"
		self._alloff.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		self._alloff.MouseClick += self._offOutputs_Click
		# 
		# tv2_display
		# 
		self._tv2_display.Font = System.Drawing.Font("Microsoft Sans Serif", 24f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((0)))
		self._tv2_display.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		self._tv2_display.Image = ((resources.GetObject("tv2_display.Image")))
		self._tv2_display.Location = System.Drawing.Point(648, 353)
		self._tv2_display.Name = "tv2_display"
		self._tv2_display.Size = System.Drawing.Size(270, 154)
		self._tv2_display.TabIndex = 20
		self._tv2_display.Text = "No Source"
		self._tv2_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		# 
		# podium
		# 
		self._podium.Font = System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((0)))
		self._podium.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		self._podium.Image = ((resources.GetObject("podium.Image")))
		self._podium.Location = System.Drawing.Point(23, 396)
		self._podium.Name = "podium"
		self._podium.Size = System.Drawing.Size(198, 151)
		self._podium.TabIndex = 21
		self._podium.Text = "No Source"
		self._podium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		# 
		# laptop
		# 
		self._laptop.BackColor = System.Drawing.Color.Transparent
		self._laptop.Image = ((resources.GetObject("laptop.Image")))
		self._laptop.Location = System.Drawing.Point(74, 129)
		self._laptop.Name = "laptop"
		self._laptop.Size = System.Drawing.Size(107, 108)
		self._laptop.TabIndex = 24
		# 
		# polycom_out
		# 
		self._polycom_out.Font = System.Drawing.Font("Microsoft Sans Serif", 24f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((0)))
		self._polycom_out.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		self._polycom_out.Image = ((resources.GetObject("polycom_out.Image")))
		self._polycom_out.Location = System.Drawing.Point(938, 352)
		self._polycom_out.Name = "polycom_out"
		self._polycom_out.Size = System.Drawing.Size(270, 155)
		self._polycom_out.TabIndex = 26
		self._polycom_out.Text = "No Source"
		self._polycom_out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		# 
		# doccam
		# 
		self._doccam.BackColor = System.Drawing.Color.Transparent
		self._doccam.Image = ((resources.GetObject("doccam.Image")))
		self._doccam.Location = System.Drawing.Point(267, 138)
		self._doccam.Name = "doccam"
		self._doccam.Size = System.Drawing.Size(153, 99)
		self._doccam.TabIndex = 27
		# 
		# desktop1
		# 
		self._desktop1.BackColor = System.Drawing.Color.Transparent
		self._desktop1.Image = ((resources.GetObject("desktop1.Image")))
		self._desktop1.Location = System.Drawing.Point(782, 129)
		self._desktop1.Name = "desktop1"
		self._desktop1.Size = System.Drawing.Size(158, 108)
		self._desktop1.TabIndex = 29
		# 
		# polycom_in
		# 
		self._polycom_in.BackColor = System.Drawing.Color.Transparent
		self._polycom_in.Image = ((resources.GetObject("polycom_in.Image")))
		self._polycom_in.Location = System.Drawing.Point(524, 113)
		self._polycom_in.Name = "polycom_in"
		self._polycom_in.Size = System.Drawing.Size(179, 138)
		self._polycom_in.TabIndex = 28
		# 
		# desktop2
		# 
		self._desktop2.BackColor = System.Drawing.Color.Transparent
		self._desktop2.Image = ((resources.GetObject("desktop2.Image")))
		self._desktop2.Location = System.Drawing.Point(1024, 129)
		self._desktop2.Name = "desktop2"
		self._desktop2.Size = System.Drawing.Size(158, 98)
		self._desktop2.TabIndex = 30
		# 
		# help_instructions
		# 
		self._help_instructions.Font = System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((0)))
		self._help_instructions.Location = System.Drawing.Point(315, 794)
		self._help_instructions.Multiline = True
		self._help_instructions.Name = "help_instructions"
		self._help_instructions.ReadOnly = True
		self._help_instructions.Size = System.Drawing.Size(642, 229)
		self._help_instructions.TabIndex = 18
		self._help_instructions.Text = resources.GetString("help_instructions.Text")
		self._help_instructions.Visible = False
		# 
		# key
		# 
		self._key.BackColor = System.Drawing.Color.Transparent
		self._key.BackgroundImage = ((resources.GetObject("key.BackgroundImage")))
		self._key.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		self._key.Location = System.Drawing.Point(1258, 794)
		self._key.Name = "key"
		self._key.Size = System.Drawing.Size(22, 27)
		self._key.TabIndex = 39
		self._key.TabStop = False
		self._key.Visible = False
		self._key.MouseDown += self._egg_MouseDown
		self._key.MouseMove += self._egg_MouseMove
		self._key.MouseUp += self._egg_MouseUp
		# 
		# tv1_display
		# 
		self._tv1_display.Font = System.Drawing.Font("Microsoft Sans Serif", 24f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((0)))
		self._tv1_display.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		self._tv1_display.Image = ((resources.GetObject("tv1_display.Image")))
		self._tv1_display.Location = System.Drawing.Point(359, 353)
		self._tv1_display.Name = "tv1_display"
		self._tv1_display.Size = System.Drawing.Size(270, 154)
		self._tv1_display.TabIndex = 16
		self._tv1_display.Text = "No Source"
		self._tv1_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		# 
		# ScreenSelector
		# 
		self._AutoScaleDimensions = System.Drawing.SizeF(6f, 13f)
		self._AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		self._BackColor = System.Drawing.Color.LightGray
		self._BackgroundImage = ((resources.GetObject("$this.BackgroundImage")))
		self._BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		self._ClientSize = System.Drawing.Size(1280, 1024)
		self._Controls.Add(self._help_instructions)
		self._Controls.Add(self._key)
		self._Controls.Add(self._desktop2)
		self._Controls.Add(self._desktop1)
		self._Controls.Add(self._polycom_in)
		self._Controls.Add(self._doccam)
		self._Controls.Add(self._laptop)
		self._Controls.Add(self._polycom_out)
		self._Controls.Add(self._alloff)
		self._Controls.Add(self._podium)
		self._Controls.Add(self._tv2_display)
		self._Controls.Add(self._help)
		self._Controls.Add(self._tv1_display)
		self._DoubleBuffered = True
		self._FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		self._Name = "ScreenSelector"
		self._StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		self._Text = "1"
		((self._key)).EndInit()
		self.ResumeLayout(False)
		self.PerformLayout()