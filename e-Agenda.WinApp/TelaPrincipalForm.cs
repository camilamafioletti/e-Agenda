using e_Agenda.Dominio.ModuloCategoria;
using e_Agenda.Dominio.ModuloCompromisso;
using e_Agenda.Dominio.ModuloContato;
using e_Agenda.Dominio.ModuloDespesa;
using e_Agenda.Dominio.ModuloTarefa;
using e_Agenda.Infra.Dados.Arquivo.Compartilhado;
using e_Agenda.Infra.Dados.Arquivo.ModuloCategoria;
using e_Agenda.Infra.Dados.Arquivo.ModuloCompromisso;
using e_Agenda.Infra.Dados.Arquivo.ModuloContato;
using e_Agenda.Infra.Dados.Arquivo.ModuloDespesa;
using e_Agenda.Infra.Dados.Arquivo.ModuloTarefa;
using e_Agenda.WinApp.ModuloCategoria;
using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloDespesa;
using e_Agenda.WinApp.ModuloTarefa;

namespace e_Agenda.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;

        static ContextoDados contexto = new ContextoDados(carregarDados: true);

        private IRepositorioTarefa repositorioTarefa = new RepositorioTarefaEmArquivo(contexto);
        private IRepositorioDespesa repositorioDespesa = new RepositorioDespesaEmArquivo(contexto);
        private IRepositorioCategoria repositorioCategoria = new RepositorioCategoriaEmArquivo(contexto);
        private IRepositorioCompromisso repositorioCompromisso = new RepositorioCompromissoEmArquivo(contexto);
        private IRepositorioContato repositorioContato = new RepositorioContatoEmArquivo(contexto);


        private static TelaPrincipalForm telaPrincipal;

        public TelaPrincipalForm()
        {
            InitializeComponent();

            telaPrincipal = this;

        }

        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        public static TelaPrincipalForm Instancia
        {
            get
            {
                if (telaPrincipal == null)
                    telaPrincipal = new TelaPrincipalForm();

                return telaPrincipal;
            }
        }

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorContato(repositorioContato);

            ConfigurarTelaPrincipal(controlador);
        }

        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTarefa(repositorioTarefa);

            ConfigurarTelaPrincipal(controlador);
        }

        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCompromisso(repositorioCompromisso, repositorioContato);

            ConfigurarTelaPrincipal(controlador);
        }

        private void despesasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorDespesa(repositorioDespesa, repositorioCategoria);

            ConfigurarTelaPrincipal(controlador);
        }

        private void categoriasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCategoria(repositorioCategoria, repositorioDespesa);

            ConfigurarTelaPrincipal(controlador);
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            toolBar.Enabled = true;

            labelTipoCadastro.Text = controladorBase.ObterTipoCadastro();

            ConfigurarBarraFerramentas(controlador);

            ConfigurarListagem(controlador);
        }

        private void ConfigurarBarraFerramentas(ControladorBase controlador)
        {
            toolBar.Enabled = true;

            ConfigurarToolTips(controlador);

            ConfigurarBotoesHabilitados(controlador);
        }

        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(listagem);
        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
            btnFiltrar.ToolTipText = controlador.ToolTipFiltrar;
            btnAdicionarSubtarefas.ToolTipText = controlador.ToolTipAdicionarItens;
            btnChecharTarefas.ToolTipText = controlador.ToolTipConcluirItens;
            btnVisualizar.ToolTipText = controlador.ToolTipVisualizarCategorias;
        }

        private void ConfigurarBotoesHabilitados(ControladorBase controlador)
        {
            btnInserir.Enabled = controlador.InserirHabilitado;
            btnEditar.Enabled = controlador.EditarHabilitado;
            btnExcluir.Enabled = controlador.ExcluirHabilitado;
            btnFiltrar.Enabled = controlador.FiltrarHabilitado;
            btnAdicionarSubtarefas.Enabled = controlador.AdicionarHabilitado;
            btnChecharTarefas.Enabled = controlador.ConcluirHabilitado;
            btnVisualizar.Enabled = controlador.VisualizarHabilitado;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            controlador.Filtrar();
        }

        private void btnAdicionarSubtarefas_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            controlador.VisualizarCategorias();
        }

        private void btnChecharTarefas_Click(object sender, EventArgs e)
        {
            controlador.ConcluirItens();
        }
    }
}