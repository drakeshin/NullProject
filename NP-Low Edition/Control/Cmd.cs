using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace NP_Low_Edition.Control
{
    class Cmd
    {
        private Process cmd;
        public void executarCMD(string command)
        {
            cmd = new Process();

            cmd.StartInfo.FileName = Environment.GetEnvironmentVariable("comspec");

            cmd.StartInfo.Arguments = string.Format("/c {0}", command);
            cmd.StartInfo.RedirectStandardOutput = false;
            cmd.StartInfo.UseShellExecute = false;
            cmd.StartInfo.CreateNoWindow = true;

            cmd.Start();
        }

    }
}
