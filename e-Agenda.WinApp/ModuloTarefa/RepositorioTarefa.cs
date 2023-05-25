namespace e_Agenda.WinApp.ModuloTarefa
{
    public class RepositorioTarefa : RepositorioBase<Tarefa>
    {
       
        List<Tarefa> tarefas = new List<Tarefa>();
        private static int contador;

        public void Inserir(Tarefa tarefa)
        {
            contador++;
            tarefa.id = contador;
            tarefas.Add(tarefa);

            ConcluirTarefa(tarefa);
        } 

        public List<Tarefa> SelecionarTodos()
        {
            return tarefas;
        }

        public void Editar(Tarefa tarefa)
        {
            Tarefa tarefaSelecionado = SelecionarPorId(tarefa.id);

            tarefaSelecionado.titulo = tarefa.titulo;
            tarefaSelecionado.prioridade = tarefa.prioridade;
            tarefaSelecionado.dataCriacao = tarefa.dataCriacao;
            //tarefaSelecionado.percentual = tarefa.percentual;
            //tarefaSelecionado.subTarefas = tarefa.subTarefas;

            //ConcluirTarefa(tarefaSelecionado);
        }

        public void Subtarefa(Tarefa tarefa)
        {
            Tarefa tarefaSelecionado = SelecionarPorId(tarefa.id);

            tarefaSelecionado.percentual = tarefa.percentual;
            tarefaSelecionado.subTarefas = tarefa.subTarefas;

            ConcluirTarefa(tarefaSelecionado);
        }

        public void Excluir(Tarefa tarefa)
        {
            tarefas.Remove(tarefa);
        }

        private Tarefa SelecionarPorId(int id)
        {
            return tarefas.FirstOrDefault(x => x.id == id);
        }

        public List<Tarefa> SelecionarTarefasCompletas()
        {
            List<Tarefa> tarefasConcluidas = new List<Tarefa>();

            foreach (Tarefa tarefa in tarefas)
            {
                if (tarefa.percentual == 100)
                {
                    tarefasConcluidas.Add(tarefa);
                }
            }
            return tarefasConcluidas;
        }

        public List<Tarefa> SelecionarTarefasPendentes()
        {
            List<Tarefa> tarefasPendentes = new List<Tarefa>();

            foreach (Tarefa tarefa in tarefas)
            {
                if (tarefa.percentual != 100)
                {
                    tarefasPendentes.Add(tarefa);
                }
            }
            return tarefasPendentes;
        }

        private void ConcluirTarefa(Tarefa tarefa)
        {
            if (tarefa.percentual == 100)
            {
                tarefa.dataConclusao = DateTime.Now.Date;
            }
        }
    }
}
