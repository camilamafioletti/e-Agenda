using Microsoft.Win32;

namespace e_Agenda.WinApp.ModuloDespesa
{
    public class RepositorioDespesa : RepositorioBase<Despesa>
    {

        public RepositorioDespesa(List<Despesa> despesas)
        {
            this.listaRegistros = despesas;
        }

    }
}
