using e_Agenda.Dominio.ModuloContato;
using e_Agenda.Infra.Dados.Memoria.Compartilhado;
using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.Infra.Dados.Memoria.ModuloContato
{
    public class RepositorioContato : RepositorioBase<Contato>, IRepositorioContato
    {
        public RepositorioContato(List<Contato> contatos)
        {
            this.listaRegistros = contatos;
        }
    }
}
