namespace OrcamentoDev.Views
{
    public partial class FrmSplash : Form
    {
        private System.Windows.Forms.Timer timerSplash;

        public FrmSplash()
        {
            InitializeComponent();
           // Configurando os limites da barra 
            prgCarregando.Minimum = 0;
            prgCarregando.Maximum = 100;
            prgCarregando.Value = 0;

            //cria e inicia o timer para avançar suavemente
            timerSplash = new System.Windows.Forms.Timer();
            timerSplash.Tick += timer1_Tick;
            timerSplash.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(prgCarregando.Value < 100)
            {
                prgCarregando.Value += 2;
            }
            else
            {
                timerSplash.Stop();

                FrmLogin login = new FrmLogin();
                login.Show();
                this.Hide();
            }

        }
    }
}
