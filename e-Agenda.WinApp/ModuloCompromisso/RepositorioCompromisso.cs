namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromissoEmMemoria : RepositorioBase<Compromisso>, IRepositorioCompromisso
    {
        public RepositorioCompromissoEmMemoria(List<Compromisso> compromissos)
        {
            this.listaRegistros = compromissos;
        }

        public List<Compromisso> SelecionarCompromissosPassados(DateTime hoje)
        {
            return listaRegistros.Where(x => x.data.Date < hoje.Date).ToList();
        }

        public List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal)
        {
            return listaRegistros
                .Where(x => x.data > dataInicio)
                .Where(x => x.data < dataFinal)
                .ToList();
        }
    }
}
