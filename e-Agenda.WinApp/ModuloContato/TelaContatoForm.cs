using e_Agenda.WinApp.ModuloCategoria;
using e_Agenda.WinApp.ModuloDespesa;
using e_Agenda.WinApp.ModuloTarefa;

namespace e_Agenda.WinApp.ModuloContato
{
    public partial class TelaContatoForm : Form
    {
        private Contato contato;

        public TelaContatoForm(List<Contato> contatos)
        {
            InitializeComponent();

            this.ConfigurarDialog();

        }

        public Contato ObterContato()
        {
            int id = Convert.ToInt32(txtId.Text);
            string nome = txtNome.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;
            string cargo = txtCargo.Text;
            string empresa = txtEmpresa.Text;

            contato = new Contato(nome, telefone, email, cargo, empresa);
            contato.id = id;

            return contato;
        }

        public void ConfigurarTela(Contato contatoSelecionada)
        {
            txtId.Text = contatoSelecionada.id.ToString();
            txtNome.Text = contatoSelecionada.nome;
            txtTelefone.Text = contatoSelecionada.telefone;
            txtEmail.Text = contatoSelecionada.email;
            txtCargo.Text = contatoSelecionada.cargo;
            txtEmpresa.Text = contatoSelecionada.empresa;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Contato contato = ObterContato();

            AtualizarErros(contato);
        }

        private void AtualizarErros(Contato contato)
        {
            string[] erros = contato.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
