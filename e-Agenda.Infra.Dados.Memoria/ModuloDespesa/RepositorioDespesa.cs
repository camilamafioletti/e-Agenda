using e_Agenda.Dominio.ModuloCategoria;
using e_Agenda.Infra.Dados.Memoria.Compartilhado;
using e_Agenda.WinApp.ModuloDespesa;

namespace e_Agenda.Infra.Dados.Memoria.ModuloDespesa
{
    public class RepositorioDespesa : RepositorioBase<Despesa>
    {
        public RepositorioDespesa(List<Despesa> listaDespesas)
        {
            listaRegistros = listaDespesas;
        }

        public List<Despesa> ListarDespesasPorCategorias(Categoria categoria)
        {
            return listaRegistros.Where(d => d.categorias.Contains(categoria)).ToList();
        }
    }
}
