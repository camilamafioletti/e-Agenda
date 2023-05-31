using e_Agenda.WinApp.ModuloCategoria;

namespace e_Agenda.WinApp.ModuloDespesa
{
    public interface IRepositorioDespesa
    {
        void Inserir(Despesa novaDespesa);
        void Editar(int id, Despesa despesa);
        void Excluir(Despesa despesaSelecionada);
        Despesa SelecionarPorId(int id);
        List<Despesa> SelecionarTodos();
        public List<Despesa> ListarDespesasPorCategorias(Categoria categoria);
    }
}
