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

namespace SocketProgramming
{
    public partial class Tcp_Client : Form
    {
        private static string ip = string.Empty;
        private static string port = string.Empty;

        private static TcpClient client = new TcpClient();

        public Tcp_Client()
        {
            InitializeComponent();
        }

        private void Tcp_Client_Load(object sender, EventArgs e)
        {
            Thread receiveThread = new Thread(new ThreadStart(Receive));
            receiveThread.IsBackground = true;
            receiveThread.Start();
        }

        private void Receive()
        {
            while (true)
            {
                if (client.Connected)
                {
                    try
                    {
                        NetworkStream stream = client.GetStream();
                        byte[] buffer = new byte[1024];
                        int bytes = stream.Read(buffer, 0, buffer.Length);
                        if (bytes <= 0)
                        {
                            continue;
                        }

                        string message = Encoding.UTF8.GetString(buffer, 0, bytes);
                        WriteLog("[You] " + message);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.ToString());
                    }
                }
            }
        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            ip = tb_ip.Text;
            port = tb_port.Text;
            if (ip.Split('.').Length != 4 || port == "")
            {
                tb_ip.Text = string.Empty;
                tb_port.Text = string.Empty;
                return;
            }

            Thread connectThread = new Thread(new ThreadStart(Connect));
            connectThread.IsBackground = true;
            connectThread.Start();
        }

        private void Connect()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ip), int.Parse(port));
            try
            {
                client.Connect(endPoint);
                WriteLog("Connected...");
            }
            catch (SocketException se)
            {
                WriteLog(se.Message);
            }
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            string message = tb_message.Text;
            if (message.Length <= 0) { return; }

            try
            {
                NetworkStream stream = client.GetStream();
                byte[] buffer = Encoding.UTF8.GetBytes(message);
                stream.Write(buffer, 0, buffer.Length);

                WriteLog("[Me] " + message);
                tb_message.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        private void WriteLog(string text)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            Invoke(new MethodInvoker(delegate ()
            {
                tb_log.AppendText("[" + date + "] " + text + "\r\n");
            }));
        }
    }
}
