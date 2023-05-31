using e_Agenda.WinApp.ModuloCategoria;
using e_Agenda.WinApp.ModuloDespesa;

namespace e_Agenda.WinApp.ModuloDespesas
{
    public class RepositorioDespesaEmArquivo : RepositorioArquivoBase<Despesa>, IRepositorioDespesa
    {
        public RepositorioDespesaEmArquivo()
        {
            NOME_ARQUIVO = "D:\\Arquivos\\Programas\\e-Agenda-2023-master\\e-Agenda-2023-master\\Arquivos\\despesa.bin";

            if (File.Exists(NOME_ARQUIVO))
                CarregarRegistrosDoArquivo();
        }
        public List<Despesa> ListarDespesasPorCategorias(Categoria categoria)
        {
            return listaRegistros.Where(d => d.categorias.Contains(categoria)).ToList();
        }
    }
}