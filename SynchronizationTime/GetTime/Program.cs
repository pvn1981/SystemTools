using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GetTime
{
    class Program
    {
        [StructLayout(LayoutKind.Sequential)]
        class SystemTime
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
        
        [DllImport("kernel32.dll")]
        static extern void GetSystemTime(SystemTime t);

        static void Main(string[] args)
        {
            SystemTime t = new SystemTime();
            GetSystemTime(t);
            Console.WriteLine(t.Minute);
            Console.ReadLine();
        }
    }
}
