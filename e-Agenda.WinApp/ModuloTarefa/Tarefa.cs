using e_Agenda.WinApp.Compartilhado;
using System.Collections;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class Tarefa : EntidadeBase<Tarefa>
    {
        public string titulo;
        public string prioridade;
        public DateTime dataCriacao;
        public DateTime dataConclusao;
        public double percentual;

        public ArrayList subTarefas = new ArrayList();

        public Tarefa(string titulo, string prioridade, DateTime dataCriacao)
        {
            this.titulo = titulo;
            this.prioridade = prioridade;
            this.dataCriacao = dataCriacao;
        }

        public override void AtualizarInformacoes(Tarefa registroAtualizado)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string statusConcluido;

            if (dataConclusao == null || dataConclusao < DateTime.Now.Date)
                statusConcluido = "Não Concluído";
            else
                statusConcluido = dataConclusao.Date.ToString("dd/MM/yyyy");

            return "Id: " + id
                + ", Titulo: " + titulo
                + ", Prioridade: " + prioridade
                + ", Data Criação: " + dataCriacao.Date.ToString("dd/MM/yyyy")
                + ", Data Conclusão: " + statusConcluido.ToString()
                + ", Percentual: " + percentual.ToString("F2");
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }
}
