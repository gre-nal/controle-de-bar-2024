using ControleBar.Dominio.ModuloMesa;
using ControleBar.WinApp.Compartilhado;

namespace ControleBar.WinApp.ModuloMesa;

public partial class TelaMesaForm : Form
{
    private readonly List<Mesa> mesasCadastradas;
    private Mesa mesa;

    public TelaMesaForm(List<Mesa> mesasCadastradas)
    {
        InitializeComponent();
        this.ConfigurarDialog();

        this.mesasCadastradas = mesasCadastradas;
    }

    public Mesa Mesa
    {
        get => mesa;

        set => numMesa.Value = value.NumeroMesa;
    }

    private void btnGravar_Click(object sender, EventArgs e)
    {
        var numeromesa = (int)numMesa.Value;

        mesa = new Mesa(numeromesa);

        var erros = new List<string>();

        if (MesaTemNumeroDuplicado())
            erros.Add("Já existe uma mesa com este número cadastrado");

        if (erros.Count > 0)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

            DialogResult = DialogResult.None;
        }
    }

    private bool MesaTemNumeroDuplicado()
    {
        return mesasCadastradas.Any(m => m.NumeroMesa == mesa.NumeroMesa);
    }
}