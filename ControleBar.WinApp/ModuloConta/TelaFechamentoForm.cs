using ControleBar.Dominio.ModuloConta;
using ControleBar.WinApp.Compartilhado;

namespace ControleBar.WinApp.ModuloConta;

public partial class TelaFechamentoForm : Form
{
    private Conta conta;

    public TelaFechamentoForm()
    {
        InitializeComponent();
        this.ConfigurarDialog();
    }

    public Conta Conta
    {
        get => conta;
        set
        {
            conta = value;
            txtMesa.Text = "" + value.Mesa;
            txtGarcom.Text = "" + value.Garcom;
            foreach (var p in value.Pedidos) ListaPedidos.Items.Add(p);
            txtPreco.Text = "" + value.ValorTotal;
        }
    }

    private void btnConcluir_Click(object sender, EventArgs e)
    {
        conta.Mesa.Ocupada = false;
        conta.Concluir();
    }
}