namespace ControleBar.WinApp.Compartilhado;

public abstract class ControladorBase
{
    public abstract string TipoCadastro { get; }

    public abstract string ToolTipAdicionar { get; }
    public abstract string ToolTipEditar { get; }
    public abstract string ToolTipExcluir { get; }
    public abstract UserControl ObterListagem();
    public abstract void CarregarRegistros();
    public abstract void Adicionar();
    public abstract void Editar();
    public abstract void Excluir();

    public interface IControladorAdicionar
    {
        string ToolTipAdicionarItem { get; }
        void AdicionarItem();
    }

    public interface IControladorConcluir
    {
        string ToolTipConcluir { get; }
        void Concluir();
    }

    public interface IControladorEmAberto
    {
        string ToolTipVisualizarEmAberto { get; }
        void VisualizarEmAberto(ToolStripButton btn);
    }

    public interface IControladorFaturamento
    {
        string ToolTipFaturamento { get; }
        void Faturamento();
    }
}