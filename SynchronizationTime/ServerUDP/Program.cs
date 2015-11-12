using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerUDP
{
    class Program
    {
        [StructLayout(LayoutKind.Sequential)]
        public class SystemTime
        {
            public ushort Year;
            public ushort Month;
            public ushort DayOfWeek;
            public ushort Day;
            public ushort Hour;
            public ushort Minute;
            public ushort Second;
            public ushort Milliseconds;
        }

        public class LibWrap
        {
            [DllImport("kernel32.dll")]
            public static extern void GetSystemTime(SystemTime t);

            [DllImport("kernel32.dll", EntryPoint = "SetSystemTime", SetLastError = true)]
            public extern static bool Win32SetSystemTime(SystemTime sysTime);
        }

        const int SERVER_PORT = 10080;

        unsafe public static void serverThread()
        {
            UdpClient udpClient = new UdpClient(SERVER_PORT);

            string dataTemplate = "sync ";

            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);

                if (returnData.IndexOf(dataTemplate) != -1)
                {
                    SystemTime systime = new SystemTime();
                    LibWrap.GetSystemTime(systime);

                    int startIndex = dataTemplate.Length;
                    int allData = returnData.Length;
                    string dataString = returnData.Substring(startIndex, allData - startIndex);

                    DateTime data = Convert.ToDateTime(dataString);

                    systime.Hour = (ushort)data.Hour;
                    systime.Minute = (ushort)data.Minute;
                    systime.Second = (ushort)data.Second;

                    LibWrap.Win32SetSystemTime(systime);

                    Console.WriteLine("Время синхронизировано!");

                    break;
                }
            }

            // Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
        }
    }
}
