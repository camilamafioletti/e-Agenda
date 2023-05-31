using System.Runtime.Serialization.Formatters.Binary;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class RepositorioTarefaEmArquivo : RepositorioArquivoBase<Tarefa>, IRepositorioTarefa
    {

        private const string NOME_ARQUIVO_TAREFAS = "tarefas.bin";



        public RepositorioTarefaEmArquivo()
        {
            if (File.Exists(NOME_ARQUIVO_TAREFAS))
                CarregarRegistrosDoArquivo(NOME_ARQUIVO_TAREFAS);
        }

        public void Editar(int id, Tarefa tarefa)
        {
            Tarefa tarefaSelecionada = SelecionarPorId(id);

            tarefaSelecionada.AtualizarInformacoes(tarefa);

            GravarTarefasEmArquivo(NOME_ARQUIVO_TAREFAS);
        }

        public void Excluir(Tarefa tarefaSelecionada)
        {
            listaRegistros.Remove(tarefaSelecionada);

            GravarTarefasEmArquivo(NOME_ARQUIVO_TAREFAS);
        }

        public void Inserir(Tarefa novaTarefa)
        {
            contadorRegistros++;
            novaTarefa.id = contadorRegistros;
            listaRegistros.Add(novaTarefa);

            GravarTarefasEmArquivo(NOME_ARQUIVO_TAREFAS);
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

        public Tarefa SelecionarPorId(int id)
        {
            Tarefa tarefa = listaRegistros.FirstOrDefault(x => x.id == id);

            return tarefa;
        }

        public List<Tarefa> SelecionarPorPrioridade()
        {
            return listaRegistros
                   .OrderByDescending(x => x.prioridade)
                   .ToList();
        }

        public List<Tarefa> SelecionarTodos()
        {
            return listaRegistros;
        }

    }
}
