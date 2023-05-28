using e_Agenda.WinApp.Properties;

namespace e_Agenda.WinApp.ModuloContato
{
    public partial class TabelaContatoControl : UserControl
    {
        public TabelaContatoControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            gridContato.ConfigurarGridZebrado();

            gridContato.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<Contato> contatos)
        {
            gridContato.Rows.Clear();
            foreach (Contato contato in contatos)
            {
                gridContato.Rows.Add(contato.id, contato.nome, contato.telefone, contato.email, contato.empresa);
            }
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
                    Name = "nome",
                    HeaderText = "Nome"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "telefone",
                    HeaderText = "Telefone"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "email",
                    HeaderText = "Email"
                },
                     new DataGridViewTextBoxColumn()
                {
                    Name = "empresa",
                    HeaderText = "Empresa"
                }
            };

            gridContato.Columns.AddRange(colunas);
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(gridContato.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}
