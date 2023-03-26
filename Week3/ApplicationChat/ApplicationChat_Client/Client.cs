using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace ApplicationChat_Client
{
    public partial class Client : Form
    {
        private Socket client;
        
        public Client()
        {
            InitializeComponent();
            
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                string message = EnterMessage.Text;
                byte[] data = Encoding.UTF8.GetBytes(message);
                if (client != null)
                {
                    client.SendTo(data, new IPEndPoint(IPAddress.Parse("255.255.255.255"), 8080));
                    ListMessage.Items.Add("Client: " + message);
                    EnterMessage.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {
            client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            client.Bind(new IPEndPoint(IPAddress.Any, 8081));

            Thread receiveThread = new Thread(new ThreadStart(ReceiveMessage));
            receiveThread.Start();
        }
        private void ReceiveMessage()
        {
            EndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);

            while (true)
            {
                try
                {
                    byte[] data = new byte[1024];
                    int recv = client.ReceiveFrom(data, ref remoteEP);
                    string message = Encoding.UTF8.GetString(data, 0, recv);
                    string IP = ((IPEndPoint)remoteEP).Address.ToString();
                    int Port = ((IPEndPoint)remoteEP).Port;

                    if (InvokeRequired)
                    {
                        Invoke(new MethodInvoker(delegate
                        {
                            ListMessage.Items.Add("Server: " + message);
                        }));
                    }
                    else
                    {
                        ListMessage.Items.Add("Server: " + message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        
    }
}