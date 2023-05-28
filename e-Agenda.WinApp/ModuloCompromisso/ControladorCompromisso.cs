using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class ControladorCompromisso : ControladorBase
    {
        private RepositorioCompromisso repositorioCompromisso;
        private RepositorioContato repositorioContato;
        private TabelaCompromissoControl tabelaCompromissos;

        public ControladorCompromisso(RepositorioCompromisso repositorioCompromisso, RepositorioContato repositorioContato)
        {

            this.repositorioCompromisso = repositorioCompromisso;
            this.repositorioContato = repositorioContato;
        }

        public override string ToolTipInserir { get { return "Inserir novo Compromisso"; } }

        public override string ToolTipEditar { get { return "Editar Compromisso Existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Compromisso Existente"; } }

        public override void Inserir()
        {
            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm(repositorioContato);

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Compromisso compromisso = telaCompromisso.Compromisso;

                repositorioCompromisso.Inserir(compromisso);

                CarregarCompromissos();
            }
        }

        public override void Editar()
        {
            Compromisso compromisso = ObterCompromissoSelecionado();

            if (compromisso == null)
            {
                MessageBox.Show($"Selecione um contato primeiro!",
                    "Edição de Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm(repositorioContato);
            telaCompromisso.Compromisso = compromisso;

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCompromisso.Editar(compromisso.id, compromisso);

                CarregarCompromissos();
            }
        }

        public override void Excluir()
        {
            Compromisso compromisso = ObterCompromissoSelecionado();

            if (compromisso == null)
            {
                MessageBox.Show($"Selecione um contato primeiro!",
                    "Exclusão de Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o contato {compromisso.titulo}?", "Exclusão de Contatos",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCompromisso.Excluir(compromisso);

                CarregarCompromissos();
            }
        }

        private Compromisso ObterCompromissoSelecionado()
        {
            int id = tabelaCompromissos.ObterIdSelecionado();

            return repositorioCompromisso.SelecionarPorId(id);
        }

        public override void Filtrar()
        {
            TelaCompromissoFiltroForm telaFiltro = new TelaCompromissoFiltroForm();

            if (telaFiltro.ShowDialog() == DialogResult.OK)
            {
                StatusCompromissoEnum statusSelecionado = telaFiltro.StatusSelecionado;
                DateTime dataInicial = telaFiltro.DataInicial.Date;
                DateTime dataFinal = telaFiltro.DataFinal.Date;
                

                CarregarCompromissosComFiltro(statusSelecionado, dataInicial, dataFinal);
            }
        }

        public override UserControl ObterListagem()
        {
            if (tabelaCompromissos == null)
                tabelaCompromissos = new TabelaCompromissoControl();

            CarregarCompromissos();

            return tabelaCompromissos;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Compromisso";
        }

        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            tabelaCompromissos.AtualizarRegistros(compromissos);
        }

        private void CarregarCompromissosComFiltro(StatusCompromissoEnum statusSelecionado, DateTime dataInicial, DateTime dataFinal)
        {
            string tipoCompromisso;
            List<Compromisso> compromissos;

            switch (statusSelecionado)
            {
                case StatusCompromissoEnum.Futuro:
                    compromissos = repositorioCompromisso.SelecionarCompromissosFuturos(dataInicial, dataFinal);
                    tipoCompromisso = "futuros(s)";
                    break;

                case StatusCompromissoEnum.Passado:
                    compromissos = repositorioCompromisso.SelecionarCompromissosPassado();
                    tipoCompromisso = "passado(s)";
                    break;

                default:
                    compromissos = repositorioCompromisso.SelecionarTodos();
                    tipoCompromisso = " "; break;

            }
            tabelaCompromissos.AtualizarRegistros(compromissos);
        }
    }
}
