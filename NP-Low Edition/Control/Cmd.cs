using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace NP_Low_Edition.Control
{
    /*
    REVER O DESCONSTRUTOR E OTIMIZAR O USO DE MEMÓRIA DA MÁQUINA
    */
    class Cmd
    {
        private Process cmd;
        private string returnedCmd;

        ~Cmd()
        {
            cmd = null;
            returnedCmd = null;
        }
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

        public string execCMD(string command)
        {
            cmd = new Process();

            cmd.StartInfo.FileName = Environment.GetEnvironmentVariable("comspec");
            cmd.StartInfo.Arguments = string.Format("/c {0}", command);
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.StartInfo.CreateNoWindow = true;

            cmd.Start();
            returnedCmd = cmd.StandardOutput.ReadToEnd();
            byte[] bytes = Encoding.ASCII.GetBytes(returnedCmd);
            returnedCmd = Encoding.UTF8.GetString(bytes);
            return returnedCmd;
        }

    }
}
