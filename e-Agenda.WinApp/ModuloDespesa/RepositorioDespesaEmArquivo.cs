using e_Agenda.WinApp.ModuloCategoria;
using e_Agenda.WinApp.ModuloDespesa;

namespace e_Agenda.WinApp.ModuloDespesas
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