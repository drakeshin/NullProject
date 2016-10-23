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
    public partial class IPconfigForm : Form
    {
        public IPconfigForm()
        {
            InitializeComponent();
        }

        private Cmd cmd;

        private void carregaConfig(object sender, EventArgs e)
        {
            cmd = new Cmd();

            ipConfigBox.Text = cmd.execCMD("ipconfig /all");
        }

        private void clickReload(object sender, EventArgs e)
        {
            ipConfigBox.Text = "";
            cmd = new Cmd();
            ipConfigBox.Text = cmd.execCMD("ipconfig /all");
        }
    }
}
