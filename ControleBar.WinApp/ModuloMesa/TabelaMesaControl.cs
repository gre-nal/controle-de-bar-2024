using ControleBar.Dominio.ModuloMesa;
using ControleBar.WinApp.Compartilhado;

namespace ControleBar.WinApp.ModuloMesa;

public partial class TabelaMesaControl : UserControl
{
    public TabelaMesaControl()
    {
        InitializeComponent();

        grid.Columns.AddRange(ObterColunas());

        grid.ConfigurarGridSomenteLeitura();
        grid.ConfigurarGridZebrado();
    }

    public void AtualizarRegistros(List<Mesa> mesas)
    {
        grid.Rows.Clear();

        foreach (var m in mesas)
            grid.Rows.Add(m.Id, m.NumeroMesa, m.Ocupada ? "Ocupada" : "Disponivel");
    }

    public int ObterRegistroSelecionado()
    {
        return grid.SelecionarId();
    }

    private DataGridViewColumn[] ObterColunas()
    {
        return new DataGridViewColumn[]
        {
            new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Número da Mesa", HeaderText = "Número da Mesa" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Status" }
        };
    }
}