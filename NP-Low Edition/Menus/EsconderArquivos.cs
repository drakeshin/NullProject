using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NP_Low_Edition.Menus
{
    public partial class EsconderArquivos : Form
    {
        public EsconderArquivos()
        {
            InitializeComponent();
        }

        private FileStream fs;
        private Stream stream;
        private StreamReader srH;
        private StreamReader sr;
        private StreamWriter sw;
        private void browserFile(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                sr = new StreamReader(openFileDialog.FileName);
                Stream hue =sr.BaseStream;
                arquivoPego.Text = openFileDialog.FileName;
                sr.Close();
                fs = new FileStream(hue, FileMode.OpenOrCreate);
                
                if(srH.ToString() == "")
                {
                    MessageBox.Show("Selecione o arquivo de saida");
                }
                else
                {
                    fs.CopyTo(stream);
                    fs.Close();
                }
            }
        }

        private void hideToBt(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                srH = new StreamReader(openFileDialog.FileName);
                pathArquivoEsconde.Text = openFileDialog.FileName;
                stream = srH.BaseStream;
                

            }
        }
    }
}
