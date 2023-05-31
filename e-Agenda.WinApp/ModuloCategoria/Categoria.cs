using e_Agenda.WinApp.ModuloDespesa;

namespace e_Agenda.WinApp.ModuloCategoria
{
    [Serializable]
    public class Categoria : EntidadeBase<Categoria>
    {

        public string titulo;
        public List<Despesa> despesas;

        public Categoria(string titulo)
        {
            this.titulo = titulo;
            this.despesas = new List<Despesa>();
        }

        public override void AtualizarInformacoes(Categoria registroAtualizado)
        {
            titulo = registroAtualizado.titulo;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();
            if (titulo.Trim() == "")
            {
                erros.Add("Título não pode ser nulo");
            }
            return erros.ToArray();
        }

        public override bool Equals(object? obj)
        {
            return obj is Categoria categoria &&
                   id == categoria.id &&
                   titulo == categoria.titulo;
        }

        public override string ToString()
        {
            return titulo;
        }
    }
}
