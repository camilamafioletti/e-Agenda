using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class Compromisso : EntidadeBase<Compromisso>
    {
        public Contato contato;
        public string titulo;
        public DateTime data;
        public DateTime dataInicio;
        public DateTime dataTermino;
        public string localizacao;
        public bool remoto;
        public bool presencial; 

        public Compromisso(Contato contato, string titulo, string localizacao, DateTime data, DateTime dataInicio, DateTime dataTermino, bool remoto, bool presencial)
        {
            this.contato = contato;
            this.titulo = titulo;
            this.localizacao = localizacao;
            this.data = data;
            this.dataInicio = dataInicio;
            this.dataTermino = dataTermino;
            this.remoto = remoto;
            this.presencial = presencial;
        }

        public override void AtualizarInformacoes(Compromisso registroAtualizado)
        {
            this.titulo = registroAtualizado.titulo;
            this.data = registroAtualizado.data;
            this.dataInicio = registroAtualizado.dataInicio;
            this.dataTermino = registroAtualizado.dataTermino;
            this.contato = registroAtualizado.contato;
            this.localizacao = registroAtualizado.localizacao;

        }

        public override string ToString()
        {
            string RemotoPresencial;
            string contato;

            if (remoto)
                RemotoPresencial = "Remoto";
            else
                RemotoPresencial = "Presencial";

            if (this.contato == null)
                contato = "Sem contato";
            else 
                contato = this.contato.nome;

            return "Id: " + id 
                + ", Titulo: " + titulo 
                + ", Local: " + localizacao 
                +", Data: " + data.ToString("dd/MM/yyyy") 
                + ", HoraInício: " + dataInicio.ToString("HH:mm") 
                +", HoraTérmino: " + dataTermino.ToString("HH:mm ") 
                + ", " + RemotoPresencial 
                + ", Contato: " + contato;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(titulo))
                erros.Add("O campo 'assunto' é obrigatório");

            return erros.ToArray();
        }
    }
}
