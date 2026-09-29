namespace OrcamentoDev.Views
{
    partial class FrmMenu
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
            lblBoasVindas = new Label();
            btnNovoOrcamento = new Button();
            btnRelatorio = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // lblBoasVindas
            // 
            lblBoasVindas.AutoSize = true;
            lblBoasVindas.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBoasVindas.ForeColor = Color.Blue;
            lblBoasVindas.Location = new Point(203, 39);
            lblBoasVindas.Name = "lblBoasVindas";
            lblBoasVindas.Size = new Size(546, 40);
            lblBoasVindas.TabIndex = 0;
            lblBoasVindas.Text = "Bem-Vindo ao Sistema de Orçamentos";
            // 
            // btnNovoOrcamento
            // 
            btnNovoOrcamento.BackColor = Color.Black;
            btnNovoOrcamento.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnNovoOrcamento.ForeColor = Color.Yellow;
            btnNovoOrcamento.Location = new Point(192, 188);
            btnNovoOrcamento.Name = "btnNovoOrcamento";
            btnNovoOrcamento.Size = new Size(126, 53);
            btnNovoOrcamento.TabIndex = 1;
            btnNovoOrcamento.Text = "Novo Orçamento";
            btnNovoOrcamento.UseVisualStyleBackColor = false;
            // 
            // btnRelatorio
            // 
            btnRelatorio.BackColor = Color.Black;
            btnRelatorio.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnRelatorio.ForeColor = Color.Yellow;
            btnRelatorio.Location = new Point(375, 188);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(126, 53);
            btnRelatorio.TabIndex = 2;
            btnRelatorio.Text = "Relatório";
            btnRelatorio.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Black;
            btnSair.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnSair.ForeColor = Color.Yellow;
            btnSair.Location = new Point(569, 188);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(126, 53);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 395);
            Controls.Add(btnSair);
            Controls.Add(btnRelatorio);
            Controls.Add(btnNovoOrcamento);
            Controls.Add(lblBoasVindas);
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal- Orçamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBoasVindas;
        private Button btnNovoOrcamento;
        private Button btnRelatorio;
        private Button btnSair;
    }
}