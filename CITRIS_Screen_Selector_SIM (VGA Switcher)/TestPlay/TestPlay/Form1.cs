using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Management;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScreenSelector
{
   

    public partial class ScreenSelector : Form
    {
        int currentOutput;
        bool connected;

        int outputTag;
        int inputTag;

        List<Button> inputs;
        List<Button> outputs;
        List<Button> others;

        public ScreenSelector()
        {
            currentOutput = 0;

            outputTag = 1;
            inputTag = 1;
            connected = false;
            inputs = new List<Button>();
            outputs = new List<Button>();
            others = new List<Button>();

            InitializeComponent();

            InitializeConnection();

            InitializeButton(TV2, ButtonType.OUTPUT);
            InitializeButton(TV1, ButtonType.OUTPUT);
            InitializeButton(Podium, ButtonType.OUTPUT);
            InitializeButton(presentation, ButtonType.OUTPUT);
            InitializeButton(recording, ButtonType.OUTPUT);

            InitializeButton(resPC1, ButtonType.INPUT);
            InitializeButton(resPC2, ButtonType.INPUT);
            InitializeButton(docCam, ButtonType.INPUT);
            InitializeButton(laptop, ButtonType.INPUT);
            InitializeButton(polycomOut, ButtonType.INPUT);

            InitializeButton(offOutputs, ButtonType.OTHER);
            offOutputs.Click += new EventHandler(offOutputs_Click);
        }

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

            //if (!connected)
            //    this.Close();
        }

        private void InitializeButton(Button button, ButtonType type)
        {
            ButtonTag tag;
            
            switch (type)
            {
                case ButtonType.OUTPUT:
                    tag = new ButtonTag(type, outputTag++);
                    button.Click += new EventHandler(Handle_Button);
                    button.Tag = tag;
                    outputs.Add(button);
                    break;
                case ButtonType.INPUT:
                    tag = new ButtonTag(type, inputTag++);
                    button.Click += new EventHandler(Handle_Button);
                    button.Tag = tag;
                    inputs.Add(button);
                    break;
                case ButtonType.OTHER:
                    tag = new ButtonTag(type, -1);
                    button.Tag = tag;
                    others.Add(button);
                    break;
                default:
                    break;
            }
        }

        private void Handle_Button(object sender, EventArgs e)
        {
            if (!(sender is Button))
                // Do something fancier here
                return;

            Button target = (Button)sender;

            if (!(target.Tag is ButtonTag))
                return;

            ButtonTag tag = (ButtonTag)target.Tag;

            if (tag.GetButtonType == ButtonType.INPUT)
            {
                target.DoDragDrop(tag.GetIndex, DragDropEffects.Copy | DragDropEffects.Move);
            }

        // if (tag.GetButtonType == ButtonType.INPUT)
        // {
        //     // Send input switch command to SB
        //     SendCommand(String.Format("Output0{1} 0{0};", tag.GetIndex, currentOutput).Trim());
        //
        //     // Hide the inputs
        //     foreach (Button b in inputs)
        //     {
        //         b.Visible = false;
        //     }
        // }
        // else if (tag.GetButtonType == ButtonType.OUTPUT)
        // {
        //     currentOutput = tag.GetIndex;
        //
        //     // Show the inputs
        //     foreach (Button b in inputs)
        //     {
        //         b.Visible = true;
        //     }
        // }
        }

        // handle buttone drop
        private void OutputButton_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            MessageBox.Show("Dropped It Like It's Hot!", "Made it", MessageBoxButtons.OK);
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        // turn off all ShinyBow outputs
        private void offOutputs_Click(object sender, EventArgs e)
        {
            SendCommand(String.Format("Outputall 00;").Trim());
        }

        // display a message if no ShinyBow is connected and exit
        private void SendCommand(string p)
        {
            if (!connected)
            {
                MessageBox.Show("No Switcher Detected!", "Error", MessageBoxButtons.OK);

                this.Close();
                
                return;
            }
            serialPort1.WriteTimeout = 500;
            serialPort1.Open();
            serialPort1.WriteLine(p);
            serialPort1.DiscardOutBuffer();
            serialPort1.Close();
        }

        private void Handle_Response(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void laptop_Click(object sender, EventArgs e)
        {

        }

        //private List<USBDeviceInfo> GetUSBDevices()
        //{
        //    List<USBDeviceInfo> devices = new List<USBDeviceInfo>();

        //    ManagementObjectCollection collection;
        //    using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_USBHub"))
        //        collection = searcher.Get();

        //    foreach (var device in collection)
        //    {
        //        devices.Add(new USBDeviceInfo(
        //        (string)device.GetPropertyValue("DeviceID"),
        //        (string)device.GetPropertyValue("PNPDeviceID"),
        //        (string)device.GetPropertyValue("Description")
        //        ));
        //    }

        //    collection.Dispose();
        //    return devices;
        //}
    }

    public enum ButtonType { INPUT, OUTPUT, OTHER }

    public class ButtonTag
    {
        private ButtonType _type;
        private int _index;

        public ButtonType GetButtonType { get { return _type; } }
        public int GetIndex { get { return _index; } }

        public ButtonTag(ButtonType type, int index)
        {
            _type = type;
            _index = index;
        }
    }

   // class USBDeviceInfo
   // {
   //     public USBDeviceInfo(string deviceID, string pnpDeviceID, string description)
   //     {
   //       this.DeviceID = deviceID;
   //       this.PnpDeviceID = pnpDeviceID;
   //       this.Description = description;
   //     }
   //     public string DeviceID { get; private set; }
   //     public string PnpDeviceID { get; private set; }
   //     public string Description { get; private set; }
   //}
}
