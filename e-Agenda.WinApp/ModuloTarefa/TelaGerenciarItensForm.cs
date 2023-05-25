using System.Collections;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaGerenciarItensForm : Form
    {
        internal Tarefa tarefa;

        public TelaGerenciarItensForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            ArrayList listaDeSubTarefas = new ArrayList();

            for (int i = 0; i < chListSubtarefa.Items.Count; i++)
            {
                listaDeSubTarefas.Add(chListSubtarefa.Items[i]);
            }


            CalcularPercentual();
        }

        private void btnAdicionarSub_Click_1(object sender, EventArgs e)
        {
            chListSubtarefa.Items.Add(txtSubtarefa.Text);
            txtSubtarefa.Text = "";
        }

        private void btnRemoverSub_Click_1(object sender, EventArgs e)
        {
            chListSubtarefa.Items.Remove(chListSubtarefa.SelectedItem);
        }

        public double CalcularPercentual()
        {
            double percentual;

            return percentual = (double)chListSubtarefa.CheckedItems.Count / chListSubtarefa.Items.Count * 100;
        }
    }
}
