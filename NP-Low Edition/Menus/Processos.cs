using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace NP_Low_Edition.Menus
{
    public partial class Processos : Form
    {
        public Processos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Área de vars
        /// </summary>
        private Process[] processos;
        private BindingSource src;
        private DataTable table;
        ///

        /// <summary>
        /// Evento que carrega as informações de processos nesse Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadAll(object sender, EventArgs e)
        {
            
            processos = Process.GetProcesses(); // Pega lista de processos
            //"Configurando" a tabela
            table = new DataTable("Lista de Processos");
            table.Columns.Add("Nome");
            table.Columns.Add("ID");
            //
            src = new BindingSource();

            for (int x = 0; x < processos.Length; x++)
            {
                table.Rows.Add(new Object[] {
                    processos[x].ProcessName,
                    processos[x].Id
                });
            }

            table.AcceptChanges();
            src.DataSource = table;

            int scroll = listProcesso.FirstDisplayedScrollingRowIndex;
            listProcesso.DataSource = src;

            if (scroll != -1)
            {
                listProcesso.FirstDisplayedScrollingRowIndex = scroll;
            }

            

        }

        /// <summary>
        /// Resetar a lista de processos e atualizar com novas entradas =D
        /// </summary>
        private void reloadList()
        {
            table.Reset(); // reseta a tabela e coloca as entradas a seguir
            processos = Process.GetProcesses(); // Pega lista de processos
            //"Configurando" a tabela
            table = new DataTable("Lista de Processos");
            table.Columns.Add("Nome");
            table.Columns.Add("ID");
            //
            src = new BindingSource();

            for (int x = 0; x < processos.Length; x++)
            {
                table.Rows.Add(new Object[] {
                    processos[x].ProcessName,
                    processos[x].Id
                });
            }

            table.AcceptChanges();
            src.DataSource = table;

            int scroll = listProcesso.FirstDisplayedScrollingRowIndex;//unicamente para barra de rolagem
            listProcesso.DataSource = src;

            if (scroll != -1)
            {
                listProcesso.FirstDisplayedScrollingRowIndex = scroll;
            }
        }

        /// <summary>
        /// Procura o nome de processos na lista de processos e fecha ele
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeProcess(object sender, EventArgs e)
        {
            
            int getColumnIndex = listProcesso.CurrentCell.ColumnIndex;
            string getProcessName = listProcesso.SelectedCells[getColumnIndex].Value.ToString();

            
            try
            {
                foreach(Process pro in Process.GetProcessesByName(getProcessName))
                {
                    pro.Kill();
                    reloadList();
                }
            }catch(Exception ex) {
                MessageBox.Show("Erro ao fechar processo: " + ex);
            } 
        }
    }
}
