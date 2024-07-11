using ControleBar.Dominio.ModuloMesa;
using ControleBar.WinApp.Compartilhado;

namespace ControleBar.WinApp.ModuloMesa;

internal class ControladorMesa : ControladorBase
{
    private readonly IRepositorioMesa repositorioMesa;

    private TabelaMesaControl tabelaMesa;

    public ControladorMesa(IRepositorioMesa repositorioMesa)
    {
        this.repositorioMesa = repositorioMesa;
    }

    public override string TipoCadastro => "Mesa";

    public override string ToolTipAdicionar => "Adicionar uma Mesa";

    public override string ToolTipEditar => "Editar uma mesa existente";

    public override string ToolTipExcluir => "Remover uma mesa existente";

    public override void Adicionar()
    {
        var mesasCadastradas = repositorioMesa.SelecionarTodos();

        var telaMesa = new TelaMesaForm(mesasCadastradas);

        var resultado = telaMesa.ShowDialog();

        if (resultado != DialogResult.OK)
            return;

        var novoRegistro = telaMesa.Mesa;

        repositorioMesa.Cadastrar(novoRegistro);

        CarregarRegistros();

        TelaPrincipalForm.Instancia.AtualizarRodape(
            $"A Mesa de número \"{novoRegistro.NumeroMesa}\" foi criada com sucesso!");
    }


    public override void Editar()
    {
        var idSelecionado = tabelaMesa.ObterRegistroSelecionado();

        var mesaSelecionada = repositorioMesa.SelecionarPorId(idSelecionado);

        if (mesaSelecionada == null)
        {
            MessageBox.Show(
                "Você precisa selecionar um registro para executar esta ação!",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        var mesasCadastradas = repositorioMesa.SelecionarTodos();

        var telaMesa = new TelaMesaForm(mesasCadastradas);

        telaMesa.Mesa = mesaSelecionada;

        var resultado = telaMesa.ShowDialog();

        if (resultado != DialogResult.OK)
            return;

        var registroEditado = telaMesa.Mesa;

        repositorioMesa.Editar(idSelecionado, registroEditado);

        CarregarRegistros();

        TelaPrincipalForm.Instancia.AtualizarRodape(
            $"A mesa de número \"{registroEditado.NumeroMesa}\" foi editada com sucesso!");
    }

    public override void Excluir()
    {
        var idSelecionado = tabelaMesa.ObterRegistroSelecionado();

        var mesaSelecionada = repositorioMesa.SelecionarPorId(idSelecionado);

        if (mesaSelecionada == null)
        {
            MessageBox.Show(
                "Você precisa selecionar um registro para executar esta ação!",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        var resposta = MessageBox.Show(
            $"Você deseja realmente excluir o registro da mesa de número \"{mesaSelecionada.NumeroMesa}\" ",
            "Confirmar Exclusão",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        );

        if (resposta != DialogResult.Yes)
            return;

        repositorioMesa.Excluir(idSelecionado);

        CarregarRegistros();

        TelaPrincipalForm.Instancia.AtualizarRodape(
            $"A mesa de número \"{mesaSelecionada.NumeroMesa}\" foi excluida com sucesso!");
    }

    public override UserControl ObterListagem()
    {
        if (tabelaMesa == null)
            tabelaMesa = new TabelaMesaControl();

        CarregarRegistros();

        return tabelaMesa;
    }

    public override void CarregarRegistros()
    {
        var mesas = repositorioMesa.SelecionarTodos();

        tabelaMesa.AtualizarRegistros(mesas);
        AtualizarQuantidadeRodape();
    }

    private void AtualizarQuantidadeRodape()
    {
        TelaPrincipalForm.Instancia.AtualizarRodape(
            $"Visualizando {repositorioMesa.SelecionarTodos().Count} registro(s)...");
    }
}