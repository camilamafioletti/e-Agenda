using e_Agenda.WinApp.ModuloCategoria;

namespace e_Agenda.WinApp.ModuloDespesa
{
    public class RepositorioDespesaEmArquivo : RepositorioArquivoBase<Despesa>, IRepositorioDespesa
    {

        private const string NOME_ARQUIVO_DESPESAS = "despesas.bin";


        public RepositorioDespesaEmArquivo()
        {
            if (File.Exists(NOME_ARQUIVO_DESPESAS))
                CarregarRegistrosDoArquivo(NOME_ARQUIVO_DESPESAS);
        }

        public void Editar(int id, Despesa despesa)
        {
            Despesa despesaSelecionada = SelecionarPorId(id);

            despesaSelecionada.AtualizarInformacoes(despesa);

            GravarTarefasEmArquivo(NOME_ARQUIVO_DESPESAS);
        }

        public void Excluir(Despesa despesaSelecionada)
        {
            listaRegistros.Remove(despesaSelecionada);

            GravarTarefasEmArquivo(NOME_ARQUIVO_DESPESAS);
        }

        public void Inserir(Despesa novaDespesa)
        {
            contadorRegistros++;
            novaDespesa.id = contadorRegistros;
            listaRegistros.Add(novaDespesa);

            GravarTarefasEmArquivo(NOME_ARQUIVO_DESPESAS);
        }

        public List<Despesa> ListarDespesasPorCategorias(Categoria categoria)
        {
            return listaRegistros.Where(d => d.categorias.Contains(categoria)).ToList();
        }

        public Despesa SelecionarPorId(int id)
        {
            Despesa despesa = listaRegistros.FirstOrDefault(x => x.id == id);

            return despesa;
        }

        public List<Despesa> SelecionarTodos()
        {
            return listaRegistros;
        }
    }
}
