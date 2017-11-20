using System;
using System.Threading;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Net;
using System.Text;

namespace HexDeploy
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //Plans.jpeg
            msgTextbox.AppendText("Me:" + sendingTextbox.Text + GetTimeStamp(DateTime.UtcNow) + "\n");

            ///msgTextbox.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Starts the thread here, because a public thread is mildly messy.
            Thread thread0 = new Thread(packettest);
            thread0.Start();
        }
        private void packettest()
        {
            //Tests connection to server/client by sending a test packet.
            Socket test = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            try
            {
                IPAddress serverAddr = IPAddress.Parse(IPtextbox.Text);
                try
                {
                    //gross bit of code here. On the fly conversion.
                    int new0 = Convert.ToInt32(PortTextbox.Text);
                    //sets the endpoint with user input from a textbox
                    IPEndPoint ep0 = new IPEndPoint(serverAddr, new0);
                    //test message
                    string text = "testing!";
                    //putting together the buffer for sending the message.
                    byte[] buffer0 = Encoding.ASCII.GetBytes(text);
                    //actually sending the buffer.
                    test.SendTo(buffer0, ep0);
                }
                catch
                {
                    MessageBox.Show("Please input a valid port number!");
                }
            }
            catch
            {
                MessageBox.Show("Please input a valid IP address!");
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public string GetTimeStamp(DateTime value)
        {
            return value.ToString("{" + "yyyy" + "/" + "MM" + "/" + "dd" + "HH:mm:ss" + "}");
        }

      

        private void sendingTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {

            
        }

        private void sendbutton_KeyDown(object sender, KeyEventArgs e)
        {
            msgTextbox.AppendText("\n" + sendingTextbox.Text + "\n" + GetTimeStamp(DateTime.UtcNow));
            sendingTextbox.Text = "";
        }
    }
}
