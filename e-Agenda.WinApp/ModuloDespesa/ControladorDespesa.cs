using e_Agenda.WinApp.ModuloCategoria;
using e_Agenda.WinApp.ModuloDespesas;

namespace e_Agenda.WinApp.ModuloDespesa
{
    public class ControladorDespesa : ControladorBase
    {
        private RepositorioDespesa repositorioDespesa;
        private RepositorioCategoria repositorioCategoria;
        private TabelaDespesaControl tabelaDespesa;

        public ControladorDespesa(RepositorioDespesa repositorioDespesa, RepositorioCategoria repositorioCategoria)
        {
            this.repositorioDespesa = repositorioDespesa;
            this.repositorioCategoria = repositorioCategoria;
        }

        public override string ToolTipInserir => "Inserir nova despesa";

        public override string ToolTipEditar => "Editar despesa existente";

        public override string ToolTipExcluir => "Excluir despesa existente";

        public override void Inserir()
        {

            TelaDespesaForm telaDespesa = new TelaDespesaForm();

            DialogResult opcaoEscolhida = telaDespesa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Despesa despesa = telaDespesa.ObterDespesa();
                repositorioDespesa.Inserir(despesa);
                CarregarDespesas();
            }
        }

        public override void Editar()
        {

            Despesa despesaSelecionada = ObterDespesaSelecionada();

            if (despesaSelecionada == null)
            {
                MessageBox.Show($"Selecione uma despesa primeiro", "Edicao de Despesas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaDespesaForm telaDespesa = new TelaDespesaForm();
            telaDespesa.ConfigurarTela(despesaSelecionada);

            DialogResult opcaoEscolhida = telaDespesa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Despesa despesa = telaDespesa.ObterDespesa();

                repositorioDespesa.Editar(despesa.id, despesa);

                CarregarDespesas();
            }
        }

        public override void Excluir()
        {
            Despesa despesa = ObterDespesaSelecionada();

            if (despesa == null)
            {
                MessageBox.Show($"Selecione uma despesa primeiro!",
                    "Exclusão de despesas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a despesa {despesa.descricao}?", "Exclusão de Despesas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioDespesa.Excluir(despesa);

                CarregarDespesas();
            }
        }

        public Despesa ObterDespesaSelecionada()
        {
            int id = tabelaDespesa.ObterIdSelecionado();

            return repositorioDespesa.SelecionarPorId(id);

        }

        public override UserControl ObterListagem()
        {
            if (tabelaDespesa == null)
                tabelaDespesa = new TabelaDespesaControl();

            CarregarDespesas();

            return tabelaDespesa;
        }

        private void CarregarDespesas()
        {
            List<Despesa> despesas = repositorioDespesa.SelecionarTodos();

            tabelaDespesa.AtualizarRegistros(despesas);
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Despesas";
        }
    }
}
