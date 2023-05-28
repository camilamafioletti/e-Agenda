namespace e_Agenda.WinApp.ModuloCategoria
{
    public class RepositorioCategoria : RepositorioBase<Categoria>
    {
        public RepositorioCategoria(List<Categoria> listaCategorias)
        {
            this.listaRegistros = listaCategorias;
        }
    }
}
