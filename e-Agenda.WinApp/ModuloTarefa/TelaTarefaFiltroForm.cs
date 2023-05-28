namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefaFiltroForm : Form
    {
        public TelaTarefaFiltroForm()
        {
            InitializeComponent();
        }

        public StatusTarefaEnum ObterFiltroTarefa()
        {
            {
                if (rdbTarefasPendentes.Checked)
                    return StatusTarefaEnum.Pendentes;

                else if (rdbTarefasFinalizadas.Checked)
                    return StatusTarefaEnum.Concluidas;

                else
                    return StatusTarefaEnum.Todos;
            }
        }
    }
}
