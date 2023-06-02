using e_Agenda.Dominio.Compartilhado;
using e_Agenda.Dominio.ModuloCategoria;
using e_Agenda.WinApp.ModuloDespesa;

namespace e_Agenda.Dominio.ModuloDespesa
{
    public interface IRepositorioDespesa : IRepositorioBase<Despesa>
    {
        public List<Despesa> ListarDespesasPorCategorias(Categoria categoria);
    }
}
