using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;

namespace CITRIS_Screen_Selector_Drag_and_Drop
{
    public partial class ScreenSelector : Form
    {
        bool isDragged = false;
        bool setHomePosition = true;
        bool connected;
        bool can_see_help = false;
        Point ptOffset;
        Point ptHome;

        private const int SLEEPTIME = 300;
        private const int TURN_ON_CLICK = 2;
        private const int TURN_OFF_CLICK = 3;         //variables from old screen selector v6.0
        private bool powerState = true;

        private int[] currentScreenSet = { 7, 7, 7, 7 };/////

        //Functions used in webBrowser1_DocumentCompleted()
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        List<Label> outputs;
        List<Image> orig_outputs;
        public enum LabelType { INPUT, OUTPUT, OTHER }

        public class LabelTag
        {
            private LabelType _type;
            private int _index;
            private string _display_text;
            private Image _highlight_img;
            private Image _norm_img;

            public LabelType GetLabelType { get { return _type; } }
            public int GetIndex { get { return _index; } }
            public string GetDisplayText { get { return _display_text; } }
            public Image GetHighImage { get { return _highlight_img; } }
            public Image GetNormImage { get { return _norm_img; } }

            public LabelTag(LabelType type, int index, string display_text, Image highlight_img, Image norm_img)
            {
                _type = type;
                _index = index;
                _display_text = display_text;
                _highlight_img = highlight_img;
                _norm_img = norm_img;
            }
        }

        public ScreenSelector()
        {
            InitializeComponent();
            //InitializeConnection();

            outputs = new List<Label>();
            orig_outputs = new List<Image>();

            Image output_highlight = tv1_display.Image;

            Image laptop_highlight = Image.FromFile("ScreenSelector_Laptop-Highlight.png");
            Image doccam_highlight = Image.FromFile("ScreenSelector_DocCam-Highlight.png");
            //Image ploycom_highlight = Image.FromFile("ScreenSelector_PolyComm-Highlight.png"); //Not needed for SIM
            Image desktop1_highlight = Image.FromFile("ScreenSelector_Desktop1-Highlight.png");
            Image desktop2_highlight = Image.FromFile("ScreenSelector_Desktop2-Highlight.png");

            // initialize outputs
            InitializeLabel(tv1_display, LabelType.OUTPUT, 1, "No Output", output_highlight);
            InitializeLabel(tv2_display, LabelType.OUTPUT, 2, "No Output", output_highlight);
            InitializeLabel(podium, LabelType.OUTPUT, 3, "No Output", output_highlight);
            InitializeLabel(polycom_out, LabelType.OUTPUT, 4, "No Output", output_highlight);
            InitializeLabel(x_proj1, LabelType.OUTPUT, 1, "No Output", output_highlight);
            InitializeLabel(x_proj2, LabelType.OUTPUT, 2, "No Output", output_highlight);
            InitializeLabel(close_podium, LabelType.OUTPUT, 3, "No Output", output_highlight);
            InitializeLabel(x_proj3, LabelType.OUTPUT, 4, "No Output", output_highlight);
            

            // initialize inputs
            InitializeLabel(laptop, LabelType.INPUT, 3, "", laptop_highlight);
            InitializeLabel(desktop1, LabelType.INPUT, 4, "", desktop1_highlight);
            InitializeLabel(desktop2, LabelType.INPUT, 5, "", desktop2_highlight);
            InitializeLabel(polycom_in, LabelType.INPUT, 7, "", doccam_highlight);
            InitializeLabel(doccam, LabelType.INPUT, 8, "", doccam_highlight);

            

            alloff.BackColor = Color.Transparent;
          
            
        }

