using ControleBar.Dominio.ModuloConta;
using ControleBar.Dominio.ModuloGarcom;
using ControleBar.Dominio.ModuloMesa;
using ControleBar.Dominio.ModuloProduto;
using ControleBar.WinApp.Compartilhado;

namespace ControleBar.WinApp.ModuloConta;

public class ControladorConta : ControladorBase,
    ControladorBase.IControladorAdicionar,
    ControladorBase.IControladorConcluir,
    ControladorBase.IControladorEmAberto,
    ControladorBase.IControladorFaturamento
{
    private readonly IRepositorioConta repositorioConta;
    private readonly IRepositorioGarcom repositorioGarcom;
    private readonly IRepositorioMesa repositorioMesa;
    private readonly IRepositorioProduto repositorioProduto;
    private IRepositorioPedido repositorioPedido;
    private TabelaContaControl tabelaConta;

    public ControladorConta(IRepositorioConta repositorioConta, IRepositorioMesa repositorioMesa,
        IRepositorioPedido repositorioPedido, IRepositorioGarcom repositorioGarcom,
        IRepositorioProduto repositorioProduto)
    {
        this.repositorioConta = repositorioConta;
        this.repositorioProduto = repositorioProduto;
        this.repositorioGarcom = repositorioGarcom;
        this.repositorioMesa = repositorioMesa;
        this.repositorioPedido = repositorioPedido;
    }

    public override string TipoCadastro => "Conta";

    public override string ToolTipAdicionar => "Cadastrar uma nova Conta";

    public override string ToolTipEditar => "Editar uma Conta existente";

    public override string ToolTipExcluir => "Excluir uma Conta existente";

    public string ToolTipAdicionarItem => "Adicionar um pedido a conta.";

    public void AdicionarItem()
    {
        var idSelecionado = tabelaConta.ObterRegistroSelecionado();

        var contaSelecionada = repositorioConta.SelecionarPorId(idSelecionado);

        if (contaSelecionada == null)
        {
            MessageBox.Show(
                "Você precisa selecionar um registro para executar esta ação!",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        if (contaSelecionada.Concluida)
        {
            MessageBox.Show(
                "Você não pode adicionar pedidos a uma conta concluída!",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        var telaFechamento = new TelaPedidoForm(repositorioProduto.SelecionarTodos());

        telaFechamento.Conta = contaSelecionada;

        var resultado = telaFechamento.ShowDialog();

        if (resultado != DialogResult.OK)
            return;


        var registroEditado = telaFechamento.Conta;

        repositorioConta.Editar(idSelecionado, registroEditado);

        CarregarRegistros();

        TelaPrincipalForm.Instancia.AtualizarRodape(
            $"Os pedidos na Conta de Id \"{registroEditado.Id}\" foram adicionados com sucesso!");
    }

    public string ToolTipConcluir => "Conclui uma conta em aberto.";

    public void Concluir()
    {
        var idSelecionado = tabelaConta.ObterRegistroSelecionado();

        var contaSelecionada = repositorioConta.SelecionarPorId(idSelecionado);

        if (contaSelecionada == null)
        {
            MessageBox.Show(
                "Você precisa selecionar um registro para executar esta ação!",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        if (contaSelecionada.Concluida)
        {
            MessageBox.Show(
                "Você não pode concluir uma conta já fechada!",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        var telaFechamento = new TelaFechamentoForm();

        telaFechamento.Conta = contaSelecionada;

        contaSelecionada.Mesa.Ocupada = false;

        var resultado = telaFechamento.ShowDialog();

        if (resultado != DialogResult.OK)
            return;


        var registroEditado = telaFechamento.Conta;

        repositorioConta.Editar(idSelecionado, registroEditado);

        CarregarRegistros();

        TelaPrincipalForm.Instancia.AtualizarRodape($"A Conta de Id \"{registroEditado.Id}\" foi fechada com sucesso!");
    }

    public string ToolTipVisualizarEmAberto => "Visualizar as contas em aberto.";

    public void VisualizarEmAberto(ToolStripButton btn)
    {
        if (btn.BackColor != Control.DefaultBackColor)
        {
            btn.BackColor = Control.DefaultBackColor;
            CarregarRegistros();
            return;
        }

        btn.BackColor = Color.LightSkyBlue;
        var contas = repositorioConta.SelecionarEmAberto();
        tabelaConta.AtualizarRegistros(contas);
        AtualizarQuantidadeRodape(contas);
    }

    public string ToolTipFaturamento => "Visualizar o faturamento.";

    public void Faturamento()
    {
        var telaFaturamento = new TelaFaturamentoForm(repositorioConta.SelecionarTodos());

        telaFaturamento.ShowDialog();
    }

    public override void Adicionar()
    {
        var contaCadastradas = repositorioConta.SelecionarTodos();

        var telaConta = new TelaContaForm(repositorioGarcom.SelecionarTodos(), repositorioMesa.SelecionarTodos());

        var resultado = telaConta.ShowDialog();

        if (resultado != DialogResult.OK)
            return;

        var novoRegistro = telaConta.Conta;

        novoRegistro.Mesa.Ocupada = true;

        repositorioConta.Cadastrar(novoRegistro);

        CarregarRegistros();

        TelaPrincipalForm.Instancia.AtualizarRodape($"A Conta de ID \"{novoRegistro.Id}\" foi criada com sucesso!");
    }

    public override void Editar()
    {
        var idSelecionado = tabelaConta.ObterRegistroSelecionado();

        var contaSelecionada = repositorioConta.SelecionarPorId(idSelecionado);

        if (contaSelecionada == null)
        {
            MessageBox.Show(
                "Você precisa selecionar um registro para executar esta ação!",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        if (contaSelecionada.Concluida)
        {
            MessageBox.Show(
                "Você não pode editar uma conta já fechada!",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        var contaCadastradas = repositorioConta.SelecionarTodos();

        var telaConta = new TelaContaForm(repositorioGarcom.SelecionarTodos(), repositorioMesa.SelecionarTodos());

        telaConta.Conta = contaSelecionada;

        contaSelecionada.Mesa.Ocupada = false;
        repositorioMesa.Editar(contaSelecionada.Mesa.Id, contaSelecionada.Mesa);

        var resultado = telaConta.ShowDialog();

        if (resultado != DialogResult.OK)
            return;


        var registroEditado = telaConta.Conta;

        registroEditado.Mesa.Ocupada = true;
        repositorioConta.Editar(idSelecionado, registroEditado);

        CarregarRegistros();

        TelaPrincipalForm.Instancia.AtualizarRodape($"A Conta de Id \"{registroEditado.Id}\" foi editada com sucesso!");
    }

    public override void Excluir()
    {
        var idSelecionado = tabelaConta.ObterRegistroSelecionado();

        var contaSelecionada = repositorioConta.SelecionarPorId(idSelecionado);

        if (contaSelecionada == null)
        {
            MessageBox.Show(
                "Você precisa selecionar um registro para executar esta ação!",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        var resposta = MessageBox.Show(
            $"Você deseja realmente excluir a conta de Id \"{contaSelecionada.Id}\" ",
            "Confirmar Exclusão",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        );

        if (resposta != DialogResult.Yes)
            return;

        contaSelecionada.Mesa.Ocupada = false;
        repositorioConta.Excluir(idSelecionado);

        CarregarRegistros();

        TelaPrincipalForm.Instancia.AtualizarRodape(
            $"A Conta de Id\"{contaSelecionada.Id}\" foi excluída com sucesso!");
    }

    public override UserControl ObterListagem()
    {
        if (tabelaConta == null)
            tabelaConta = new TabelaContaControl();

        CarregarRegistros();

        return tabelaConta;
    }

    public override void CarregarRegistros()
    {
        var contas = repositorioConta.SelecionarTodos();

        tabelaConta.AtualizarRegistros(contas);
        AtualizarQuantidadeRodape(contas);
    }

    private void AtualizarQuantidadeRodape(List<Conta> contas)
    {
        TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {contas.Count} registro(s)...");
    }
}