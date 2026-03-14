using Newtonsoft.Json;

namespace WinFormsAppConsumirAPI
{
    public partial class FrmAPI : Form
    {
        public FrmAPI()
        {
            InitializeComponent();
        }

        private void MetodoBuscarFeriado()
        {
            int ano;

            if (!int.TryParse(txtAno.Text, out ano))
            {
                MessageBox.Show("Digite um ano válido");
                txtAno.Focus();
                txtAno.Clear();
                return;
            }

            HttpClient client = new HttpClient();
            string url = $"https://brasilapi.com.br/api/feriados/v1/{ano}";


            var response = client.GetAsync(url).Result;

            if (!response.IsSuccessStatusCode.Equals(true))
            {
                MessageBox.Show("Erro ao buscar os feriados");
                return;
            }

            var json = response.Content.ReadAsStringAsync().Result;

            List<Feriado> listaFeriados =
                JsonConvert.DeserializeObject<List<Feriado>>(json) ?? new List<Feriado>();

            dgvFeriados.DataSource = listaFeriados;

        }

        private void BuscarCep()
        {
            int cep;
            if (!int.TryParse(txtCep.Text, out cep))
            {
                MessageBox.Show("Digite um CEP válido");
                txtCep.Focus();
                txtCep.Clear();
                return;
            }

            HttpClient Client = new HttpClient();
            string url = $"https://brasilapi.com.br/api/cep/v1/{cep}";

            var response = Client.GetAsync(url).Result;

            if (!response.IsSuccessStatusCode.Equals(true))
            {
                MessageBox.Show("Erro ao buscar o CEP");
                return;
            }

            var json = response.Content.ReadAsStringAsync().Result;

            CEP informacoes = JsonConvert.DeserializeObject<CEP>(json) ?? new CEP();
            List<CEP> listainfo = new List<CEP> { informacoes };
            dgvCep.DataSource = listainfo;
        }

        //Eventos
        private void btnGerar_Click(object sender, EventArgs e)
        {
            BuscarCep();
        }

       
    }
}
