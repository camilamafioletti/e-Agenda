using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace e_Agenda.WinApp.ModuloTarefa
{
    [Serializable]
    public class Tarefa : EntidadeBase<Tarefa>
    {
        public string titulo;
        public PrioridadeTarefaEnum prioridade;
        public DateTime dataCriacao;
        public List<ItemTarefa> items;
        public DateTime dataConclusao;
        public decimal percentual;

        public Tarefa(int id, string titulo, PrioridadeTarefaEnum prioridade, DateTime dataCriacao)
        {
            this.id = id;
            this.titulo = titulo;
            this.prioridade = prioridade;
            this.dataCriacao = dataCriacao;
            this.items = new List<ItemTarefa>();
        }

        public override void AtualizarInformacoes(Tarefa registroAtualizado)
        {
            this.id = registroAtualizado.id;
            this.titulo = registroAtualizado.titulo;
            this.prioridade = registroAtualizado.prioridade;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(titulo))
                erros.Add("O campo 'titulo' é obrigatório");

            return erros.ToArray();
        }
        public void AdicionarItem(ItemTarefa item)
        {
            items.Add(item);
        }

        public void ConcluirItem(ItemTarefa item)
        {
            ItemTarefa itemSelecionado = items.FirstOrDefault(x => x.Equals(item));

            itemSelecionado.Concluir();

            CalcularPercentualConcluido();
        }

        public void DesmarcarItem(ItemTarefa item)
        {
            ItemTarefa itemSelecionado = items.FirstOrDefault(x => x.Equals(item));

            itemSelecionado.Desmarcar();

            CalcularPercentualConcluido();
        }

        private void CalcularPercentualConcluido()
        {
            decimal qtdItens = items.Count();

            if (qtdItens == 0)
                return;
            
            decimal qtdConcluidos = items.Count(x => x.concluido == true);

            decimal resultado = (qtdConcluidos / qtdItens) * 100;

            percentual = Math.Round( resultado, 2);
        }
    }
}
