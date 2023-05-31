namespace e_Agenda.WinApp.ModuloContato
{
    public class RepositorioContatoEmArquivo : RepositorioArquivoBase<Contato>, IRepositorioContato
    {
        public RepositorioContatoEmArquivo()
        {
            NOME_ARQUIVO = "D:\\Arquivos\\Programas\\e-Agenda-2023-master\\e-Agenda-2023-master\\Arquivos\\contato.bin";

            if (File.Exists(NOME_ARQUIVO))
                CarregarRegistrosDoArquivo();
        }
    }
}
