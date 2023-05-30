using e_Agenda.WinApp.ModuloCategoria;
using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloDespesa;
using e_Agenda.WinApp.ModuloTarefa;
using System.Xml.Linq;

namespace e_Agenda.WinApp.ModuloDespesas
{
    public partial class TelaDespesaForm : Form
    {
        RepositorioCategoria repositorioCategoria;

        public TelaDespesaForm(List<Categoria> categorias)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarFormaPagamento();

            ConfigurarListaCategorias(categorias);
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

            despesa.categorias.AddRange(chCategorias.CheckedItems.Cast<Categoria>());

            return despesa;
        }
        public void ConfigurarTela(Despesa despesaSelecionada)
        {
            txtId.Text = despesaSelecionada.id.ToString();
            txtDescricao.Text = despesaSelecionada.descricao;
            txtValor.Text = despesaSelecionada.valor.ToString();
            txtDataCriacao.Value = despesaSelecionada.data;
            cmbTipoPagamento.SelectedItem = despesaSelecionada.tipoPagamento;

            int i = 0;

            for (int j = 0; j < chCategorias.Items.Count; j++)
            {
                Categoria categoria = (Categoria)chCategorias.Items[j];

                if (despesaSelecionada.categorias.Contains(categoria))
                {
                    chCategorias.SetItemChecked(i, true);
                }

                i++;
            }
        }

        public void ConfigurarListaCategorias(List<Categoria> categorias)
        {
            chCategorias.Items.Clear();

            chCategorias.Items.AddRange(categorias.ToArray());
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string idStr = txtId.Text;
            string descricao = txtDescricao.Text;
            decimal valor = Convert.ToDecimal(txtValor.Text);
            DateTime data = Convert.ToDateTime(txtDataCriacao.Text);

            string formaPgtoStr = Convert.ToString(cmbTipoPagamento.SelectedItem);
            FormaPagamentoEnum formaPgto;
            bool formaPgtoValida = Enum.TryParse(formaPgtoStr, out formaPgto);

            List<Categoria> listCategorias = chCategorias.CheckedItems.Cast<Categoria>().ToList();

            Despesa despesa = new Despesa(descricao, valor, data, formaPgto);
            despesa.categorias = listCategorias;

            int id = 0;
            if (!string.IsNullOrEmpty(idStr))
            {
                id = Convert.ToInt32(idStr);
            }
            despesa.id = id;

            List<string> erros = despesa.Validar().ToList();

            if (erros.Any())
            {
                DialogResult = DialogResult.None;

                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
            }

        }
    }
}
