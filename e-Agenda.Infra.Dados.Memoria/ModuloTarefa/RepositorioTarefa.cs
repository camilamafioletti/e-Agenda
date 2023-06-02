using e_Agenda.Dominio.ModuloTarefa;
using e_Agenda.Infra.Dados.Memoria.Compartilhado;

namespace e_Agenda.Infra.Dados.Memoria.ModuloTarefa
{
    public class RepositorioTarefa : RepositorioBase<Tarefa>, IRepositorioTarefa
    {
        public RepositorioTarefa(List<Tarefa> tarefas)
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
