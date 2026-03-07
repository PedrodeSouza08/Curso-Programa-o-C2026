namespace Calculadora
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }
        double numero1 = 0;
        double numero2= 0;
        string operacao = "";



        private void Botao_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

            string valor = botao.Text;
            //Visor da Calculadora
            txtCalculadora.Text += valor;
        }

        private void Operador_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            numero1 = Convert.ToDouble(txtCalculadora.Text);
            operacao = botao.Text;
            txtCalculadora.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(txtCalculadora.Text);

            double resultado = 0;

            switch (operacao)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;

                case "-":
                    resultado = numero1 - numero2;
                    break;

                case "*":
                    resultado = numero1 * numero2;
                    break;

                case "/":
                    resultado = numero1 / numero2;
                    break;

            }

            txtCalculadora.Text = resultado.ToString();
        }


    }
}
