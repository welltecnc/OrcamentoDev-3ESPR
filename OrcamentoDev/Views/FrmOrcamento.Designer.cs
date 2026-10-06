namespace OrcamentoDev.Views
{
    partial class FrmOrcamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalcular = new Button();
            chkUrgente = new CheckBox();
            lblCliente = new Label();
            txtCliente = new TextBox();
            lblProjeto = new Label();
            lblHoras = new Label();
            lblValorHora = new Label();
            lblResultado = new Label();
            txtHoras = new TextBox();
            txtProjeto = new TextBox();
            txtValorHora = new TextBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(240, 376);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(147, 37);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular Valor";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // chkUrgente
            // 
            chkUrgente.AutoSize = true;
            chkUrgente.Location = new Point(209, 284);
            chkUrgente.Name = "chkUrgente";
            chkUrgente.Size = new Size(211, 19);
            chkUrgente.TabIndex = 1;
            chkUrgente.Text = "Projeto Urgente (Adicional de 20%)";
            chkUrgente.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(209, 31);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(100, 15);
            lblCliente.TabIndex = 2;
            lblCliente.Text = "Nome do Cliente:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(344, 23);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(229, 23);
            txtCliente.TabIndex = 3;
            // 
            // lblProjeto
            // 
            lblProjeto.AutoSize = true;
            lblProjeto.Location = new Point(209, 89);
            lblProjeto.Name = "lblProjeto";
            lblProjeto.Size = new Size(113, 15);
            lblProjeto.TabIndex = 4;
            lblProjeto.Text = "Desrição do Projeto:";
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Location = new Point(209, 156);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(97, 15);
            lblHoras.TabIndex = 5;
            lblHoras.Text = "Horas Estimadas:";
            // 
            // lblValorHora
            // 
            lblValorHora.AutoSize = true;
            lblValorHora.Location = new Point(209, 226);
            lblValorHora.Name = "lblValorHora";
            lblValorHora.Size = new Size(92, 15);
            lblValorHora.TabIndex = 6;
            lblValorHora.Text = "Valor Hora (R$) :";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(209, 327);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(108, 15);
            lblResultado.TabIndex = 7;
            lblResultado.Text = " Valor Total: R$ 0,00";
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(344, 153);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(229, 23);
            txtHoras.TabIndex = 8;
            // 
            // txtProjeto
            // 
            txtProjeto.Location = new Point(344, 89);
            txtProjeto.Name = "txtProjeto";
            txtProjeto.Size = new Size(229, 23);
            txtProjeto.TabIndex = 9;
            // 
            // txtValorHora
            // 
            txtValorHora.Location = new Point(344, 218);
            txtValorHora.Name = "txtValorHora";
            txtValorHora.Size = new Size(229, 23);
            txtValorHora.TabIndex = 10;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(434, 376);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(124, 37);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar Orçamento";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // FrmOrcamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(txtValorHora);
            Controls.Add(txtProjeto);
            Controls.Add(txtHoras);
            Controls.Add(lblResultado);
            Controls.Add(lblValorHora);
            Controls.Add(lblHoras);
            Controls.Add(lblProjeto);
            Controls.Add(txtCliente);
            Controls.Add(lblCliente);
            Controls.Add(chkUrgente);
            Controls.Add(btnCalcular);
            Name = "FrmOrcamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Orçamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private CheckBox chkUrgente;
        private Label lblCliente;
        private TextBox txtCliente;
        private Label lblProjeto;
        private Label lblHoras;
        private Label lblValorHora;
        private Label lblResultado;
        private TextBox txtHoras;
        private TextBox txtProjeto;
        private TextBox txtValorHora;
        private Button btnSalvar;
    }
}