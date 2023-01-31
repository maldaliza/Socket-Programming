using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketProgramming.UDP
{
    public partial class Udp_Client : Form
    {
        private static int port = 0;
        private static UdpClient client;
        private static IPEndPoint endPoint;
        IAsyncResult asyncResult;

        public Udp_Client()
        {
            InitializeComponent();
        }

        private void Udp_Client_Load(object sender, EventArgs e)
        {
            port = int.Parse(tb_port.Text);

            Thread socketThread = new Thread(new ThreadStart(Start));
            socketThread.IsBackground = true;
            socketThread.Start();
        }

        private void Start()
        {
            if (client != null) { Debug.WriteLine("이미 UDP 소켓이 생성되어있음.."); }

            client = new UdpClient();
            endPoint = new IPEndPoint(IPAddress.Any, port);

            client.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            client.ExclusiveAddressUse = false;
            client.Client.Bind(endPoint);

            StartListening();
        }

        private void StartListening()
        {
            asyncResult = client.BeginReceive(Receive, new object());
        }

        private void Receive(IAsyncResult ar)
        {
            if (client == null) { return; }

            try
            {
                byte[] bytes = client.EndReceive(ar, ref endPoint);
                string message = Encoding.UTF8.GetString(bytes, 0, bytes.Length);

                if (tb_log.InvokeRequired)
                {
                    tb_log.Invoke(new MethodInvoker(delegate ()
                    {
                        WriteLog(message);
                    }));
                }
                StartListening();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        private void WriteLog(string message)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            Invoke(new MethodInvoker(delegate ()
            {
                tb_log.AppendText("[" + date + "] " + message + "\r\n");
            }));
        }
    }
}
