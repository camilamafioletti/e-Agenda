using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TelaCompromissoForm : Form
    {
        private Compromisso compromisso;

        private RepositorioContato repositorioContato;


        public TelaCompromissoForm(RepositorioContato repositorioContato)
        {
            InitializeComponent();
            this.repositorioContato = repositorioContato;

        }
         
        public Compromisso Compromisso
        {
            set
            {
                txtId.Text = value.id.ToString();
                comboBoxContato.Text = value.contato.ToString();
                txtTitulo.Text = value.titulo;
                txtLocalizacao.Text = value.localizacao;
                DTPData.Value = value.data;
                dtpInicio.Value = value.dataInicio;
                dtpTermino.Value = value.dataTermino;
                rdbPresencial.Checked = value.presencial;
                rdbRemoto.Checked = value.remoto;
            }
            get
            {
                return compromisso;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Contato contato = comboBoxContato.SelectedItem as Contato;

            string titulo = txtTitulo.Text;

            DateTime data = DTPData.Value;

            DateTime dataInicio = dtpInicio.Value;

            DateTime dataTermino = dtpTermino.Value;

            string localizacao = txtLocalizacao.Text;

            bool remoto = rdbRemoto.Checked;

            bool presencial = rdbPresencial.Checked;

            compromisso = new Compromisso(contato, titulo, localizacao, data, dataInicio, dataTermino, remoto, presencial);

            if (txtId.Text != "0")
                compromisso.id = Convert.ToInt32(txtId.Text);
        }

        private void ckbAdicionarContato_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAdicionarContato.Checked)
            {
                comboBoxContato.Enabled = true;
            }

            ListarContatos();
        }

        private void ListarContatos()
        {
            comboBoxContato.Items.Clear();

            comboBoxContato.Items.AddRange(repositorioContato.SelecionarTodos().ToArray());
        }

    }
}
