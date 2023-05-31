using e_Agenda.WinApp.ModuloDespesa;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public partial class TelaVisualizarCategoriaForm : Form
    {
        public TelaVisualizarCategoriaForm(List<Despesa> lista)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            AtualizarLista(lista);

        }

        private void AtualizarLista(List<Despesa> lista)
        {
            listDespesas.Items.Clear();

            foreach (Despesa despesa in lista)
            {
                listDespesas.Items.Add(despesa);
            }
        }

        public void CarregarLabel(Categoria categoria)
        {
            lblCategoria.Text = categoria.titulo.ToString();
        }
    }
}
