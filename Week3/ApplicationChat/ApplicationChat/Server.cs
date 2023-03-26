using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ApplicationChat
{
    public partial class Server : Form
    {
        private UdpClient udpServer;
        private Thread receiveThread;
        private bool isReceiving = true;
        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            udpServer = new UdpClient(8080);
            receiveThread = new Thread(new ThreadStart(ReceiveMessage));
            receiveThread.Start();
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            isReceiving = false;
            receiveThread.Join();
            udpServer.Close();
        }
        private void ReceiveMessage()
        {
            while (isReceiving)
            {
                try
                {
                    IPEndPoint clientEP = new IPEndPoint(IPAddress.Any, 0);
                    byte[] data = udpServer.Receive(ref clientEP);
                    string message = Encoding.UTF8.GetString(data);
                    string IP = clientEP.Address.ToString();
                    int Port = clientEP.Port;

                    

                    if (InvokeRequired)
                    {
                        Invoke(new MethodInvoker(delegate
                        {
                            ListMessage.Items.Add("Client : " + message);
                        }));
                    }
                    else
                    {
                        ListMessage.Items.Add("Client : " + message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = EnterMessage.Text;
            byte[] data = Encoding.UTF8.GetBytes(message);
            udpServer.Send(data, data.Length, "127.0.0.1", 8081);
            ListMessage.Items.Add("Server: " + message);
            EnterMessage.Clear();
        }
    }
}