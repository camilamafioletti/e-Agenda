using e_Agenda.Dominio.ModuloCategoria;
using e_Agenda.WinApp.ModuloDespesa;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public partial class TabelaCategoriaControl : UserControl
    {
        public TabelaCategoriaControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            gridCategoria.ConfigurarGridZebrado();

            gridCategoria.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<Categoria> categorias)
        {
            gridCategoria.Rows.Clear();

            foreach (Categoria categoria in categorias)
            {
                gridCategoria.Rows.Add(categoria.id, categoria.titulo);
            }
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {categorias.Count} categoria(s)");
        }

        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Id"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "titulo",
                    HeaderText = "Titulo"
                }
            };
            gridCategoria.Columns.AddRange(colunas);
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(gridCategoria.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }

    }
}
