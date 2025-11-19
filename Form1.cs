namespace CALCULADORA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTB1_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(TXT1.Text);
            int numero2 = int.Parse(TXT2.Text);
            int resultado = numero1 + numero2;

            LBLRESULTADO.Text = resultado.ToString();
        }

        private void BTB2_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(TXT1.Text);
            int numero2 = int.Parse(TXT2.Text);
            int resultado = numero1 - numero2;

            LBLRESULTADO.Text = resultado.ToString();
        }

        private void BTB3_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(TXT1.Text);
            int numero2 = int.Parse(TXT2.Text);
            int resultado = numero1 * numero2;

            LBLRESULTADO.Text = resultado.ToString();
        }

        private void BTB4_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(TXT1.Text);
            int numero2 = int.Parse(TXT2.Text);
            int resultado = numero1 / numero2;

            LBLRESULTADO.Text = resultado.ToString();
        }
    }
}
