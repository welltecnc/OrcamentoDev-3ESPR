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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(txtCliente.Text) || string.IsNullOrWhiteSpace(txtHoras.Text))
                {
                    MessageBox.Show("Preencha os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                string cliente = txtCliente.Text;
                string projeto = txtProjeto.Text;
                string hora = txtHoras.Text;
                string valorHora = txtValorHora.Text;
                bool urgente = chkUrgente.Checked;

                string conteudo = "------------------------------------\n" +
                    $"Data/Hora: {DateTime.Now}\n" +
                    $"Cliente: {cliente}\n" +
                    $"Projeto: {projeto}\n" +
                    $"Horas: {hora} h | Valor Hora: {valorHora}\n" +
                    $"Urgente: {(urgente ? "Sim" : "Não")}\n" +
                    $"Total: R$ {valorTotalCalculado:N2}\n" +
                    $"";

                //criando o caminho seguro para salvar na pasta
                string camimho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "orcamento.txt");
                File.AppendAllText(camimho, conteudo);
                MessageBox.Show("Orçamento salvo com sucesso", "Sucesso",MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (FormatException)
            {
                MessageBox.Show("Erro ao salvar arquivo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
