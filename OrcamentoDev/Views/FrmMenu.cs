using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrcamentoDev.Views
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.OpenForms["FrmLogin"]?.Show();
            this.Close();
        }

        private void btnNovoOrcamento_Click(object sender, EventArgs e)
        {
            FrmOrcamento telaOrcamento = new FrmOrcamento();
            telaOrcamento.ShowDialog();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "orcamento.txt");
            {
                if (File.Exists(caminho))
                {
                    string relatorio = File.ReadAllText(caminho);
                    MessageBox.Show(relatorio,"Relatório de Orçamentos",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show($"O arquivo não foi encontrado em:{caminho}","Aviso",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
