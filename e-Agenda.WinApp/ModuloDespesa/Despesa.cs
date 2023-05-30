using e_Agenda.WinApp.ModuloCategoria;
using System.Drawing;

namespace e_Agenda.WinApp.ModuloDespesa
{
    public class Despesa : EntidadeBase<Despesa>
    {
        public string descricao;
        public decimal valor;
        public DateTime data;
        public FormaPagamentoEnum tipoPagamento;

        public List<Categoria> categorias;

        public Despesa(string descricao, decimal valor, DateTime data, FormaPagamentoEnum tipoPagamento)
        {
            this.descricao = descricao;
            this.valor = valor;
            this.data = data;
            this.tipoPagamento = tipoPagamento;
            this.categorias = new List<Categoria>();
        }

        public override void AtualizarInformacoes(Despesa registroAtualizado)
        {
            this.descricao = registroAtualizado.descricao;
            this.valor = registroAtualizado.valor;  
            this.data = registroAtualizado.data;    
            this.tipoPagamento = registroAtualizado.tipoPagamento;
            this.categorias = registroAtualizado.categorias;
        }

        public override string[] Validar()
        {
            List<string> erros = new();

            if (categorias.Count == 0)
                erros.Add("É necessário incluir uma categoria");

            else if (descricao.Trim() == string.Empty)
                erros.Add("descrição não pode ser nulo");

            else if (valor <= 0)
                erros.Add("O valor não pode ser menor que 0");

            return erros.ToArray();
        }
        public override string ToString()
        {
            return descricao + " feita no dia " + data.ToString("dd/MM/yyyy");
        }
    }
}
