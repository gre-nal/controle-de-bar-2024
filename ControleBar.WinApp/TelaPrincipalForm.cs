using ControleBar.Dominio.ModuloConta;
using ControleBar.Dominio.ModuloGarcom;
using ControleBar.Dominio.ModuloMesa;
using ControleBar.Dominio.ModuloProduto;
using ControleBar.Infraestrutura.Orm.Compartilhado;
using ControleBar.Infraestrutura.Orm.ModuloConta;
using ControleBar.Infraestrutura.Orm.ModuloGarcom;
using ControleBar.Infraestrutura.Orm.ModuloMesa;
using ControleBar.Infraestrutura.Orm.ModuloProduto;
using ControleBar.WinApp.Compartilhado;
using ControleBar.WinApp.ModuloConta;
using ControleBar.WinApp.ModuloGarcom;
using ControleBar.WinApp.ModuloMesa;
using ControleBar.WinApp.ModuloProduto;

namespace ControleBar.WinApp;

public partial class TelaPrincipalForm : Form
{
    private readonly IRepositorioConta repositorioConta;
    private readonly IRepositorioGarcom repositorioGarcom;
    private readonly IRepositorioMesa repositorioMesa;
    private readonly IRepositorioPedido repositorioPedido;
    private readonly IRepositorioProduto repositorioProduto;
    private ControladorBase controlador;

    public TelaPrincipalForm()
    {
        InitializeComponent();
        Instancia = this;

        var dbContext = new ControleDeBarDbContext();
        repositorioProduto = new RepositorioProdutoEmOrm(dbContext);
        repositorioGarcom = new RepositorioGarcomEmOrm(dbContext);
        repositorioMesa = new RepositorioMesaEmOrm(dbContext);
        repositorioPedido = new RepositorioPedidoEmOrm(dbContext);
        repositorioConta = new RepositorioContaEmOrm(dbContext);
    }

    public static TelaPrincipalForm Instancia { get; private set; }

    private void garcomToolStripMenuItem_Click(object sender, EventArgs e)
    {
        controlador = new ControladorGarcom(repositorioGarcom);

        ConfigurarTelaPrincipal(controlador);
    }

    private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
    {
        controlador = new ControladorProduto(repositorioProduto);
        ConfigurarTelaPrincipal(controlador);
    }

    private void mesaToolStripMenuItem_Click(object sender, EventArgs e)
    {
        controlador = new ControladorMesa(repositorioMesa);
        ConfigurarTelaPrincipal(controlador);
    }

    private void contaToolStripMenuItem_Click(object sender, EventArgs e)
    {
        controlador = new ControladorConta(repositorioConta, repositorioMesa,
            repositorioPedido, repositorioGarcom, repositorioProduto);
        ConfigurarTelaPrincipal(controlador);
    }

    public void AtualizarRodape(string texto)
    {
        statusLabelPrincipal.Text = texto;
    }

    private void ConfigurarTelaPrincipal(ControladorBase controladorSelecionado)
    {
        lblTipoCadastro.Text = "Cadastro de " + controladorSelecionado.TipoCadastro;

        ConfigurarToolBox(controladorSelecionado);
        ConfigurarListagem(controladorSelecionado);
    }

    private void ConfigurarToolBox(ControladorBase controladorSelecionado)
    {
        btnAdicionar.Enabled = controladorSelecionado is ControladorBase;
        btnEditar.Enabled = controladorSelecionado is ControladorBase;
        btnRemover.Enabled = controladorSelecionado is ControladorBase;

        btnVisualizar.Enabled = controladorSelecionado is ControladorBase.IControladorEmAberto;
        btnRegistrarPedido.Enabled = controladorSelecionado is ControladorBase.IControladorAdicionar;
        btnFecharPedido.Enabled = controladorSelecionado is ControladorBase.IControladorConcluir;
        btnFaturamento.Enabled = controladorSelecionado is ControladorBase.IControladorFaturamento;
        ConfigurarToolTips(controladorSelecionado);
    }

    private void ConfigurarToolTips(ControladorBase controladorSelecionado)
    {
        btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
        btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
        btnRemover.ToolTipText = controladorSelecionado.ToolTipExcluir;

        if (controladorSelecionado is ControladorBase.IControladorEmAberto controladorVisualizavel)
            btnVisualizar.ToolTipText = controladorVisualizavel.ToolTipVisualizarEmAberto;

        if (controladorSelecionado is ControladorBase.IControladorFaturamento controladorFaturamento)
            btnFaturamento.ToolTipText = controladorFaturamento.ToolTipFaturamento;

        if (controladorSelecionado is ControladorBase.IControladorConcluir controladorConcluir)
            btnFecharPedido.ToolTipText = controladorConcluir.ToolTipConcluir;

        if (controladorSelecionado is ControladorBase.IControladorAdicionar controladorAdicionar)
            btnRegistrarPedido.ToolTipText = controladorAdicionar.ToolTipAdicionarItem;
    }

    private void ConfigurarListagem(ControladorBase controladorSelecionado)
    {
        var listagem = controladorSelecionado.ObterListagem();
        listagem.Dock = DockStyle.Fill;

        pnlRegistros.Controls.Clear();
        pnlRegistros.Controls.Add(listagem);
    }

    private void btnAdicionar_Click(object sender, EventArgs e)
    {
        controlador.Adicionar();
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
        controlador.Editar();
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
        controlador.Excluir();
    }

    private void btnVisualizar_Click(object sender, EventArgs e)
    {
        if (controlador is ControladorBase.IControladorEmAberto controladorVisualizavel)
            controladorVisualizavel.VisualizarEmAberto(btnVisualizar);
    }

    private void btn_AdicionarPedido_Click(object sender, EventArgs e)
    {
        if (controlador is ControladorBase.IControladorAdicionar controladorAdicionar)
            controladorAdicionar.AdicionarItem();
    }

    private void btn_FecharConta_Click(object sender, EventArgs e)
    {
        if (controlador is ControladorBase.IControladorConcluir controladorConcluir)
            controladorConcluir.Concluir();
    }

    private void btn_Faturamento_Click(object sender, EventArgs e)
    {
        if (controlador is ControladorBase.IControladorFaturamento controladorFaturamento)
            controladorFaturamento.Faturamento();
    }

    private void TelaPrincipalForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }

    private void homeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var telaInicial = new TelaPrincipalForm();
        telaInicial.Show();
        Hide();
    }
}