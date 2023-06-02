﻿using e_Agenda.Dominio.ModuloCompromisso;

namespace e_Agenda.Infra.Dados.Arquivo.ModuloCompromisso
{
    public class RepositorioCompromissoEmArquivo : RepositorioArquivoBase<Compromisso>, IRepositorioCompromisso
    {
        public RepositorioCompromissoEmArquivo(ContextoDados contexto) : base(contexto)
        {
           
        }

        public List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal)
        {
            return ObterRegistros()
                .Where(x => x.data > dataInicio)
                .Where(x => x.data < dataFinal)
                .ToList();
        }

        public List<Compromisso> SelecionarCompromissosPassados(DateTime hoje)
        {
            return ObterRegistros()
                .Where(x => x.data.Date < hoje.Date)
                .ToList();
        }

        protected override List<Compromisso> ObterRegistros()
        {
            return contextoDados.compromissos;
        }
    }
}
