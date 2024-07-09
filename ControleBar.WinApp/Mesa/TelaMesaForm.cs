using ControleBar.WinApp.Pedido;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleBar.WinApp.Mesa
{
    public partial class TelaMesaForm : Form
    {
        public TelaMesaForm()
        {
            InitializeComponent();
        }
        private Mesa mesa;
        private void btnGravar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtBNumeroMesa.Text);

            List<string> erros = mesa.Validar();

            if(erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
