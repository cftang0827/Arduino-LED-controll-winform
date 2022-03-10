using System.IO.Ports;

namespace arduino_led_controller
{
    public partial class MainForm : Form
    {
        private SerialPort? _serialPort;
        public MainForm()
        {
            InitializeComponent();
            this.printLog("Welcome to LED app :)");

            // Check serial port
            string[] ports = SerialPort.GetPortNames();
            foreach(string port in ports)
            {
                this.serialComboBox.Items.Add(port);
            }

        }

        private void printLog(String str)
        {
            this.logTextBox.Text += (str + "\n");
        }

        private void baudComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (baudComboBox.SelectedIndex != -1 &&¡@serialComboBox.SelectedIndex != -1)
            {
                this.connectBtn.Enabled = true;
            }
        }

        private void blinkBtn_Click(object sender, EventArgs e)
        {
            if(this._serialPort != null)
            {
                this._serialPort.Write(this.timeComboBox.Text);
            }
            this.printLog("Start blink with second: " + this.timeComboBox.Text);

        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            this.printLog("Connect to " + this.serialComboBox.Text + " Port with Baud rate " + this.baudComboBox.Text);
            this._serialPort = new SerialPort();
            this._serialPort.PortName = this.serialComboBox.Text;
            this._serialPort.BaudRate = Int32.Parse(this.baudComboBox.Text);

            this._serialPort.Open();
            this.printLog("Connect ok!");
            this.disconnectBtn.Enabled = true;
            this.connectBtn.Enabled = false;
            this.blinkBtn.Enabled = true;
            this.stopBtn.Enabled = true;
        }

        private void serialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (baudComboBox.SelectedIndex != -1 && serialComboBox.SelectedIndex != -1)
            {
                this.connectBtn.Enabled = true;
            }
        }

        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            if (this._serialPort != null)
            {
                this._serialPort.Close();
            }
            this.printLog("Disconnect ok!");
            this.connectBtn.Enabled = true;
            this.blinkBtn.Enabled = false;
            this.stopBtn.Enabled = false;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (this._serialPort != null)
            {
                this._serialPort.Write("#");
            }

            this.printLog("Stop blinking");
        }

        private void clearlogBtn_Click(object sender, EventArgs e)
        {
            this.logTextBox.Text = "";
        }
    }
}