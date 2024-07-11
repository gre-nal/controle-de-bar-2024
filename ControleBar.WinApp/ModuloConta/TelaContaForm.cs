using ControleBar.Dominio.ModuloConta;
using ControleBar.Dominio.ModuloGarcom;
using ControleBar.Dominio.ModuloMesa;
using ControleBar.WinApp.Compartilhado;

namespace ControleBar.WinApp.ModuloConta;

public partial class TelaContaForm : Form
{
    private Conta conta;

    public TelaContaForm(List<Garcom> garcons, List<Mesa> mesas)
    {
        InitializeComponent();
        this.ConfigurarDialog();
        CarregarComboBox(garcons, mesas);
    }

    public Conta Conta
    {
        get => conta;
        set
        {
            comboBoxGarcom.SelectedItem = value.Garcom;
            comboBoxMesa.SelectedItem = value.Mesa;
        }
    }

    private void CarregarComboBox(List<Garcom> garcons, List<Mesa> mesas)
    {
        foreach (var g in garcons) comboBoxGarcom.Items.Add(g);
        foreach (var m in mesas)
            if (!m.Ocupada)
                comboBoxMesa.Items.Add(m);
    }

    private void btnGravar_Click(object sender, EventArgs e)
    {
        var garcom = (Garcom)comboBoxGarcom.SelectedItem!;
        var mesa = (Mesa)comboBoxMesa.SelectedItem!;

        conta = new Conta(mesa, garcom);

        var erros = new List<string>();

        if (erros.Count > 0)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

            DialogResult = DialogResult.None;
        }
    }
}