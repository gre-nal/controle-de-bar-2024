using ControleBar.Dominio.ModuloConta;
using ControleBar.Dominio.ModuloProduto;
using ControleBar.WinApp.Compartilhado;

namespace ControleBar.WinApp.ModuloConta;

public partial class TelaPedidoForm : Form
{
    private Conta conta;

    public TelaPedidoForm(List<Produto> produtos)
    {
        InitializeComponent();
        this.ConfigurarDialog();
        CarregarProdutos(produtos);
    }

    public Conta Conta
    {
        get => conta;
        set
        {
            conta = value;

            foreach (var p in conta.Pedidos) ListaPedidos.Items.Add(p);
        }
    }

    private void CarregarProdutos(List<Produto> produtos)
    {
        foreach (var produto in produtos) cmbProdutos.Items.Add(produto);
    }

    private void btnAdicionar_Click(object sender, EventArgs e)
    {
        var prod = (Produto)cmbProdutos.SelectedItem;
        var quantidade = (int)NumQuantidade.Value;

        var pedido = new Pedido(prod, quantidade);

        var erros = pedido.Validar();

        if (erros.Count > 0)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
            return;
        }

        ListaPedidos.Items.Add(pedido);
    }

    private void btnRemover_Click(object sender, EventArgs e)
    {
        if (ListaPedidos.SelectedItem != null)
            ListaPedidos.Items.Remove(ListaPedidos.SelectedItem);
    }

    private void btnGravar_Click(object sender, EventArgs e)
    {
        var pedidos = new List<Pedido>();

        foreach (Pedido p in ListaPedidos.Items) pedidos.Add(p);

        conta.Pedidos = pedidos;
        conta.CalcularValorTotal();
    }
}