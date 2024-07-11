using ControleBar.Dominio.ModuloProduto;
using ControleBar.WinApp.Compartilhado;

namespace ControleBar.WinApp.ModuloProduto;

public partial class TelaProdutoForm : Form
{
    private readonly List<Produto> produtosCadastrados;
    private Produto produto;

    public TelaProdutoForm(List<Produto> produtosCadastrados)
    {
        InitializeComponent();
        this.ConfigurarDialog();
        this.produtosCadastrados = produtosCadastrados;
    }

    public Produto Produto
    {
        get => produto;
        set
        {
            txtNome.Text = value.Nome;
            numPreco.Value = (decimal)value.Preco;
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var nome = txtNome.Text.Trim();
        var preco = (double)numPreco.Value;

        produto = new Produto(nome, preco);

        var erros = produto.Validar();

        if (ProdutoTemNomeDuplicado())
            erros.Add("Já existe um produto com este nome cadastrada, tente utilizar outro!");

        if (erros.Count > 0)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

            DialogResult = DialogResult.None;
        }
    }

    private bool ProdutoTemNomeDuplicado()
    {
        return produtosCadastrados.Any(d => d.Nome == produto.Nome);
    }
}