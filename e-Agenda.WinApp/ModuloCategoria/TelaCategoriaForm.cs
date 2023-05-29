using e_Agenda.WinApp.ModuloDespesa;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public partial class TelaCategoriaForm : Form
    {
        public TelaCategoriaForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public Categoria ObterCategoria()
        {
            int id = Convert.ToInt32(txtId.Text);
            string titulo = txtTitulo.Text;

            Categoria categoria = new Categoria(titulo);
            categoria.id = id;

            return categoria;
        }

        public void ConfigurarTela(Categoria categoriaSelecionada)
        {
            txtId.Text = categoriaSelecionada.id.ToString();
            txtTitulo.Text = categoriaSelecionada.titulo;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Categoria categoria = ObterCategoria();

            string[] erros = categoria.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}