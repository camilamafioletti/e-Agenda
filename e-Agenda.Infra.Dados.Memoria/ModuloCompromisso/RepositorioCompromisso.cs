using e_Agenda.Dominio.ModuloCompromisso;
using e_Agenda.Infra.Dados.Memoria.Compartilhado;

namespace e_Agenda.Infra.Dados.Memoria.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>, IRepositorioCompromisso
    {
        public RepositorioCompromisso(List<Compromisso> compromissos)
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
