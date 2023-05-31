namespace e_Agenda.WinApp.ModuloCompromisso
{
    public interface IRepositorioCompromisso
    {
        void Inserir(Compromisso novoCompromisso);
        void Editar(int id, Compromisso compromisso);
        void Excluir(Compromisso compromissoSelecionado);

        Compromisso SelecionarPorId(int id);
        List<Compromisso> SelecionarTodos();

        public List<Compromisso> SelecionarCompromissosPassado();
        public List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicial, DateTime dataFinal);
    }
}
