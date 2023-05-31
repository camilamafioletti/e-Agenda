namespace e_Agenda.WinApp.ModuloTarefa
{
    public interface IRepositorioTarefa : IRepositorioBase<Tarefa>
    {
        List<Tarefa> SelecionarConcluidas();
        List<Tarefa> SelecionarPendentes();
        List<Tarefa> SelecionarOrdenadoPorPrioridade();
    }
}
