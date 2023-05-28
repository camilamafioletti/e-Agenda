namespace e_Agenda.WinApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }

        public abstract string ToolTipEditar { get; }

        public abstract string ToolTipExcluir { get; }

        public virtual string ToolTipFiltrar { get; }

        public virtual string ToolTipAdicionarItens { get; }

        public virtual string ToolTipConcluirItens { get; }

        public abstract void Inserir();

        public abstract void Editar();

        public abstract void Excluir();

        public virtual void Filtrar()
        {
        }

        public virtual void Adicionar()
        {
        }

        public virtual void ConcluirItens()
        {
        }

        public abstract UserControl ObterListagem();

        public abstract string ObterTipoCadastro();
    }

}
