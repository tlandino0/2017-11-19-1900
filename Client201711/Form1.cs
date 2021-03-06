﻿using System;
using System.Threading;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Net;
using System.Collections;
using System.Text;

namespace HexDeploy
{
    
    public partial class mainform : Form
    {
        Thread connectThread;
        TcpClient clsock;
        NetworkStream servStream;
        string rd;

        public bool keydown = false;
        public string handlenm = string.Empty;
        public string password;

        public static string Base64Encode(string plain)
        {
            var plainbyte = System.Text.Encoding.ASCII.GetBytes(plain);
            return System.Convert.ToBase64String(plainbyte);
        }
     
        public mainform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void button3_MouseClick(object sender, EventArgs e)
        {
           
            byte[] outS = Encoding.ASCII.GetBytes(sendingTextbox.Text + "$");
            servStream.Write(outS, 0, outS.Length);
            //msgTextbox.AppendText(GetTimeStamp(DateTime.UtcNow) + "Me:" + sendingTextbox.Text + "\n");
            sendingTextbox.Text = "";
            servStream.Flush();
            if (!sendingTextbox.Focused)
            {
                sendingTextbox.Focus();
            }


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
        public string GetTimeStamp(DateTime value)
        {
            //basic ISO 8601 timestamp
            return value.ToString(" {" + "yyyy" + "/" + "MM" + "/" + "dd " + "HH:mm:ss" + "}");
        }
        private void sendingTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !keydown)
            {
                keydown = true;
                button3_MouseClick(this, new EventArgs());

                e.Handled = true;

                e.SuppressKeyPress = true;
                //msgTextbox.AppendText("\n" + sendingTextbox.Text + "\n" + GetTimeStamp(DateTime.UtcNow));
                //sendbutton.KeyDown -= new KeyEventHandler(sendbutton_KeyDown);
            }
        }
        private void sendingTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                keydown = false;
            }
        }
        private void sendbutton_MouseClick(object sender, MouseEventArgs e)
        {
            byte[] outS = Encoding.ASCII.GetBytes(sendingTextbox.Text + "$");
            try
            {
                servStream.Write(outS, 0, outS.Length);
                sendingTextbox.Text = "";
                servStream.Flush();

            }
            catch
            {
                MessageBox.Show("Server failed to connect. ");
                Disconnect();
            }
            
            
        }

        private void HndlButton_Click(object sender, EventArgs e)
        {
            handlenm = Convert.ToString(handleTextbox.Text);
            connectButton.Enabled = true;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            Random temprand0 = new Random();
            int temp0 = temprand0.Next(0, 32767);
            msgTextbox.AppendText("Connecting... \n");
            messaging();
            handlenm = handlenm + temp0;
            sendbutton.Enabled = true;
            sendingTextbox.Enabled = true;
            string ip = "";
            byte[] outS = null;
            int port = 0;
            servStream = default(NetworkStream);
            clsock = new TcpClient();

            try
            {
                ip = Convert.ToString(IPtextbox.Text);
                port = Convert.ToInt32(PortTextbox.Text);
                try
                {
                    clsock.Connect(ip, port);
                    servStream = clsock.GetStream();
                }
                catch
                {
                    MessageBox.Show("Connection to server timed out. Abort.");
                }
            }
            catch
            {
                MessageBox.Show("Please input usable values!");
            }

            connectThread = new Thread(getMsg);
             
            try
            {
                outS = Encoding.ASCII.GetBytes(handlenm + "$");
                servStream.Write(outS, 0, outS.Length);
                servStream.Flush();
                try
                {
                    connectThread.Start();
                }
                catch
                {
                    MessageBox.Show("Server failed to connect. ");
                    Disconnect();
                }
            }
            catch
            {
                MessageBox.Show("Server failed to connect. ");
                Disconnect();
            }
            
            dcButton.Enabled = true;
            
            

        }
        private void getMsg()
        {
            
            while (true)
            {
                int buffersz = 0;
                byte[] ins = new byte[10025];
                string dataret = "";
                try
                {
                    servStream = clsock.GetStream();
                    try
                    {
                        buffersz = clsock.ReceiveBufferSize;
                        servStream.Read(ins, 0, ins.Length);
                        dataret = Encoding.ASCII.GetString(ins);
                        rd = "" + dataret;
                    }
                    catch
                    {

                    }
                    messaging();
                }
                catch
                {
                    connectThread.Abort();
                    MessageBox.Show("Server caused connection abort.");
                }
            }
        }
        private void messaging()
        {
            if (this.InvokeRequired)
            {
                try
                {
                    this.Invoke(new MethodInvoker(messaging));
                }
                catch
                {

                }
                
            }
            else
            {
                try
                {
                    msgTextbox.AppendText("\n " + rd);
                }
                catch
                {

                }
                
            }
        }

        private void dcButton_Click(object sender, EventArgs e)
        {
            using (TcpClient clsock = new TcpClient())
            {
                connectButton.Enabled = true;
                LingerOption lingerOption = new LingerOption(true, 0);


                
                Disconnect();

            }
        }
        private void Disconnect()
        {
            
            byte[] outS = Encoding.ASCII.GetBytes("3DF38FC9" + "$");
            try
            {
                servStream.Write(outS, 0, outS.Length);
                servStream.Flush();
            }
            catch
            {

            }
            try
            {
                clsock.Close();
            }
            catch
            {

            }
            try
            {
                servStream.Close();
            }
            catch
            {

            }
            //servStream.Dispose();
            connectThread.Abort();


        }
    }
}
