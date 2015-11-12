using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientUDP
{
    class Program
    {
        const int SERVER_PORT = 10080;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите ip-адрес компьютера:");
            string ipComputer = Console.ReadLine();

            UdpClient udpClient = new UdpClient();
            udpClient.Connect(ipComputer, SERVER_PORT);
            Byte[] senddata = Encoding.ASCII.GetBytes("sync " + DateTime.UtcNow.ToString());
            udpClient.Send(senddata, senddata.Length);
        }
    }
}
