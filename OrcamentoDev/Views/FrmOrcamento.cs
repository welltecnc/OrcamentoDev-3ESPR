using OrcamentoDev.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrcamentoDev.Views
{
    public partial class FrmOrcamento : Form
    {
        // Variável global  para guardar o ultimo calculo feito 
        private decimal valorTotalCalculado = 0;

        public FrmOrcamento()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //tratamento de erros

            try
            {
                string cliente = txtCliente.Text;
                int horas = int.Parse(txtHoras.Text);
                decimal valorHora = decimal.Parse(txtValorHora.Text);
                bool urgente = chkUrgente.Checked;

                //Aplicação de Orientação a objetos (herança e Polimorfismo)
                Orcamento meuOrcamento = urgente
                    ? new OrcamentoUrgente(cliente, horas, valorHora, true)
                    : new Orcamento(cliente, horas, valorHora);

                valorTotalCalculado = meuOrcamento.CalcularTotal();

                //Exibe o resultado na label 
                lblResultado.Text = $"Valor Total: R$ {valorTotalCalculado:N2}";

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, Preencha os campos", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
