using ControleBar.Dominio.ModuloProduto;
using ControleBar.WinApp.Compartilhado;

namespace ControleBar.WinApp.ModuloProduto;

public class ControladorProduto : ControladorBase
{
    private readonly IRepositorioProduto repositorioProduto;
    private TabelaProdutoControl tabelaProduto;

    public ControladorProduto(IRepositorioProduto repositorioProduto)
    {
        this.repositorioProduto = repositorioProduto;
    }

    public override string TipoCadastro => "Produto";

    public override string ToolTipAdicionar => "Adicionar um produto.";

    public override string ToolTipEditar => "Editar um produto existente.";

    public override string ToolTipExcluir => "Remover um produto existente.";

    public override void Adicionar()
    {
        var ProdutosCadastradas = repositorioProduto.SelecionarTodos();

        var telaProduto = new TelaProdutoForm(ProdutosCadastradas);

        var resultado = telaProduto.ShowDialog();

        if (resultado != DialogResult.OK)
            return;

        var novoRegistro = telaProduto.Produto;

        repositorioProduto.Cadastrar(novoRegistro);

        CarregarRegistros();

        TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoRegistro.Nome}\" foi criado com sucesso!");
    }

    public override void Editar()
    {
        var idSelecionado = tabelaProduto.ObterRegistroSelecionado();

        var ProdutoSelecionado = repositorioProduto.SelecionarPorId(idSelecionado);

        if (ProdutoSelecionado == null)
        {
            MessageBox.Show(
                "Você precisa selecionar um registro para executar esta ação!",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        var ProdutosCadastradas = repositorioProduto.SelecionarTodos();

        var telaProduto = new TelaProdutoForm(ProdutosCadastradas);

        telaProduto.Produto = ProdutoSelecionado;

        var resultado = telaProduto.ShowDialog();

        if (resultado != DialogResult.OK)
            return;

        var registroEditado = telaProduto.Produto;

        repositorioProduto.Editar(idSelecionado, registroEditado);

        CarregarRegistros();

        TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{registroEditado.Nome}\" foi editado com sucesso!");
    }

    public override void Excluir()
    {
        var idSelecionado = tabelaProduto.ObterRegistroSelecionado();

        var ProdutoSelecionado = repositorioProduto.SelecionarPorId(idSelecionado);

        if (ProdutoSelecionado == null)
        {
            MessageBox.Show(
                "Você precisa selecionar um registro para executar esta ação!",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        var resposta = MessageBox.Show(
            $"Você deseja realmente excluir o registro \"{ProdutoSelecionado.Nome}\" ",
            "Confirmar Exclusão",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        );

        if (resposta != DialogResult.Yes)
            return;

        repositorioProduto.Excluir(idSelecionado);

        CarregarRegistros();

        TelaPrincipalForm.Instancia.AtualizarRodape(
            $"O registro \"{ProdutoSelecionado.Nome}\" foi excluído com sucesso!");
    }

    public override UserControl ObterListagem()
    {
        if (tabelaProduto == null)
            tabelaProduto = new TabelaProdutoControl();

        CarregarRegistros();

        return tabelaProduto;
    }

    public override void CarregarRegistros()
    {
        var produtos = repositorioProduto.SelecionarTodos();

        tabelaProduto.AtualizarRegistros(produtos);
        AtualizarQuantidadeRodape();
    }

    private void AtualizarQuantidadeRodape()
    {
        TelaPrincipalForm.Instancia.AtualizarRodape(
            $"Visualizando {repositorioProduto.SelecionarTodos().Count} registro(s)...");
    }
}