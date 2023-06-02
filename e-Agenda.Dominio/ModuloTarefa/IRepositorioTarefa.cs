using e_Agenda.Dominio.Compartilhado;

namespace e_Agenda.Dominio.ModuloTarefa
{
    public interface IRepositorioTarefa : IRepositorioBase<Tarefa>
    {
        List<Tarefa> SelecionarConcluidas();
        List<Tarefa> SelecionarPendentes();
        List<Tarefa> SelecionarOrdenadoPorPrioridade();
    }
}
