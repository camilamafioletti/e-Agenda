namespace e_Agenda.WinApp.ModuloContato
{
    public interface IRepositorioContato
    {
        void Inserir(Contato novoContato);
        void Editar(int id, Contato contato);
        void Excluir(Contato contataSelecionado);

        Contato SelecionarPorId(int id);
        List<Contato> SelecionarTodos();

    }
}
