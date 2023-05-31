namespace e_Agenda.WinApp.ModuloCategoria
{
    public class RepositorioCategoriaEmArquivo : RepositorioArquivoBase<Categoria>, IRepositorioCategoria
    {
        public RepositorioCategoriaEmArquivo()
        {
            NOME_ARQUIVO = "D:\\Arquivos\\Programas\\e-Agenda-2023-master\\e-Agenda-2023-master\\Arquivos\\categoria.bin";

            if (File.Exists(NOME_ARQUIVO))
                CarregarRegistrosDoArquivo();
        }
    }
}
