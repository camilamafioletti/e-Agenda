using e_Agenda.Dominio.ModuloCategoria;
using e_Agenda.Infra.Dados.Memoria.Compartilhado;

namespace e_Agenda.Infra.Dados.Memoria.ModuloCategoria
{
    public class RepositorioCategoria : RepositorioBase<Categoria>, IRepositorioCategoria
    {
        public RepositorioCategoria(List<Categoria> listaCategorias)
        {
            this.listaRegistros = listaCategorias;
        }
    }
}
