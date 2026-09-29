namespace OrcamentoDev.Views
{
    partial class FrmLogin
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
            btnLogin = new Button();
            lblTitulo = new Label();
            txtSenha = new TextBox();
            lblUsuario = new Label();
            lblSenha = new Label();
            txtUsuario = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 0, 192);
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(207, 258);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(104, 42);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Blue;
            lblTitulo.Location = new Point(148, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(268, 40);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Acesso ao Sistema";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(254, 181);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(184, 23);
            txtSenha.TabIndex = 2;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            lblUsuario.Location = new Point(143, 132);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(91, 30);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuário:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            lblSenha.Location = new Point(143, 181);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(75, 30);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(254, 132);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(184, 23);
            txtUsuario.TabIndex = 5;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 397);
            Controls.Add(txtUsuario);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(txtSenha);
            Controls.Add(lblTitulo);
            Controls.Add(btnLogin);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Sistema de Orçamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lblTitulo;
        private TextBox txtSenha;
        private Label lblUsuario;
        private Label lblSenha;
        private TextBox txtUsuario;
    }
}