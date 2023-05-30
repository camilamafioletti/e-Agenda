using e_Agenda.WinApp.ModuloCategoria;

namespace e_Agenda.WinApp.ModuloDespesa
{
    public class RepositorioDespesa : RepositorioBase<Despesa>
    {
        public RepositorioDespesa(List<Despesa> despesas)
        {
            this.listaRegistros = despesas;
        }

        public List<Despesa> ListarDespesasPorCategorias(Categoria categoria)
        {
            return listaRegistros.Where(d => d.categorias.Contains(categoria)).ToList();
        }
    }
}
