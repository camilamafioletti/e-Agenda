namespace e_Agenda.WinApp.ModuloCompromisso
{
    public interface IRepositorioCompromisso : IRepositorioBase<Compromisso>
    {
        public List<Compromisso> SelecionarCompromissosPassados(DateTime hoje);

        public List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal);
    }
}
