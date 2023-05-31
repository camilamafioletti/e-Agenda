namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromissoEmArquivo : RepositorioArquivoBase<Compromisso>, IRepositorioCompromisso
    {

        private const string NOME_ARQUIVO_COMPROMISSO = "compromisso.bin";

        public RepositorioCompromissoEmArquivo()
        {
            if (File.Exists(NOME_ARQUIVO_COMPROMISSO))
                CarregarRegistrosDoArquivo(NOME_ARQUIVO_COMPROMISSO);
        }

        public void Editar(int id, Compromisso compromisso)
        {
            Compromisso compromissoSelecionado = SelecionarPorId(id);

            compromissoSelecionado.AtualizarInformacoes(compromisso);

            GravarTarefasEmArquivo(NOME_ARQUIVO_COMPROMISSO);
        }

        public void Excluir(Compromisso compromissoSelecionado)
        {
            listaRegistros.Remove(compromissoSelecionado);

            GravarTarefasEmArquivo(NOME_ARQUIVO_COMPROMISSO);
        }

        public void Inserir(Compromisso novoCompromisso)
        {
            contadorRegistros++;
            novoCompromisso.id = contadorRegistros;
            listaRegistros.Add(novoCompromisso);

            GravarTarefasEmArquivo(NOME_ARQUIVO_COMPROMISSO);
        }

        public Compromisso SelecionarPorId(int id)
        {

            Compromisso compromisso = listaRegistros.FirstOrDefault(x => x.id == id);

            return compromisso;
        }

        public List<Compromisso> SelecionarTodos()
        {
            return listaRegistros;
        }

        public List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicial, DateTime dataFinal)
        {
            List<Compromisso> compromissosFuturos = new List<Compromisso>();

            foreach (Compromisso item in listaRegistros)
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

            foreach (Compromisso item in listaRegistros)
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
