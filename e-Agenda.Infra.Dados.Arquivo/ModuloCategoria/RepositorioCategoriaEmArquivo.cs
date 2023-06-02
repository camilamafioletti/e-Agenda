using e_Agenda.Dominio.ModuloCategoria;
using e_Agenda.Dominio.ModuloContato;

namespace e_Agenda.Infra.Dados.Arquivo.ModuloCategoria
{
    public class RepositorioCategoriaEmArquivo : RepositorioArquivoBase<Categoria>, IRepositorioCategoria
    {
        public RepositorioCategoriaEmArquivo(ContextoDados contexto) : base(contexto)
        {

        }

        protected override List<Categoria> ObterRegistros()
        {
            return contextoDados.categorias;
        }
    }
}
