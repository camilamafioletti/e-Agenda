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
    public partial class TelaTarefaFiltroForm : Form
    {
        public TelaTarefaFiltroForm()
        {
            InitializeComponent();
        }

        public StatusTarefaEnum StatusSelecionado
        {
            get
            {
                if (rdbTarefasPendentes.Checked)
                    return StatusTarefaEnum.Pendente;

                else if (rdbTarefasFinalizadas.Checked)
                    return StatusTarefaEnum.Concluido;

                else
                    return StatusTarefaEnum.Todos;
            }
        }
    }
}
