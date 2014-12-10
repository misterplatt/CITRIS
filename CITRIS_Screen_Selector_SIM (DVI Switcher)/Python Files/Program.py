from System import *
from System.Collections.Generic import *
from System.Linq import *
from System.Windows.Forms import *

class Program(object):
	def Main():
		# <summary>
		# The main entry point for the application.
		# </summary>
		Application.EnableVisualStyles()
		Application.SetCompatibleTextRenderingDefault(False)
		Application.Run(ScreenSelector())

	Main = staticmethod(Main)