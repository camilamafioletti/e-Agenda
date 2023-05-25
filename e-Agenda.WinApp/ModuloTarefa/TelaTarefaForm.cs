using System.Collections;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefaForm : Form
    {
        private List<Tarefa> ListaTarefasConcluidas = new List<Tarefa>();

        private Tarefa tarefa;

        public TelaTarefaForm()
        {
            InitializeComponent();
            RegularBoxPrioridade();
        }

        public Tarefa Tarefa
        {
            set
            {
                txtIdTarefa.Text = value.id.ToString();
                txtTitulo.Text = value.titulo;
                txtPrioridade.Text = value.prioridade;
                dateTimeCriacao.Value = value.dataCriacao;
                //chListSubtarefa.Items.AddRange(value.subTarefas.ToArray());
            }
            get
            {
                return tarefa;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;

            string prioridade = txtPrioridade.Text;

            DateTime dataCriacao = dateTimeCriacao.Value;

            tarefa = new Tarefa(titulo, prioridade, dataCriacao);

            if (txtIdTarefa.Text != "0")
                tarefa.id = Convert.ToInt32(txtIdTarefa.Text);
        }

        private void RegularBoxPrioridade()
        {
            txtPrioridade.Items.Add(PrioridadeTarefaEnum.Alta);
            txtPrioridade.Items.Add(PrioridadeTarefaEnum.Média);
            txtPrioridade.Items.Add(PrioridadeTarefaEnum.Baixa);
        }

        //private void btnAdicionarSub_Click(object sender, EventArgs e)
        //{
        //    chListSubtarefa.Items.Add(txtSubtarefa.Text);
        //    txtSubtarefa.Text = "";
        //}

        //private void btnRemoverSub_Click(object sender, EventArgs e)
        //{
        //    chListSubtarefa.Items.Remove(chListSubtarefa.SelectedItem);
        //}

        //public double CalcularPercentual()
        //{
        //    double percentual;

        //    return percentual = (double)chListSubtarefa.CheckedItems.Count / chListSubtarefa.Items.Count * 100;
        //}
    }
}

