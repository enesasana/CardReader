/*
 * The purpose of this program is to understand how to establish connection between a device
 * which is connected serially to a computer and a computer software. Also it is important to
 * understand how will be the queries that ask the reader status or reader data and get
 * response of those queries, and manage those responses by using String methods. Finally outputs
 * the Card ID that swiped in front of the RFID Card reader.
 *
 * The message protocol is structured for RS432 / RS485 interfaces.
 *
 * This program has completed approximately in five days, due to undesired circumstances.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace CardReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Program Variables Initalizing

        private static SerialPort _serialPort = new SerialPort();       // Creates a new Serial Communication Gate
        private string ComPortName;                                     // Port Name - Defined in Form class because program needs it on Setting BaudRate
        private string ReceivedTag = "";                                // Will be the CARD ID
        private ushort Crc, crc1, crc2;                                 // Checksum Control Variables
        private int BaudRate;                                           // BaudRate: 9600/19200
        private Thread thread { get; set; }                             // Used in AutoPolling
        private bool threadControl = false;                             // To check whether the AutoPoll thread is started or not
        private bool autoPollState = false;                             // To check whether the AutoPoll method is started or not

        #endregion

        #region Serial Port Configurations

        private void button_GetSerialPorts_Click(object sender, EventArgs e)
        {
            string[] ComPortNamesArr = null;                                   // Port Names are stored here
            ComPortNamesArr = SerialPort.GetPortNames();

            if (ComPortNamesArr.Length == 0)
            {
                MessageBox.Show("Make sure that port has a connection", "Connection State");
            }
            else
            {
                foreach (var name in SerialPort.GetPortNames())
                {
                    comboBoxGetPorts.Items.Add(name);
                }
                MessageBox.Show("Ports Added", "Port Names");
            }
        }

        private void comboBoxGetPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComPortName = comboBoxGetPorts.Text.ToString();
        }

        private void button_GetBaudRate_Click(object sender, EventArgs e)
        {
            int[] BaudRateArr = { 9600, 19200 };                            // BaudRates are stored here

            if (ComPortName == null)
            {
                MessageBox.Show("Please select a port firstly.", "Choose Port");
            }
            else
            {
                foreach (var rate in BaudRateArr)
                {
                    comboBox_SetBaudRate.Items.Add(rate);
                }
                MessageBox.Show("BaudRate values added", "BaudRate");
            }
        }

        private void comboBox_SetBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            BaudRate = int.Parse(comboBox_SetBaudRate.Text);
        }

        private void button_PortState_Click(object sender, EventArgs e)
        {
            if (button_PortState.Text == "Port Closed")
            {
                try
                {
                    _serialPort.PortName = ComPortName;
                    _serialPort.BaudRate = BaudRate;
                    _serialPort.DataBits = 8;
                    _serialPort.Parity = Parity.None;
                    _serialPort.StopBits = StopBits.One;
                    _serialPort.Open();
                    button_PortState.Text = "Port Opened";
                    progressBar1.Value += 100;
                }
                catch { MessageBox.Show("Port couldn't opened!", "Open Port Connection"); }
            }
            else if (button_PortState.Text == "Port Opened")
            {
                try
                {
                    _serialPort.Close();
                    button_PortState.Text = "Port Closed";
                    progressBar1.Value -= 100;
                }
                catch { MessageBox.Show("Port couldn't closed!", "Close Port Connection"); }
            }
        }

        #endregion

        #region Buttons & Actions

        private void poll_Click(object sender, EventArgs e)
        {
            if (button_PortState.Text == "Port Closed")
            {
                MessageBox.Show("Please open the port at the first place.", "Port State");
            }
            else
            {
                Display(Polling());                         // Takes the parameter as the return value of Polling Method
            }
        }

        private void getData_Click(object sender, EventArgs e)
        {
            if (button_PortState.Text == "Port Closed")
            {
                MessageBox.Show("Please open the port at the first place.", "Port State");
            }
            else
            {
                Display(GettingData());                     // Takes the parameter as the return value of Getting Data Method
            }
        }

        private void autoId_Click(object sender, EventArgs e)
        {
            if (button_PortState.Text == "Port Closed")
            {
                MessageBox.Show("Please open the port at the first place.", "Port State");
            }
            else
            {
                GettingData();
                Display(Polling());
            }
        }

        private void button1_autoPoll_Click(object sender, EventArgs e)
        {
            if (button_PortState.Text == "Port Closed")
            {
                MessageBox.Show("Please open the port at the first place.", "Port State");
            }
            else
            {
                thread = new Thread(new ThreadStart(AutoPoll));         // Creates a new thread to process the queries on it. Invokes the AutoPoll Method.
                thread.Start();
                threadControl = true;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            if (button_PortState.Text == "Port Closed")
            {
                MessageBox.Show("Please open the port at the first place.", "Port State");
            }
            else
            {
                CleaningBuffer();                                       // It is supposed to clear the Reader Data Buffer, but it doesn't working properly.
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (button_PortState.Text == "Port Closed")
            {
                MessageBox.Show("Port is closed.", "Port State", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (threadControl != false && autoPollState != false)
                {
                    thread.Abort();
                    autoPollState = false;
                    richTextBox1.Text += "\nAuto Polling Stopped." + "\n";
                }
                else
                {
                    MessageBox.Show("Auto Poll function is not running at the time!", "Stop");
                }
            }
        }

        private void clearText_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            textBox_GetID.Text = string.Empty;
        }

        #endregion

        #region Methods

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;                        // Prevents the Thread Collision
        }

        private string Polling()
        {
            byte[] pollArr = { 0xA0, 0x20, 0xFA };                          // Poll Query Array
            byte[] incomingPollArr = new byte[20];                          // Answer of the Poll Array
            _serialPort.Write(pollArr, 0, pollArr.Length);
            Thread.Sleep(250);
            _serialPort.Read(incomingPollArr, 0, 20);
            Thread.Sleep(250);

            return ByteToHexString(incomingPollArr);
        }

        private string GettingData()
        {
            byte[] incomingGetDataArr = new byte[20];                       // Answer of the GetData Array
            byte[] dataCrcArr = { 0xA0, 0x30, 0x63, 0x1, 0x81 };            // Crc Data Control Array
            Crc = Crc16.ComputeChecksum(dataCrcArr);
            crc1 = Convert.ToByte(Crc & 0xFF);                              // Parses returned value into a part of two bytes
            crc2 = Convert.ToByte(Crc >> 8);                                // Parses returned value into a part of two bytes

            // Data Query: Asks the Card Id.
            byte[] getDataMessage = { 0xA0, 0x30, 0x63, 0x1, 0x81, Convert.ToByte(crc1), Convert.ToByte(crc2), 0x03, 0xFA };
            _serialPort.Write(getDataMessage, 0, getDataMessage.Length);
            Thread.Sleep(250);
            _serialPort.Read(incomingGetDataArr, 0, 20);
            Thread.Sleep(250);

            return ByteToHexString(incomingGetDataArr);
        }

        private void CleaningBuffer()
        {
            byte[] clearCrcArr = { 0xA0, 0x30, 0x64, 0x01, 0x81 };
            Crc = Crc16.ComputeChecksum(clearCrcArr);
            crc1 = Convert.ToByte(Crc & 0xFF);
            crc2 = Convert.ToByte(Crc >> 8);

            byte[] clearDataArr = { 0xA0, 0x30, 0x64, 0x01, 0x81, Convert.ToByte(crc1), Convert.ToByte(crc2), 0x03, 0xFA };
            _serialPort.Write(clearDataArr, 0, clearDataArr.Length);
            Thread.Sleep(250);
        }

        private string ByteToHexString(byte[] incomingBytes)
        {
            string returnMessage = string.Empty;               // The incoming message from Card Reader
            foreach (var x in incomingBytes)
            {
                if (x != 0)
                {
                    returnMessage += x.ToString("X2");   // Converts Bytes to Hexadecimal Format
                }
                else { continue; }
            }
            return returnMessage;
        }

        private void AutoPoll()
        {
            autoPollState = true;
            while (Thread.CurrentThread.IsAlive)
            {
                if (Polling().Equals("A070FA"))
                {
                    if (GettingData().Equals("A0C0FA"))
                        Display(Polling());                     // Takes the parameter as the return value of Polling Method

                    else
                        richTextBox1.Text += "Get Data responded but answer is meaningless. Please put the card again OR clear the buffer" + "\n";
                }
                else richTextBox1.Text += "Poll responded but answer is meaningless. Clear the buffer." + "\n";
            }
        }

        private void Display(string pollMessage)
        {
            ReceivedTag = "";
            textBox_GetID.Clear();
            if (pollMessage.Equals("A070FA"))
            {
                richTextBox1.Text += "Poll Success\n";
                richTextBox1.Text += pollMessage + "\n";
            }
            else if (pollMessage.Length <= 18 && pollMessage.Contains("A070FA"))
            {
                richTextBox1.Text += "Poll Success\n";
                richTextBox1.Text += pollMessage.Substring(0, 6) + "\n";
            }
            else if (pollMessage.Equals("A070FA") == false && (pollMessage.Length >= 18 && pollMessage.Length < 26))
            {
                richTextBox1.Text += pollMessage + ": ";
                richTextBox1.Text += "Poll responded but it does not have the Card ID. Put the card again OR clear the buffer and try again.\n";
            }
            else if (pollMessage.Equals("A0C0FA"))
            {
                richTextBox1.Text += "GetData Success\n";
                richTextBox1.Text += pollMessage + "\n";
            }
            else if (pollMessage.Equals("A0C0FA") == false && (pollMessage.Length >= 18 && pollMessage.Length < 26))
            {
                richTextBox1.Text += pollMessage + ": ";
                richTextBox1.Text += "Please put the card first.\n";
            }
            else if (pollMessage.Length == 26)       // If the PollMessage has the ID Number of Card
            {
                CatchId(pollMessage);
            }
            else
            {
                richTextBox1.Text += "Methods worked but the message is not clear.\n" + pollMessage + " " + "\nPlease try again.\n";
            }

            richTextBox1.Text += ReceivedTag + "\n";
        }

        private void CatchId(string pollMessage)
        {
            int start = 10;
            for (var str = 0; str < 4; str++)
            {
                ReceivedTag += pollMessage.Substring(start, 2) + " ";
                start += 2;
            }
            start = 0;
            textBox_GetID.Text = ReceivedTag; // CARD ID
        }

        #endregion
    }

    #region CRC16 Class

    public static class Crc16
    {
        const ushort Polynomial = 0xA001;
        static readonly ushort[] table = new ushort[256];

        public static ushort ComputeChecksum(byte[] bytes)
        {
            ushort crc = 0;
            for (int i = 0; i < bytes.Length; ++i)
            {
                byte index = (byte)(crc ^ bytes[i]);
                crc = (ushort)((crc >> 8) ^ table[index]);
            }
            return crc;
        }

        static Crc16()
        {
            ushort value;
            ushort temp;
            for (ushort i = 0; i < table.Length; ++i)
            {
                value = 0;
                temp = i;
                for (byte j = 0; j < 8; ++j)
                {
                    if (((value ^ temp) & 0x0001) != 0)
                    {
                        value = (ushort)((value >> 1) ^ Polynomial);
                    }
                    else
                    {
                        value >>= 1;
                    }
                    temp >>= 1;
                }
                table[i] = value;
            }
        }
    }
    #endregion
}
