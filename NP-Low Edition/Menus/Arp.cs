using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NP_Low_Edition.Control;

namespace NP_Low_Edition.Menus
{
    public partial class ArpForm : Form
    {
        public ArpForm()
        {
            InitializeComponent();
        }

        private Cmd cmd;

        private void onLoad(object sender, EventArgs e)
        {
            cmd = new Cmd();
            textGetInfo.Text = cmd.execCMD("arp -a");

        }

        private void reloadClick(object sender, EventArgs e)
        {
            textGetInfo.Text = "";
            cmd = new Cmd();
            textGetInfo.Text = cmd.execCMD("arp -a");
        }
    }
}