        // takes a label to tag, the type og tag, the index for the switcher matrix port, and the text to be displayed by default
        private void InitializeLabel(Label label, LabelType type, int index, string displat_text, Image highlight_img)
        {
            LabelTag tag;

            switch (type)
            {
                case LabelType.OUTPUT:
                    tag = new LabelTag(type, index, displat_text, highlight_img, label.Image);
                    label.Tag = tag;
                    label.MouseClick += new System.Windows.Forms.MouseEventHandler(this.output_MouseClick);
                    outputs.Add(label);

                    // store original output properties
                    orig_outputs.Add(label.Image);
                    break;
                case LabelType.INPUT:
                    tag = new LabelTag(type, index, displat_text, highlight_img, label.Image);
                    label.Tag = tag;
                    label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.input_MouseDown);
                    label.MouseLeave += new System.EventHandler(this.input_MouseLeave);
                    label.MouseHover += new System.EventHandler(this.input_MouseHover);
                    label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.input_MouseMove);
                    label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.input_MouseUp);
                    break;
                case LabelType.OTHER:
                    tag = new LabelTag(type, -1, displat_text, highlight_img, label.Image);
                    label.Tag = tag;
                    break;
                default:
                    break;
            }
        }


        /************************************************************
         * Source to Display Functions
         * **********************************************************/
        private void input_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            
          

            if (e.Button == MouseButtons.Left)
            {
                // recheck connection
                //InitializeConnection();

                Label cur_input = (Label)sender;
                cur_input.BringToFront();
                isDragged = true;
                Point ptStartPosition = cur_input.PointToScreen(new Point(e.X, e.Y));
                if (setHomePosition)
                {
                    setHomePosition = false;
                    ptHome = cur_input.Location;
                }

                ptOffset = new Point();
                ptOffset.X = cur_input.Location.X - ptStartPosition.X;
                ptOffset.Y = cur_input.Location.Y - ptStartPosition.Y;
            }
            else
                isDragged = false;
        }

        private void input_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragged)
            {
                Label cur_input = (Label)sender;
                Point newPoint = cur_input.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(ptOffset);

                cur_input.Location = newPoint;
            }
        }

        private void input_MouseUp(object sender, MouseEventArgs e)
        {
            Label cur_input = (Label)sender;
            for (int cur_out = 0; cur_out < outputs.Count; cur_out++)
            {
                if (outputs[cur_out].Bounds.IntersectsWith(cur_input.Bounds))
                {
                    LabelTag outTag = (LabelTag)outputs[cur_out].Tag;
                    LabelTag inTag = (LabelTag)cur_input.Tag;

                    // laptop specific
                    //if (outputs[cur_out] == laptop)
                    //{
                    //    if (!connected)
                    //    {
                    //        MessageBox.Show("No Switcher Detected! Please Contact CITRIS\n tech lab: (831)502-7399", "Error", MessageBoxButtons.OK);

                    //        this.Close();

                    //        return;
                    //    }

                    //    char[] buffer = new char[18];

                    //    serialPort1.WriteTimeout = 500;
                    //    serialPort1.DiscardOutBuffer();
                    //    serialPort1.DiscardInBuffer();
                    //    serialPort1.Write("ActiveSource ?;");

                    //    serialPort1.Read(buffer, 0, 17);
                    //    if (new String(buffer) == "ActiveSource 0001")
                    //        SendCommand(String.Format("Output0{1} 02;", outTag.GetIndex).Trim());
                    //    else
                    //        SendCommand(String.Format("Output0{1} 0{0};", inTag.GetIndex, outTag.GetIndex).Trim());
                    //}
                    //else
                        
                    // Send input switch command to SB (for VGA Version)
                    //SendCommand(String.Format("SBI0{0}O0{1}", inTag.GetIndex, outTag.GetIndex).Trim());  //VGA

                    //////////////////////////////////////////////////////////////////////////////
                    //                                                                          //
                    //                                                                          //
                    //      FOR DVI VERSION OF SHINYBOW, USE THE FOLLOWING COMMAND              //
                    //                                                                          //
                    //                                                                          //
                    //////////////////////////////////////////////////////////////////////////////
                    
                    // Send input switch command to SB (for DVI Version)
                    SendCommand(String.Format("Output0{1} 0{0};", inTag.GetIndex, outTag.GetIndex).Trim()); //DVI
                  
                     
                    // change outputs display
                    outputs[cur_out].Image = inTag.GetNormImage;
                    outputs[cur_out].TextAlign = ContentAlignment.BottomCenter;
                    outputs[cur_out].Text = (String)inTag.GetDisplayText;

                    // only display red x if input is present
                    if (outputs[cur_out] == tv1_display)
                    {
                        x_proj1.Visible = true;
                    }
                    else if (outputs[cur_out] == tv2_display)
                    {
                        x_proj2.Visible = true;
                    }
                    else if (outputs[cur_out] == podium)
                    {
                        close_podium.Visible = true;
                    }
                    else if (outputs[cur_out] == polycom_out)
                    {
                        x_proj3.Visible = true;
                    } //////////////////////////////////////////////////////////////////////

                    // easter egg check
                    if (cur_input == polycom_in && outputs[cur_out] == polycom_out)
                        key.Visible = true;

                    break;


                }
            }

            //reset button position
            isDragged = false;
            setHomePosition = true;
            cur_input.Location = ptHome;
        }

        private void input_MouseHover(object sender, EventArgs e)
        {
            Label cur_input = (Label)sender;
            LabelTag cur_tag = (LabelTag)cur_input.Tag;

            cur_input.Image = cur_tag.GetHighImage;
            cur_input.Tag = cur_tag;
            
           
        }

        private void input_MouseLeave(object sender, EventArgs e)
        {
            Label cur_input = (Label)sender;
            LabelTag cur_tag = (LabelTag)cur_input.Tag;

            cur_input.Image = cur_tag.GetNormImage;
            cur_input.Tag = cur_tag;
            
            
        }


        private void output_MouseClick(object sender, EventArgs e)
        {
            Label cur_output = (Label)sender;
            LabelTag cur_tag = (LabelTag)cur_output.Tag;

            if (cur_output == polycom_out && cur_output.Image == polycom_in.Image)
                key.Visible = false;

            // Send switch command to SB
            //SendCommand(String.Format("SBI0{0}O00", cur_tag.GetIndex).Trim());    //VGA
            SendCommand(String.Format("Output0{0} 00;", cur_tag.GetIndex).Trim());  //DVI

            // Check display and reset text accordingly
            if (cur_output == polycom_out || cur_output == x_proj3)
            {
                polycom_out.Image = Image.FromFile("tvs_screen.PNG");
                polycom_out.TextAlign = ContentAlignment.MiddleCenter;
                polycom_out.Text = "Projector 3";
                x_proj3.Visible = false;
            }
            else if (cur_output == tv1_display || cur_output == x_proj1)
            {
                tv1_display.Image = Image.FromFile("tvs_screen.PNG");
                tv1_display.TextAlign = ContentAlignment.MiddleCenter;
                tv1_display.Text = "Projector 1";
                x_proj1.Visible = false;
            }

            else if (cur_output == tv2_display || cur_output == x_proj2)
            {
                tv2_display.Image = Image.FromFile("tvs_screen.PNG");
                tv2_display.TextAlign = ContentAlignment.MiddleCenter;
                tv2_display.Text = "Projector 2/Large";
                x_proj2.Visible = false;
            }
            else if (cur_output == podium || cur_output == close_podium)
            {
                podium.Image = Image.FromFile("podium_screen.PNG");
                podium.TextAlign = ContentAlignment.MiddleCenter;
                podium.Text = "Podium";
                close_podium.Visible = false;
            }

           /* cur_output.Image = cur_tag.GetNormImage;
              cur_output.TextAlign = ContentAlignment.MiddleCenter;
              cur_output.Text = "No Source"; */
        }

        // turn off all ShinyBow outputs
        private void offOutputs_Click(object sender, MouseEventArgs e)
        {
            // Send input switch command to SB
            // SendCommand(String.Format("SBALLRST").Trim());   //VGA
            SendCommand(String.Format("Outputall 00;").Trim()); //DVI
            // Resets all the text on the sources correctly.  
            int cur_out = 0;
            
            outputs[cur_out].Image = orig_outputs[cur_out];                 // clears output
            outputs[cur_out].TextAlign = ContentAlignment.MiddleCenter;     // resets image
            outputs[cur_out].Text = "Projector 1";                          // resets text
            x_proj1.Visible = false;                                        // turns off red X
            cur_out++;                                                      // increment to proceed to next display

            outputs[cur_out].Image = orig_outputs[cur_out];
            outputs[cur_out].TextAlign = ContentAlignment.MiddleCenter;
            outputs[cur_out].Text = "Projector 2/Large";
            x_proj2.Visible = false;
            cur_out++;

            outputs[cur_out].Image = orig_outputs[cur_out];
            outputs[cur_out].TextAlign = ContentAlignment.MiddleCenter;
            outputs[cur_out].Text = "Podium";
            close_podium.Visible = false;
            cur_out++;
            
            outputs[cur_out].Image = orig_outputs[cur_out];
            outputs[cur_out].TextAlign = ContentAlignment.MiddleCenter;
            outputs[cur_out].Text = "Projector 3";
            x_proj3.Visible = false;
        }


        /************************************************************
         * Shinybow Interface Functions
         * **********************************************************/
        // check to ports to see if shinybow is connected
        private void InitializeConnection()
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                char[] buffer = new char[8];

                serialPort1.PortName = port;
                serialPort1.Open();

                if (!serialPort1.IsOpen) continue;

                serialPort1.WriteTimeout = 500;
                serialPort1.DiscardOutBuffer();
                serialPort1.Write("Link ?;");

                serialPort1.DiscardInBuffer();

                try
                {
                    serialPort1.Read(buffer, 0, 8);
                }
                catch (System.TimeoutException)
                {
                    serialPort1.Close();
                    continue;
                }

                serialPort1.Close();
                connected = true;
                break;
            }
        }

        // display a message if no ShinyBow is connected and exit
        private void SendCommand(string p)  /////////////////////////////////////////////////////////////////////////////////////////////////////////
        {
        //This checks that the switcher is connected, currently testing without it
        /*if (!connected)
            {
               MessageBox.Show("No Switcher Detected! Please Contact CITRIS\n tech lab: (831)502-7399", "Error", MessageBoxButtons.OK);

               this.Close();

               return;
            }*/
            serialPort1.WriteTimeout = 500;
            serialPort1.Open();
            serialPort1.WriteLine(p);
            serialPort1.DiscardOutBuffer();
            serialPort1.Close();
        }


        /************************************************************
         * Help Button Functions
         * **********************************************************/
        private void help_MouseClick(object sender, MouseEventArgs e)
        {
            can_see_help = !can_see_help;
            if (can_see_help)
            {
                help.BorderStyle = BorderStyle.Fixed3D;
                help.BackColor = Color.LightGray;
            }
            else
            {
                help.BorderStyle = BorderStyle.None;
                help.BackColor = Color.Transparent;
            }

            help_instructions.Visible = can_see_help;
        }


        /************************************************************
         * Easter Egg Functions
         * **********************************************************/
        private void egg_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox cur_input = (PictureBox)sender;
                cur_input.BringToFront();
                isDragged = true;
                Point ptStartPosition = cur_input.PointToScreen(new Point(e.X, e.Y));
                if (setHomePosition)
                {
                    setHomePosition = false;
                    ptHome = cur_input.Location;
                }

                ptOffset = new Point();
                ptOffset.X = cur_input.Location.X - ptStartPosition.X;
                ptOffset.Y = cur_input.Location.Y - ptStartPosition.Y;
            }
            else
                isDragged = false;
        }

        private void egg_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragged)
            {
                PictureBox cur_input = (PictureBox)sender;
                Point newPoint = cur_input.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(ptOffset);

                cur_input.Location = newPoint;
            }
        }

        private void egg_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox cur_input = (PictureBox)sender;


            //reset button position
            isDragged = false;
            setHomePosition = true;
            cur_input.Location = ptHome;
        }

        
        private int determineState()
        {
            int state = 0;
            if (PROJ1.Enabled == false)
                state = 1;
            else if (PROJ2.Enabled == false)
                state = 2;
            else if (PROJ3.Enabled == false)
                state = 3;
            return state;
        }

        private void resetProjectorButton(Button pressed)
        {
            PROJ1.Enabled = true;
            PROJ2.Enabled = true;
            PROJ3.Enabled = true;
            pressed.Enabled = false;
        }
        
        
        private void PROJ1_Click(object sender, EventArgs e)
        {
            resetProjectorButton(PROJ1);
        }

        private void PROJ2_Click(object sender, EventArgs e)
        {
            resetProjectorButton(PROJ2);
        }

        private void PROJ3_Click(object sender, EventArgs e)
        {
            resetProjectorButton(PROJ3);
        }
        private void TURNON_Click(object sender, EventArgs e)
        {
            powerState = true;
            processBrowserChange(determineState());
        }

        private void TURNOFF_Click(object sender, EventArgs e)
        {
            powerState = false;
            processBrowserChange(determineState());
        }

        private void processBrowserChange(int state)
        {
            int selectedProjector = determineState();
            switch (selectedProjector)
            {
                case 1:
                    webBrowser1.Navigate("http://simproj1.soe.ucsc.edu/cgi-bin/webconf.exe?page=13");
                    break;
                case 2:
                    webBrowser1.Navigate("http://simproj2.soe.ucsc.edu/cgi-bin/webconf.exe?page=13");
                    break;
                case 3:
                    webBrowser1.Navigate("http://simproj3.soe.ucsc.edu/cgi-bin/webconf.exe?page=13");
                    break;
            }
        }

        //Determines powerState, then clicks the power button twice if the proj is on, 3 times if proj is off
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Thread.Sleep(SLEEPTIME);
            int increment;
            if (powerState)
                increment = 2;
            else
                increment = 3;

            //Clicks the power button "increment" times
            for (int a = 0; a < increment; a++) // 2 clicks if on, 3 if off
            {
                int Xcoor1 = 30; // X coordinate of the click
                int Ycoor1 = 55; // Y coordinate of the click
                IntPtr handle = webBrowser1.Handle;
                StringBuilder className = new StringBuilder(100);
                while (className.ToString() != "Internet Explorer_Server") // The class control for the browser
                {
                    handle = GetWindow(handle, 5);
                    GetClassName(handle, className, className.Capacity);
                }
                IntPtr lParam = (IntPtr)((Ycoor1 << 16) | Xcoor1); // The coordinates
                IntPtr wParam = IntPtr.Zero; // Additional parameters for the click (e.g. Ctrl)
                const uint downCode = 0x201; // Left click down code
                const uint upCode = 0x202; // Left click up code
                SendMessage(handle, downCode, wParam, lParam); // Mouse button down
                SendMessage(handle, upCode, wParam, lParam); // Mouse button up
            }

            /* Cancels any pending navigation and stops any dynamic page elements, such as background sounds and animations. */
            webBrowser1.Stop(); // Stops the program on the first registered click 
        }

        private void alloff_Click(object sender, EventArgs e)
        {

        }

        private void podium_Click(object sender, EventArgs e)
        {

        }

       
       
    }
}