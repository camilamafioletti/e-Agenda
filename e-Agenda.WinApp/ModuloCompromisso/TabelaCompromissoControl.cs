using e_Agenda.WinApp.ModuloDespesa;
using e_Agenda.WinApp.Properties;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TabelaCompromissoControl : UserControl
    {
        public TabelaCompromissoControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            gridCompromissos.ConfigurarGridZebrado();

            gridCompromissos.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<Compromisso> compromissos)
        {
            gridCompromissos.Rows.Clear();
            foreach (Compromisso compromisso in compromissos)
            {
                gridCompromissos.Rows.Add(compromisso.id, compromisso.titulo, compromisso.localizacao,
                compromisso.data.ToString("dd/MM/yyyy"), compromisso.contato.nome);
            }
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {compromissos.Count} compromisso(s)");
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
                    HeaderText = "Assunto"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "localizacao",
                    HeaderText = "Local"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "data",
                    HeaderText = "Data"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "contato",
                    HeaderText = "Contato"
                }
            };

            gridCompromissos.Columns.AddRange(colunas);
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(gridCompromissos.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}
