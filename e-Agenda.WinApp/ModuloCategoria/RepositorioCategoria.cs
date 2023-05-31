namespace e_Agenda.WinApp.ModuloCategoria
{
    public class RepositorioCategoria : RepositorioBase<Categoria>, IRepositorioCategoria
    {
        public RepositorioCategoria(List<Categoria> listaCategorias)
        {
            this.listaRegistros = listaCategorias;
        }
    }
}
