using ControleBar.Dominio.ModuloGarcom;
using ControleBar.WinApp.Compartilhado;

namespace ControleBar.WinApp.ModuloGarcom;

public partial class TelaGarcomForm : Form
{
    private readonly List<Garcom> garcomsCadastrados;
    private Garcom garcom;

    public TelaGarcomForm(List<Garcom> garcomsCadastrados)
    {
        InitializeComponent();
        this.ConfigurarDialog();
        this.garcomsCadastrados = garcomsCadastrados;
    }

    public Garcom Garcom
    {
        get => garcom;

        set
        {
            txtNome.Text = value.Nome;
            txtCpf.Text = value.Cpf;
        }
    }

    private void btnGravar_Click(object sender, EventArgs e)
    {
        garcom = new Garcom(txtNome.Text.Trim(), txtCpf.Text.Trim());

        var erros = garcom.Validar();

        if (GarcomTemCpfDuplicado())
            erros.Add("Já existe um garcom com este cpf cadastrado");

        if (erros.Count > 0)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

            DialogResult = DialogResult.None;
        }
    }

    private bool GarcomTemCpfDuplicado()
    {
        return garcomsCadastrados.Any(c => c.Cpf == garcom.Cpf);
    }
}