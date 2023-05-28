namespace e_Agenda.WinApp.ModuloCategoria
{
    public class Categoria : EntidadeBase<Categoria>
    {

        public string titulo;

        public Categoria(string titulo)
        {
            this.titulo = titulo;
        }

        public override void AtualizarInformacoes(Categoria registroAtualizado)
        {
            titulo = registroAtualizado.titulo;
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }
}
