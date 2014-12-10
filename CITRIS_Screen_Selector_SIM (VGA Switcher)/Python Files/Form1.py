from System import *
from System.Collections.Generic import *
from System.ComponentModel import *
from System.Data import *
from System.Drawing import *
from System.Linq import *
from System.Text import *
from System.Windows.Forms import *

class ScreenSelector(Form):

	class LabelType(object):
		def __init__(self):

	class LabelTag(object):
		def get_GetLabelType(self):
			return self.__type

		GetLabelType = property(fget=get_GetLabelType)

		def get_GetIndex(self):
			return self.__index

		GetIndex = property(fget=get_GetIndex)

		def get_GetDisplayText(self):
			return self.__display_text

		GetDisplayText = property(fget=get_GetDisplayText)

		def get_GetHighImage(self):
			return self.__highlight_img

		GetHighImage = property(fget=get_GetHighImage)

		def get_GetNormImage(self):
			return self.__norm_img

		GetNormImage = property(fget=get_GetNormImage)

		def __init__(self, type, index, display_text, highlight_img, norm_img):
			self.__type = type
			self.__index = index
			self.__display_text = display_text
			self.__highlight_img = highlight_img
			self.__norm_img = norm_img

	def __init__(self, type, index, display_text, highlight_img, norm_img):
		self.__type = type
		self.__index = index
		self.__display_text = display_text
		self.__highlight_img = highlight_img
		self.__norm_img = norm_img

	# initialize outputs
	# initialize inputs
	# takes a label to tag, the type og tag, the index for the switcher matrix port, and the text to be displayed by default
	def InitializeLabel(self, label, type, index, displat_text, highlight_img):
		if type == LabelType.OUTPUT:
			tag = LabelTag(type, index, displat_text, highlight_img, label.Image)
			label.Tag = tag
			label.MouseClick += self._output_MouseClick
			outputs.Add(label)
			# store original output properties
			orig_outputs.Add(label.Image)
		elif type == LabelType.INPUT:
			tag = LabelTag(type, index, displat_text, highlight_img, label.Image)
			label.Tag = tag
			label.MouseDown += self._input_MouseDown
			label.MouseLeave += self._input_MouseLeave
			label.MouseHover += self._input_MouseHover
			label.MouseMove += self._input_MouseMove
			label.MouseUp += self._input_MouseUp
		elif type == LabelType.OTHER:
			tag = LabelTag(type, -1, displat_text, highlight_img, label.Image)
			label.Tag = tag
		else:
			pass

	# ***********************************************************
	# * Source to Display Functions
	# * *********************************************************
	def input_MouseDown(self, sender, e):
		if e.Button == MouseButtons.Left:
			# recheck connection
			self.InitializeConnection()
			cur_input = sender
			cur_input.BringToFront()
			isDragged = True
			ptStartPosition = cur_input.PointToScreen(Point(e.X, e.Y))
			if setHomePosition:
				setHomePosition = False
				ptHome = cur_input.Location
			ptOffset = Point()
			ptOffset.X = cur_input.Location.X - ptStartPosition.X
			ptOffset.Y = cur_input.Location.Y - ptStartPosition.Y
		else:
			isDragged = False

	def input_MouseMove(self, sender, e):
		if isDragged:
			cur_input = sender
			newPoint = cur_input.PointToScreen(Point(e.X, e.Y))
			newPoint.Offset(ptOffset)
			cur_input.Location = newPoint

	def input_MouseUp(self, sender, e):
		cur_input = sender
		cur_out = 0
		while cur_out < outputs.Count:
			if outputs[cur_out].Bounds.IntersectsWith(cur_input.Bounds):
				outTag = outputs[cur_out].Tag
				inTag = cur_input.Tag
				# laptop specific
				#if (outputs[cur_out] == laptop)
				#{
				#    if (!connected)
				#    {
				#        MessageBox.Show("No Switcher Detected! Please Contact CITRIS\n tech lab: (831)502-7399", "Error", MessageBoxButtons.OK);
				#        this.Close();
				#        return;
				#    }
				#    char[] buffer = new char[18];
				#    serialPort1.WriteTimeout = 500;
				#    serialPort1.DiscardOutBuffer();
				#    serialPort1.DiscardInBuffer();
				#    serialPort1.Write("ActiveSource ?;");
				#    serialPort1.Read(buffer, 0, 17);
				#    if (new String(buffer) == "ActiveSource 0001")
				#        SendCommand(String.Format("Output0{1} 02;", outTag.GetIndex).Trim());
				#    else
				#        SendCommand(String.Format("Output0{1} 0{0};", inTag.GetIndex, outTag.GetIndex).Trim());
				#}
				#else
				# Send input switch command to SB
				self.SendCommand(String.Format("SBI0{0}O0{1}", inTag.GetIndex, outTag.GetIndex).Trim()) #///////////////////////////////////////////////////////////
				# change outputs display
				outputs[cur_out].Image = inTag.GetNormImage
				outputs[cur_out].TextAlign = ContentAlignment.BottomCenter
				outputs[cur_out].Text = inTag.GetDisplayText
				# easter egg check
				if cur_input == polycom_in and outputs[cur_out] == polycom_out:
					key.Visible = True
				break
			cur_out += 1
		#reset button position
		isDragged = False
		setHomePosition = True
		cur_input.Location = ptHome

	def input_MouseHover(self, sender, e):
		cur_input = sender
		cur_tag = cur_input.Tag
		cur_input.Image = cur_tag.GetHighImage
		cur_input.Tag = cur_tag

	def input_MouseLeave(self, sender, e):
		cur_input = sender
		cur_tag = cur_input.Tag
		cur_input.Image = cur_tag.GetNormImage
		cur_input.Tag = cur_tag

	def output_MouseClick(self, sender, e):
		cur_output = sender
		cur_tag = cur_output.Tag
		if cur_output == polycom_out and cur_output.Image == polycom_in.Image:
			key.Visible = False
		# Send switch command to SB
		self.SendCommand(String.Format("SBI0{0}O00", cur_tag.GetIndex).Trim()) #/////////////////////////////////////////////////////////
		cur_output.Image = cur_tag.GetNormImage
		cur_output.TextAlign = ContentAlignment.MiddleCenter
		cur_output.Text = "No Source"

	# turn off all ShinyBow outputs
	def offOutputs_Click(self, sender, e):
		# Send input switch command to SB
		self.SendCommand(String.Format("SBALLRST").Trim()) #//////////////////////////////////////////////////////////////////////////////
		cur_out = 0
		while cur_out < outputs.Count:
			outputs[cur_out].Image = orig_outputs[cur_out]
			outputs[cur_out].TextAlign = ContentAlignment.MiddleCenter
			outputs[cur_out].Text = "No Source"
			cur_out += 1

	# ***********************************************************
	# * Shinybow Interface Functions
	# * *********************************************************
	# check to ports to see if shinybow is connected
	def InitializeConnection(self):
		ports = System.IO.Ports.SerialPort.GetPortNames()
		enumerator = ports.GetEnumerator()
		while enumerator.MoveNext():
			port = enumerator.Current
			buffer = Array.CreateInstance(Char, 8)
			serialPort1.PortName = port
			serialPort1.Open()
			if not serialPort1.IsOpen:
				continue
			serialPort1.WriteTimeout = 500
			serialPort1.DiscardOutBuffer()
			serialPort1.Write("Link ?;")
			serialPort1.DiscardInBuffer()
			try:
				serialPort1.Read(buffer, 0, 8)
			except System.TimeoutException, :
				serialPort1.Close()
				continue
			finally:
			serialPort1.Close()
			connected = True
			break

	# display a message if no ShinyBow is connected and exit
	def SendCommand(self, p): #//////////////////////////////////////////////////////////////////////////////////////////////////////
		if not connected:
			MessageBox.Show("No Switcher Detected! Please Contact CITRIS\n tech lab: (831)502-7399", "Error", MessageBoxButtons.OK)
			self.Close()
			return 
		serialPort1.WriteTimeout = 500
		serialPort1.Open()
		serialPort1.WriteLine(p)
		serialPort1.DiscardOutBuffer()
		serialPort1.Close()

	# ***********************************************************
	# * Help Button Functions
	# * *********************************************************
	def help_MouseClick(self, sender, e):
		can_see_help = not can_see_help
		if can_see_help:
			help.BorderStyle = BorderStyle.Fixed3D
			help.BackColor = Color.LightGray
		else:
			help.BorderStyle = BorderStyle.None
			help.BackColor = Color.Transparent
		help_instructions.Visible = can_see_help

	# ***********************************************************
	# * Easter Egg Functions
	# * *********************************************************
	def egg_MouseDown(self, sender, e):
		if e.Button == MouseButtons.Left:
			cur_input = sender
			cur_input.BringToFront()
			isDragged = True
			ptStartPosition = cur_input.PointToScreen(Point(e.X, e.Y))
			if setHomePosition:
				setHomePosition = False
				ptHome = cur_input.Location
			ptOffset = Point()
			ptOffset.X = cur_input.Location.X - ptStartPosition.X
			ptOffset.Y = cur_input.Location.Y - ptStartPosition.Y
		else:
			isDragged = False

	def egg_MouseMove(self, sender, e):
		if isDragged:
			cur_input = sender
			newPoint = cur_input.PointToScreen(Point(e.X, e.Y))
			newPoint.Offset(ptOffset)
			cur_input.Location = newPoint

	def egg_MouseUp(self, sender, e):
		cur_input = sender
		#reset button position
		isDragged = False
		setHomePosition = True
		cur_input.Location = ptHome