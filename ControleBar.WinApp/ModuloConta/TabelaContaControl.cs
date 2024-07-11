using ControleBar.Dominio.ModuloConta;
using ControleBar.WinApp.Compartilhado;

namespace ControleBar.WinApp.ModuloConta;

public partial class TabelaContaControl : UserControl
{
    public TabelaContaControl()
    {
        InitializeComponent();
        grid.Columns.AddRange(ObterColunas());
        grid.ConfigurarGridSomenteLeitura();
        grid.ConfigurarGridZebrado();
    }

    public void AtualizarRegistros(List<Conta> contas)
    {
        grid.Rows.Clear();

        foreach (var c in contas)
            grid.Rows.Add(c.Id, c.Mesa, c.Garcom, c.Concluida ? "Concluído" : "Em Aberto", "R$" + c.ValorTotal,
                c.DataConclusao == DateTime.Parse("01/01/2000") ? "" : c.DataConclusao.ToShortDateString());
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
            new DataGridViewTextBoxColumn { DataPropertyName = "Mesa", HeaderText = "Mesa" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Garcom", HeaderText = "Garcom" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Concluida", HeaderText = "Concluida" },
            new DataGridViewTextBoxColumn { DataPropertyName = "ValorTotal", HeaderText = "Valor Total" },
            new DataGridViewTextBoxColumn { DataPropertyName = "DataConclusao", HeaderText = "Data da Conclusão" }
        };
    }
}