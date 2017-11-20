using System;
using System.Threading;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Net;
using System.Text;

namespace HexDeploy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        protected override void WndProc(ref Message m)
        {
            //Makes a grabbable window. Removing if intrusive to user experience.
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        //constants
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void button1_Click(object sender, EventArgs e)
        {
            //closes the form, although it's one of the worst ways to do it.
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Plans.jpeg
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
                IPAddress serverAddr = IPAddress.Parse(textBox5.Text);
                try
                {
                    //gross bit of code here. On the fly conversion.
                    int new0 = Convert.ToInt32(textBox3.Text);
                    //sets the endpoint with user input from a textbox
                    IPEndPoint ep0 = new IPEndPoint(serverAddr, new0);
                    //test message
                    string text = "testing!";
                    //putting together the buffer for sending the message.
                    byte[] buffer0 = Encoding.ASCII.GetBytes(text );
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
    }
}
