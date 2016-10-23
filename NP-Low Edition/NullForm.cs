using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NP_Low_Edition.Menus;
using System.Diagnostics;
using NP_Low_Edition.Control;
namespace NP_Low_Edition
{
    public partial class NullProject : Form
    {
        public NullProject()
        {
            InitializeComponent();
        }

        private Cmd cmd;

        /// <summary>
        /// Somente evento para caso o chackbox estiver marcado, ele vai em tray
        /// </summary>
        /// <param name="gotray"></param>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void goTray(object sender, EventArgs e)
        {
            if (trayCheckBox.CheckState == CheckState.Checked)
            {
                lookTrayIcon.Visible = true;
                if (lookTrayIcon.Visible == true)
                {
                    this.Hide();
                }
            }
            else if (trayCheckBox.CheckState == CheckState.Unchecked)
            {
                lookTrayIcon.Visible = false;
                this.Show();
            }
        }

        /// <summary>
        /// Faz sair do modo Tray
        /// </summary>
        /// <param name="e"></param>
        private void lookTrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (trayCheckBox.CheckState == CheckState.Checked)
            {
                trayCheckBox.Checked = false;
                this.Show();

            }
        }

        private void resizing(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Abre o Form de Processos =D
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void goToProcess(object sender, EventArgs e)
        {
            Processos prosForm = new Processos();
            
            prosForm.Show();
        }

        private void abrirFormEsconder(object sender, EventArgs e)
        {
            EsconderArquivos formE = new EsconderArquivos();
            formE.Show();
        }

        private void abrirCalcClick(object sender, EventArgs e)
        {
            cmd = new Cmd();
            cmd.executarCMD("Calc.exe");
        }

        private void openArpForm(object sender, EventArgs e)
        {
            ArpForm form = new ArpForm();
            form.Show();
        }

        private void abrirFormIpConfig(object sender, EventArgs e)
        {
            IPconfigForm form = new IPconfigForm();
            form.Show();
        }
    }
}
