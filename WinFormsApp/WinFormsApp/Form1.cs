namespace WinFormsApp
{
    public partial class FrmCalculos : Form
    {
        public FrmCalculos()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Minha idade é: {txtIdade.Text}");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int v1 = int.Parse(txtValor1.Text);
            int v2 = int.Parse(txtValor2.Text);

            MessageBox.Show((v1 + v2).ToString(), "Calculo",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnMultiplicar_Click(Object sender, EventArgs e)
        {
            int v1 = int.Parse(txtValor1.Text);
            int v2 = int.Parse(txtValor2.Text);

            MessageBox.Show((v1 * v2).ToString(), "Multiplicação",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnSubtrair_Click(Object sender, EventArgs e)
        {
            int v1 = int.Parse(txtValor1.Text);
            int v2 = int.Parse(txtValor2.Text);

            MessageBox.Show((v1 - v2).ToString(), "Subtração",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

       private void btnIMC_Click(Object sender, EventArgs e)
        {
            float peso = float.Parse(txtPeso.Text);
            float altura = float.Parse(txtAltura.Text);
            float imc = peso / (altura * altura);

            MessageBox.Show((imc).ToString(), "IMC",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (imc < 18.5)
            {
                MessageBox.Show("Abaixo do peso");
            }
            else if (imc > 18.6)
            {
                MessageBox.Show("Peso Ideal");
            }
            else if (imc > 25)
            {
                MessageBox.Show("Levemente acima do peso");
            }
            else if (imc > 30)
            {
                MessageBox.Show("Obesidade grau 1");
            }
            else if (imc > 35)
            {
                MessageBox.Show("Obesidade grau 2");
            }
            else
            {
                MessageBox.Show("Obseidade 3");
            }
        }
    }
}
