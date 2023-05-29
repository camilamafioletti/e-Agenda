using e_Agenda.WinApp.ModuloCategoria;
using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloDespesa;

namespace e_Agenda.WinApp.ModuloDespesas
{
    public partial class TelaDespesaForm : Form
    {
        private Despesa despesa;

        public TelaDespesaForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarFormaPagamento();

        }

        private void CarregarFormaPagamento()
        {
            FormaPagamentoEnum[] pagamentos = Enum.GetValues<FormaPagamentoEnum>();

            foreach (FormaPagamentoEnum pagamento in pagamentos)
            {
                cmbTipoPagamento.Items.Add(pagamento);
            }
        }

        public Despesa ObterDespesa()
        {
            int id = Convert.ToInt32(txtId.Text);
            string descricao = txtDescricao.Text;
            decimal valor = Convert.ToDecimal(txtValor.Text);
            DateTime data = Convert.ToDateTime(txtDataCriacao.Value);
            FormaPagamentoEnum formaPagamento = (FormaPagamentoEnum)cmbTipoPagamento.SelectedItem;

            Despesa despesa = new Despesa(descricao, valor, data, formaPagamento);
            despesa.id = id;

            return despesa;

        }

        public void ConfigurarTela(Despesa despesaSelecionada)
        {
            txtId.Text = despesaSelecionada.id.ToString();
            txtDescricao.Text = despesaSelecionada.descricao;
            txtValor.Text = despesaSelecionada.valor.ToString();
            txtDataCriacao.Value = despesaSelecionada.data;
            cmbTipoPagamento.SelectedItem = despesaSelecionada.tipoPagamento;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Despesa despesa = ObterDespesa();

            string[] erros = despesa.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
