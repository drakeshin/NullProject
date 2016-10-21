using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NP_Low_Edition.Control;


namespace NP_Low_Edition.Menus
{
    public partial class EsconderArquivos : Form
    {
        public EsconderArquivos()
        {
            InitializeComponent();
        }

        private string fileToHide;
        private string fileThatHide;
        private Cmd cmd;
        private void browserFile(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                arquivoPego.Text = "";
                arquivoPego.Text = openFileDialog.FileName;
                fileToHide = openFileDialog.FileName.ToString();


                if (fileThatHide == "")
                {
                    MessageBox.Show("Selecione o arquivo de saida");
                }
                
            }
        }

        private void hideToBt(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathArquivoEsconde.Text = "";
                
                pathArquivoEsconde.Text = openFileDialog.FileName;
                fileThatHide = openFileDialog.FileName.ToString();

                if(fileToHide == "")
                {
                    MessageBox.Show("Selecione o arquivo de entrada");
                }
                else
                {
                    cmd = new Cmd();
                    cmd.executarCMD("COPY /b "+fileThatHide+" +"+fileToHide+" "+fileThatHide);
                    progressBar.Maximum = 100;
                    progressBar.Increment(100);
                    MessageBox.Show("Pronto!");
                    
                }
                

            }
        }

       
    }
}
