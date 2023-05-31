namespace e_Agenda.WinApp.ModuloTarefa
{
    public class RepositorioTarefaEmArquivo : RepositorioArquivoBase<Tarefa>, IRepositorioTarefa
    {
        public RepositorioTarefaEmArquivo()
        {
            NOME_ARQUIVO = "D:\\Arquivos\\Programas\\e-Agenda-2023-master\\e-Agenda-2023-master\\Arquivos\\tarefa.bin";

            if (File.Exists(NOME_ARQUIVO))
                CarregarRegistrosDoArquivo();
        }

        public List<Tarefa> SelecionarConcluidas()
        {
            return listaRegistros
                    .Where(x => x.percentual == 100)
                    .ToList();
        }

        public List<Tarefa> SelecionarPendentes()
        {
            return listaRegistros
                    .Where(x => x.percentual < 100)
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

