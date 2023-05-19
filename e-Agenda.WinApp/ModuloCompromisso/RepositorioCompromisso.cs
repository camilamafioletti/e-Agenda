using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromisso
    {
        List<Compromisso> compromissos = new List<Compromisso>();
        private static int contador;

        public void Inserir(Compromisso compromisso)
        {
            contador++;
            compromisso.id = contador;
            compromissos.Add(compromisso);
        }

        public List<Compromisso> SelecionarTodos()
        {
            return compromissos;
        }

        public void Editar(Compromisso compromisso)
        {
            Compromisso compromissoSelecionado = SelecionarPorId(compromisso.id);

            compromissoSelecionado.titulo = compromisso.titulo;
            compromissoSelecionado.data = compromisso.data;
            compromissoSelecionado.dataInicio = compromisso.dataInicio;
            compromissoSelecionado.dataTermino = compromisso.dataTermino;
            compromissoSelecionado.localizacao = compromisso.localizacao;
            compromissoSelecionado.remoto = compromisso.remoto;
            compromissoSelecionado.presencial = compromisso.presencial;
            compromissoSelecionado.contato = compromisso.contato;
        }

        private Compromisso SelecionarPorId(int id)
        {
            return compromissos.FirstOrDefault(x => x.id == id);

        }

        public void Excluir(Compromisso compromisso)
        {
            compromissos.Remove(compromisso);
        }

        public List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicial, DateTime dataFinal)
        {
            List<Compromisso> compromissosFuturos = new List<Compromisso>();

            foreach (Compromisso item in compromissos)
            {
                if (item.data > dataInicial && item.data < dataFinal)
                {
                    compromissosFuturos.Add(item);
                }
            }
            return compromissosFuturos;
        }
        public List<Compromisso> SelecionarCompromissosPassado()
        {
            List<Compromisso> compromissosFuturos = new List<Compromisso>();

            foreach (Compromisso item in compromissos)
            {
                if (item.data < DateTime.Now.Date)
                {
                    compromissosFuturos.Add(item);
                }
            }
            return compromissosFuturos;
        }
    }
}

