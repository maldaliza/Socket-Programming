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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketProgramming.UDP
{
    public partial class Udp_Server : Form
    {
        private static string ip = string.Empty;
        private static int port = 0;

        public Udp_Server()
        {
            InitializeComponent();
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            ip = tb_ip.Text;
            port = int.Parse(tb_port.Text);

            string message = tb_message.Text;
            byte[] bytes = Encoding.UTF8.GetBytes(message);
            try
            {
                using (UdpClient client = new UdpClient())
                {
                    IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ip), port);
                    client.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                    client.Send(bytes, bytes.Length, endPoint);

                    WriteLog(message);
                    tb_message.Text = string.Empty;

                    client.Close();
                }
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
