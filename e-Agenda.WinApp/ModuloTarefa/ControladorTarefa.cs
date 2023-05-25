using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase
    {
        private RepositorioTarefa repositorioTarefa;
        private ListagemTarefaControl listagemTarefa;

        public ControladorTarefa(RepositorioTarefa repositorioTarefa)
        {
            this.repositorioTarefa = repositorioTarefa;
        }

        public override string ToolTipInserir { get { return "Inserir nova Tarefa"; } }

        public override string ToolTipEditar { get { return "Editar Tarefa existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Tarefa existente"; } }

        public override void Inserir()
        {
            TelaTarefaForm telaTarefa = new TelaTarefaForm();

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tarefa tarefa = telaTarefa.Tarefa;
                repositorioTarefa.Inserir(tarefa);
                CarregarTarefas();
            }
        }

        public override void Editar()
        {
            Tarefa tarefa = listagemTarefa.ObterTarefaSelecionada();

            if (tarefa == null)
            {
                MessageBox.Show($"Selecione um tarefa primeiro!",
                    "Edição de Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaTarefaForm telaTarefa = new TelaTarefaForm();
            telaTarefa.Tarefa = tarefa;

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTarefa.Editar(telaTarefa.Tarefa);

                CarregarTarefas();
            }
        }

        public override void Excluir()
        {
            Tarefa tarefa = listagemTarefa.ObterTarefaSelecionada();

            if (tarefa == null)
            {
                MessageBox.Show($"Selecione uma tarefa primeiro!",
                    "Exclusão de Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a tarefa {tarefa.titulo}?", "Exclusão de Tarefas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTarefa.Excluir(tarefa);

                CarregarTarefas();
            }
        }

        public override UserControl ObterListagem()
        {
            if (listagemTarefa == null)
                listagemTarefa = new ListagemTarefaControl();

            CarregarTarefas();

            return listagemTarefa;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Tarefas";
        }

        public override void Filtrar()
        {
            TelaTarefaFiltroForm telaFiltro = new TelaTarefaFiltroForm();

            if (telaFiltro.ShowDialog() == DialogResult.OK)
            {
                StatusTarefaEnum statusSelecionado = telaFiltro.StatusSelecionado;

                CarregarTarefasComFiltro(statusSelecionado);
            }
        }

        public void CarregarTarefasComFiltro(StatusTarefaEnum statusSelecionado)
        {
            List<Tarefa> tarefas;

            switch (statusSelecionado)
            {
                case StatusTarefaEnum.Todos: tarefas = repositorioTarefa.SelecionarTodos(); break;
                case StatusTarefaEnum.Pendente: tarefas = repositorioTarefa.SelecionarTarefasPendentes(); break;
                case StatusTarefaEnum.Concluido: tarefas = repositorioTarefa.SelecionarTarefasCompletas(); break;
                default: tarefas = repositorioTarefa.SelecionarTodos(); break;
            }

            listagemTarefa.AtualizarRegistros(tarefas);
        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos();

            listagemTarefa.AtualizarRegistros(tarefas);
        }

        public void Subtarefas()
        {

            Tarefa tarefa = listagemTarefa.ObterTarefaSelecionada();

            if (tarefa == null)
            {
                MessageBox.Show($"Selecione um tarefa primeiro!",
                    "Edição de Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaGerenciarItensForm subTarefa = new TelaGerenciarItensForm();
            subTarefa.tarefa = tarefa;

            DialogResult opcaoEscolhida = subTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTarefa.Subtarefa(subTarefa.tarefa);

                CarregarTarefas();
            }
        }
    }
    
}
