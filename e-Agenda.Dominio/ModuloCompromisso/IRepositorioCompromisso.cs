using e_Agenda.Dominio.Compartilhado;

namespace e_Agenda.Dominio.ModuloCompromisso
{
    public interface IRepositorioCompromisso : IRepositorioBase<Compromisso>
    {
        public List<Compromisso> SelecionarCompromissosPassados(DateTime hoje);

        public List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal);
    }
}
