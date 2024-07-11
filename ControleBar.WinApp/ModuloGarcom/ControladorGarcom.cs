using ControleBar.Dominio.ModuloGarcom;
using ControleBar.WinApp.Compartilhado;

namespace ControleBar.WinApp.ModuloGarcom;

public class ControladorGarcom : ControladorBase
{
    private readonly IRepositorioGarcom repositorioGarcom;

    private TabelaGarcomControl tabelaGarcom;

    public ControladorGarcom(IRepositorioGarcom repositorioGarcom)
    {
        this.repositorioGarcom = repositorioGarcom;
    }

    public override string TipoCadastro => "Garcom";

    public override string ToolTipAdicionar => "Cadastrar um novo Garcom";

    public override string ToolTipEditar => "Editar um Garcom existente";

    public override string ToolTipExcluir => "Excluir um Garcom existente";

    public override void Adicionar()
    {
        var garcomsCadastrados = repositorioGarcom.SelecionarTodos();

        var telaGarcom = new TelaGarcomForm(garcomsCadastrados);

        var resultado = telaGarcom.ShowDialog();

        if (resultado != DialogResult.OK)
            return;

        var novoRegistro = telaGarcom.Garcom;

        repositorioGarcom.Cadastrar(novoRegistro);

        CarregarRegistros();

        TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoRegistro.Nome}\" foi criado com sucesso!");
    }

    public override void Editar()
    {
        var idSelecionado = tabelaGarcom.ObterRegistroSelecionado();

        var garcomSelecionado = repositorioGarcom.SelecionarPorId(idSelecionado);

        if (garcomSelecionado == null)
        {
            MessageBox.Show(
                "Você precisa selecionar um registro para executar esta ação!",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        var garcomsCadastrados = repositorioGarcom.SelecionarTodos();

        var telaGarcom = new TelaGarcomForm(garcomsCadastrados);

        telaGarcom.Garcom = garcomSelecionado;

        var resultado = telaGarcom.ShowDialog();

        if (resultado != DialogResult.OK)
            return;

        var registroEditado = telaGarcom.Garcom;

        repositorioGarcom.Editar(idSelecionado, registroEditado);

        CarregarRegistros();

        TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{registroEditado.Nome}\" foi editado com sucesso!");
    }

    public override void Excluir()
    {
        var idSelecionado = tabelaGarcom.ObterRegistroSelecionado();

        var garcomSelecionado = repositorioGarcom.SelecionarPorId(idSelecionado);

        if (garcomSelecionado == null)
        {
            MessageBox.Show(
                "Você precisa selecionar um registro para executar esta ação!",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        var resposta = MessageBox.Show(
            $"Você deseja realmente excluir o registro \"{garcomSelecionado.Nome}\" ",
            "Confirmar Exclusão",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        );

        if (resposta != DialogResult.Yes)
            return;

        repositorioGarcom.Excluir(idSelecionado);

        CarregarRegistros();

        TelaPrincipalForm.Instancia.AtualizarRodape(
            $"O registro \"{garcomSelecionado.Nome}\" foi exluído com sucesso!");
    }

    public override UserControl ObterListagem()
    {
        if (tabelaGarcom == null)
            tabelaGarcom = new TabelaGarcomControl();

        CarregarRegistros();

        return tabelaGarcom;
    }

    public override void CarregarRegistros()
    {
        var garcoms = repositorioGarcom.SelecionarTodos();

        tabelaGarcom.AtualizarRegistros(garcoms);
        AtualizarQuantidadeRodape();
    }

    private void AtualizarQuantidadeRodape()
    {
        TelaPrincipalForm.Instancia.AtualizarRodape(
            $"Visualizando {repositorioGarcom.SelecionarTodos().Count} registro(s)...");
    }
}