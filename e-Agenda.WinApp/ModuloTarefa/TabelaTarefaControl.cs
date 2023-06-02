using e_Agenda.WinApp.ModuloDespesa;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TabelaTarefaControl : UserControl
    {
        public TabelaTarefaControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            gridTarefa.ConfigurarGridZebrado();

            gridTarefa.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<Tarefa> tarefas)
        {
            gridTarefa.Rows.Clear();
            foreach (Tarefa tarefa in tarefas)
            {
                gridTarefa.Rows.Add(tarefa.id, tarefa.titulo, tarefa.prioridade, tarefa.percentual);
            }
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {tarefas.Count} tarefa(s)");
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
                    HeaderText = "Título"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "prioridade",
                    HeaderText = "Prioridade"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "percentualConcluido",
                    HeaderText = "Porcentagem"
                }
            };

            gridTarefa.Columns.AddRange(colunas);
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(gridTarefa.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}
