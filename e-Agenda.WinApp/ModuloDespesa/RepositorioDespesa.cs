using e_Agenda.WinApp.ModuloCategoria;
using e_Agenda.WinApp.ModuloDespesa;

namespace e_Agenda.WinApp.ModuloDespesas
{
    public class RepositorioDespesaEmMemoria : RepositorioBase<Despesa>
    {
        public RepositorioDespesaEmMemoria(List<Despesa> listaDespesas)
        {
            this.listaRegistros = listaDespesas;
        }

        public List<Despesa> ListarDespesasPorCategorias(Categoria categoria)
        {
            return listaRegistros.Where(d => d.categorias.Contains(categoria)).ToList();
        }
    }
}
