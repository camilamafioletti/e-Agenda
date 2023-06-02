using e_Agenda.WinApp.ModuloCategoria;

namespace e_Agenda.WinApp.ModuloDespesa
{
    public class RepositorioDespesaEmArquivo : RepositorioArquivoBase<Despesa>, IRepositorioDespesa
    {
        public RepositorioDespesaEmArquivo(ContextoDados contexto) : base(contexto)
        {

        }
        public List<Despesa> ListarDespesasPorCategorias(Categoria categoria)
        {
            return ObterRegistros()
                .Where(d => d.categorias
                .Contains(categoria))
                .ToList();
        }

        protected override List<Despesa> ObterRegistros()
        {
            return contextoDados.despesas;
        }
    }
}