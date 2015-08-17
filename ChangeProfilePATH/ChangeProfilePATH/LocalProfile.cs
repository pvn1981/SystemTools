using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeProfilePATH
{
    static class LocalProfile
    {
        public static string ReadPATH()
        {
            string PATH = "";

            PATH = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User);

            return PATH;
        }

        public static void SavePATH(string PATH)
        {
            Environment.SetEnvironmentVariable("PATH", PATH, EnvironmentVariableTarget.User);
        }
    }
}
