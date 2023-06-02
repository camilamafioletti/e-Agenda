using e_Agenda.Dominio.ModuloCompromisso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TelaCompromissoFiltroForm : Form
    {
        public TelaCompromissoFiltroForm()
        {
            InitializeComponent();
        }
        public StatusCompromissoEnum StatusSelecionado
        {
            get
            {
                if (rdbCompromissosPassados.Checked)
                    return StatusCompromissoEnum.Passado;

                else if (rdbCompromissosFuturos.Checked)
                    return StatusCompromissoEnum.Futuro;

                else
                    return StatusCompromissoEnum.Todos;
            }
        }
        public DateTime DataInicial
        {
            get { return txtDataInicial.Value; }
        }
        public DateTime DataFinal
        {
            get { return txtDataFinal.Value; }
        }

        private void rdbTodosCompromissos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTodosCompromissos.Checked)
            {
                GroupBoxFiltroFuturo.Enabled = false;
            }
        }

        private void rdbCompromissosPassados_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCompromissosPassados.Checked)
            {
                GroupBoxFiltroFuturo.Enabled = false;
            }
        }

        private void rdbCompromissosFuturos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCompromissosFuturos.Checked)
            {
                GroupBoxFiltroFuturo.Enabled = true;
            }
        }
    }
}
