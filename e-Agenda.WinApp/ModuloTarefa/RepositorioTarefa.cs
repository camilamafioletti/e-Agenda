namespace e_Agenda.WinApp.ModuloTarefa
{
    public class RepositorioTarefaEmMemoria : RepositorioBase<Tarefa>, IRepositorioTarefa
    {

        public RepositorioTarefaEmMemoria(List<Tarefa> tarefas)
        {
            listaRegistros = tarefas;
        }

        public List<Tarefa>? SelecionarConcluidas()
        {
            return listaRegistros
                .Where(x => x.percentual == 100)
                .OrderByDescending(x => x.prioridade)
                .ToList();
        }

        public List<Tarefa>? SelecionarPendentes()
        {
            return listaRegistros
                .Where(x => x.percentual < 100)
                .OrderByDescending(x => x.prioridade)
                .ToList();
        }

        public List<Tarefa> SelecionarOrdenadoPorPrioridade()
        {
            return listaRegistros
                .OrderByDescending(x => x.prioridade)
                .ToList();
        }
    }
}
