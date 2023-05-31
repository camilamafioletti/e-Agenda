using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloDespesa;
using e_Agenda.WinApp.ModuloTarefa;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public class ControladorCategoria : ControladorBase
    {
        private IRepositorioCategoria repositorioCategoria;
        private TabelaCategoriaControl tabelaCategoria;
        private IRepositorioDespesa repositorioDespesa;

        public ControladorCategoria(IRepositorioCategoria repositorioCategoria, IRepositorioDespesa repositorioDespesa)
        {
            this.repositorioCategoria = repositorioCategoria;
            this.repositorioDespesa = repositorioDespesa;
        }

        #region ToolTips
        public override string ToolTipInserir => "Inserir nova Categoria";

        public override string ToolTipEditar => "Editar Categoria existente";

        public override string ToolTipExcluir => "Excluir Categoria existente";

        public override bool VisualizarHabilitado => true;

        #endregion

        public override void Inserir()
        {
            TelaCategoriaForm telaCategoria = new TelaCategoriaForm();

            DialogResult opcaoEscolhida = telaCategoria.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Categoria novaCategoria = telaCategoria.ObterCategoria();

                repositorioCategoria.Inserir(novaCategoria);

                CarregarCategoria();
            }
        }

        public override void Editar()
        {
            Categoria categoriaSelecionada = ObterCategoriaSelecionada();

            if (categoriaSelecionada == null)
            {
                MessageBox.Show($"Selecione uma categoria primeiro!",
                    "Edição de Categoria",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaCategoriaForm telaCategoria = new TelaCategoriaForm();

            telaCategoria.ConfigurarTela(categoriaSelecionada);

            DialogResult opcaoEscolhida = telaCategoria.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Categoria categoria = telaCategoria.ObterCategoria();

                repositorioCategoria.Editar(categoria.id, categoria);

                CarregarCategoria();
            }
        }

        public override void Excluir()
        {
            Categoria categoriaSelecionada = ObterCategoriaSelecionada();

            if (categoriaSelecionada == null)
            {
                MessageBox.Show("Selecione uma categoria primeiro", "Exclusão de Categoria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a categoria {categoriaSelecionada.titulo}?",
                "Exclusão de Categoria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCategoria.Excluir(categoriaSelecionada);

                CarregarCategoria();
            }
        }

        private Categoria ObterCategoriaSelecionada()
        {
            int id = tabelaCategoria.ObterIdSelecionado();

            return repositorioCategoria.SelecionarPorId(id);
        }

        private void CarregarCategoria() 
        { 
            List<Categoria> categoria = repositorioCategoria.SelecionarTodos();

            tabelaCategoria.AtualizarRegistros(categoria);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaCategoria == null)
                tabelaCategoria = new TabelaCategoriaControl();

            CarregarCategoria();

            return tabelaCategoria;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Categorias";
        }

        public override void VisualizarCategorias()
        {
            Categoria categoria = ObterCategoriaSelecionada();

            if (categoria == null)
            {
                MessageBox.Show("Selecione uma categoria!");
                return;
            }

            List<Despesa> despesasPorCategoria = repositorioDespesa.ListarDespesasPorCategorias(categoria);

            if (despesasPorCategoria.Count == 0)
            {
                MessageBox.Show("Nenhuma despesa para a categoria selecionada!");
                return;
            }

            TelaVisualizarCategoriaForm tela = new TelaVisualizarCategoriaForm(despesasPorCategoria);

            tela.CarregarLabel(categoria);

            tela.ShowDialog();
        }
    }
}
