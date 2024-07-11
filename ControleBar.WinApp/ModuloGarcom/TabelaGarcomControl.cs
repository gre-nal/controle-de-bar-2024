using ControleBar.Dominio.ModuloGarcom;
using ControleBar.WinApp.Compartilhado;

namespace ControleBar.WinApp.ModuloGarcom;

public partial class TabelaGarcomControl : UserControl
{
    public TabelaGarcomControl()
    {
        InitializeComponent();

        grid.Columns.AddRange(ObterColunas());

        grid.ConfigurarGridSomenteLeitura();
        grid.ConfigurarGridZebrado();
    }

    public void AtualizarRegistros(List<Garcom> garcoms)
    {
        grid.Rows.Clear();

        foreach (var g in garcoms)
            grid.Rows.Add(g.Id, g.Nome, g.Cpf);
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
            new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Cpf", HeaderText = "Cpf" }
        };
    }
}