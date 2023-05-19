using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefaForm : Form
    {
        private Tarefa tarefa;

        public TelaTarefaForm()
        {
            InitializeComponent();
        }

        public Tarefa Tarefa
        {
            set
            {
                txtIdTarefa.Text = value.id.ToString();
                txtTitulo.Text = value.titulo;
                txtPrioridade.Text = value.prioridade;
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

            tarefa = new Tarefa(titulo, prioridade);

            if (txtIdTarefa.Text != "0")
                tarefa.id = Convert.ToInt32(txtIdTarefa.Text);
        }
    }
}

