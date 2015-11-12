using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientUDP_W
{
    public partial class FormMain : Form
    {
        const int SERVER_PORT = 10080;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(TextBoxIPComputer.Text, SERVER_PORT);
            Byte[] senddata = Encoding.ASCII.GetBytes("sync " + DateTime.UtcNow.ToString());
            udpClient.Send(senddata, senddata.Length);
        }
    }
}
