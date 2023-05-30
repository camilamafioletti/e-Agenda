using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.Properties;

namespace e_Agenda.WinApp.ModuloDespesa
{
    public partial class TabelaDespesaControl : UserControl
    {
        public TabelaDespesaControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            gridDespesas.ConfigurarGridZebrado();

            gridDespesas.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<Despesa> despesas)
        {
            gridDespesas.Rows.Clear();
            foreach (Despesa despesa in despesas)
            {
                gridDespesas.Rows.Add(despesa.id, despesa.descricao, despesa.valor, 
                    despesa.data.Date.ToString("dd/MM/yyyy"), despesa.tipoPagamento);
            }
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {despesas.Count} despesa(s)");
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
                    Name = "descricao",
                    HeaderText = "Descrição"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "valor",
                    HeaderText = "Valor"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "data",
                    HeaderText = "Data"
                },
                   new DataGridViewTextBoxColumn()
                {
                    Name = "tipoPagamento",
                    HeaderText = "Tipo de Pagamento"
                }

            };

            gridDespesas.Columns.AddRange(colunas);
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(gridDespesas.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }

    }
}
