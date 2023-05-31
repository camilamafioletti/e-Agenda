namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>, IRepositorioCompromisso
    {
        List<Compromisso> compromissos = new List<Compromisso>();

        public RepositorioCompromisso()
        {
            this.listaRegistros = compromissos;
        }

        public List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicial, DateTime dataFinal)
        {
            List<Compromisso> compromissosFuturos = new List<Compromisso>();

            foreach (Compromisso item in compromissos)
            {
                if (item.data > dataInicial && item.data < dataFinal)
                {
                    compromissosFuturos.Add(item);
                }
            }
            return compromissosFuturos;
        }

        public List<Compromisso> SelecionarCompromissosPassado()
        {
            List<Compromisso> compromissosFuturos = new List<Compromisso>();

            foreach (Compromisso item in compromissos)
            {
                if (item.data < DateTime.Now.Date)
                {
                    compromissosFuturos.Add(item);
                }
            }
            return compromissosFuturos;
        }
    }
}