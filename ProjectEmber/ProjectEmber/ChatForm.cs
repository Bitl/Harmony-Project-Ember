using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ProjectEmber
{
    //https://www.dreamincode.net/forums/topic/231058-peer-to-peer-chat-advanced/
    public partial class ChatForm : Form
    {
        delegate void AddMessage(string message);
        string userName;
        UdpClient receivingClient;
        UdpClient sendingClient;
        Thread receivingThread;

        public ChatForm()
        {
            InitializeComponent();
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            Hide();

            using (Login loginForm = new Login())
            {
                loginForm.ShowDialog();

                if (GlobalVars.Name == "")
                {
                    Close();
                }
                else
                {
                    userName = GlobalVars.Name;
                    Show();
                }
            }

            sendButton.Focus();
            InitializeSender();
            InitializeReceiver();
        }

        private void InitializeSender()
        {
            sendingClient = new UdpClient(GlobalVars.broadcastAddress, GlobalVars.port);
            sendingClient.EnableBroadcast = true;
        }

        private void InitializeReceiver()
        {
            receivingClient = new UdpClient(GlobalVars.port);
            ThreadStart start = new ThreadStart(Receiver);
            receivingThread = new Thread(start);
            receivingThread.IsBackground = true;
            receivingThread.Start();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            messageTypeBox.Text = messageTypeBox.Text.TrimEnd();
            if (!string.IsNullOrEmpty(messageTypeBox.Text))
            {
                string toSend = userName + ": " + messageTypeBox.Text;
                byte[] data = Encoding.ASCII.GetBytes(toSend);
                sendingClient.Send(data, data.Length);
                messageTypeBox.Text = "";
            }
            messageTypeBox.Focus();
        }

        private void Receiver()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, GlobalVars.port);
            AddMessage messageDelegate = MessageReceived;
            while (true)
            {
                byte[] data = receivingClient.Receive(ref endPoint);
                string message = Encoding.ASCII.GetString(data);
                Invoke(messageDelegate, message);
            }
        }

        private void MessageReceived(string message)
        {
            messagePanel.Text += message + "\n";
        }
    }
}
