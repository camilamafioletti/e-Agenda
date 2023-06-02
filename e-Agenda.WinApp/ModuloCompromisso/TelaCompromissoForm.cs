using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloDespesa;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TelaCompromissoForm : Form
    {
        public TelaCompromissoForm(List<Contato> contatos)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarContatos(contatos);
        }

        private void CarregarContatos(List<Contato> contatos)
        {
            foreach (Contato contato in contatos)
            {
                comboBoxContato.Items.Add(contato);
            }
        }

        public Compromisso ObterCompromisso()
        {
            Contato contato = comboBoxContato.SelectedItem as Contato;

            int id = Convert.ToInt32(txtId.Text);
            string titulo = txtTitulo.Text;
            DateTime data = DTPData.Value;
            DateTime dataInicio = dtpInicio.Value;
            DateTime dataTermino = dtpTermino.Value;
            string localizacao = txtLocalizacao.Text;
            bool remoto = rdbRemoto.Checked;
            bool presencial = rdbPresencial.Checked;

            Compromisso compromisso = new Compromisso(contato, titulo, localizacao, data, dataInicio, dataTermino, remoto, presencial);
            compromisso.id = id;

            return compromisso;
        }

        public void ConfigurarTela(Compromisso compromissoSelecionado)
        {
            txtId.Text = compromissoSelecionado.id.ToString();
            comboBoxContato.Text = compromissoSelecionado.contato.ToString();
            txtTitulo.Text = compromissoSelecionado.titulo;
            txtLocalizacao.Text = compromissoSelecionado.localizacao;
            DTPData.Value = compromissoSelecionado.data;
            dtpInicio.Value = compromissoSelecionado.dataInicio;
            dtpTermino.Value = compromissoSelecionado.dataTermino;
            rdbPresencial.Checked = compromissoSelecionado.presencial;
            rdbRemoto.Checked = compromissoSelecionado.remoto;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Compromisso compromisso = ObterCompromisso();

            AtualizarErros(compromisso);
        }

        private void AtualizarErros(Compromisso compromisso)
        {
            string[] erros = compromisso.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private void ckbAdicionarContato_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAdicionarContato.Checked)
            {
                comboBoxContato.Enabled = true;
            }
        }

    }
}
