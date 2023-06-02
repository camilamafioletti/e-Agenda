using e_Agenda.WinApp.ModuloCategoria;

namespace e_Agenda.WinApp.ModuloDespesa
{
    public class RepositorioDespesaEmMemoria : RepositorioBase<Despesa>
    {
        public RepositorioDespesaEmMemoria(List<Despesa> listaDespesas)
        {
            listaRegistros = listaDespesas;
        }

        public List<Despesa> ListarDespesasPorCategorias(Categoria categoria)
        {
            return listaRegistros.Where(d => d.categorias.Contains(categoria)).ToList();
        }
    }
}
