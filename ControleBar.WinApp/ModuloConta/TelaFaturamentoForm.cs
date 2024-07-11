using ControleBar.Dominio.ModuloConta;
using ControleBar.WinApp.Compartilhado;

namespace ControleBar.WinApp.ModuloConta;

public partial class TelaFaturamentoForm : Form
{
    private readonly List<Conta> contas;

    public TelaFaturamentoForm(List<Conta> contas)
    {
        InitializeComponent();
        this.ConfigurarDialog();

        this.contas = contas;
        rdbDia.Checked = true;
    }

    private void RealizaFaturamento(string condicao)
    {
        double valor = 0;

        if (condicao == "dia")
        {
            foreach (var C in contas.FindAll(x => x.DataConclusao.Date == DateTime.Now.Date)) valor += C.ValorTotal;
        }

        else if (condicao == "semana")
        {
            var semana = DateTime.Now.AddDays(-7);

            foreach (var c in contas.FindAll(x => x.DataConclusao.Date >= semana.Date)) valor += c.ValorTotal;
        }

        else if (condicao == "mes")
        {
            foreach (var c in contas.FindAll(x => x.DataConclusao.Month == DateTime.Now.Month)) valor += c.ValorTotal;
        }

        txtLucro.Text = valor.ToString();
    }

    private void rdbDia_CheckedChanged(object sender, EventArgs e)
    {
        RealizaFaturamento("dia");
    }

    private void rdbSemana_CheckedChanged(object sender, EventArgs e)
    {
        RealizaFaturamento("semana");
    }

    private void rdbMes_CheckedChanged(object sender, EventArgs e)
    {
        RealizaFaturamento("mes");
    }
}