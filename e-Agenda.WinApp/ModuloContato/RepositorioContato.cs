namespace e_Agenda.WinApp.ModuloContato
{
    public class RepositorioContato : RepositorioBase<Contato>, IRepositorioContato
    {
        public RepositorioContato(List<Contato> contatos)
        {
            this.listaRegistros = contatos;
        }
    }
}
