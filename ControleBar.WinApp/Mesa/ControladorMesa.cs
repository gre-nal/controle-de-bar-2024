using ControleBar.WinApp.Compartilhado;
using ControleBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace ControleBar.WinApp.Mesa
{
    public class ControladorMesa : ControladorBase
    {
        public override string TipoCadastro => "Mesa";

        public override string ToolTipAdicionar => "Cadastrar uma nova Mesa";

        public override string ToolTipEditar => "Editar uma Mesa";

        public override string ToolTipExcluir => "Excluir uma Mesa";

        TabelaMesaControl tabelaMesa;

        IRepositorioMesa repositorioMesa;

        public ControladorMesa(TabelaMesaControl tabelaMesa, IRepositorioMesa repositorioMesa)
        {
            this.tabelaMesa = tabelaMesa;
            this.repositorioMesa = repositorioMesa;
        } 

        public override void Adicionar()
        {
            List<Mesa> mesasCadastradas = repositorioMesa.SelecionarTodos();

            TelaQuestaoForm telaQuestao = new TelaMesaForm(mesasCadastradas);

            DialogResult resultado = telaMesa.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Mesa novoRegistro = telaMesa.Mesa;

            repositorioMesa.Cadastrar(novoRegistro);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoRegistro.Numero}\" foi criado com sucesso!");
        }
    }

        public override void CarregarRegistros()
        {
            List<Mesa> mesas = repositorioMesa.SelecionarTodos();

        TabelaMesaControl.AtualizarRegistros(mesas);

        }

        public override void Editar()
        {
        int idSelecionado = mesaQuestao.ObterRegistroSelecionado();

        Mesa mesaSelecionada = repositorioMesa.SelecionarPorId(idSelecionado);

        if (mesaSelecionada == null)
        {
            MessageBox.Show(
                "Você precisa selecionar um registro para executar esta ação!",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        List<Mesa> mesaCadastradas = repositorioMesa.SelecionarTodos();

        TelaMesaForm tela = new TelaQuestaoForm(materiasCadastradas);

        telaMesa.Mesa = mesaSelecionada;

        DialogResult resultado = telaMesa.ShowDialog();

        if (resultado != DialogResult.OK)
            return;

        Mesa registroEditado = telaMesa.Mesa;

        repositorioMesa.Editar(idSelecionado, registroEditado);

        List<Mesa> mesaSelecionadas = telaMesa.mesaSelecionadas;

        CarregarRegistros();

        TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{registroEditado.Numero}\" foi editado com sucesso!");
    }

        public override void Excluir()
        {
        int idSelecionado = tabelaMesa.ObterRegistroSelecionado();

        Mesa mesaSelecionada = repositorioMesa.SelecionarPorId(idSelecionado);

        if (mesaSelecionada == null)
        {
            MessageBox.Show(
                "Você precisa selecionar um registro para executar esta ação!",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        if (mesaSelecionada.UtilizadaEmTeste)
        {
            MessageBox.Show(
                "Não é possível excluir uma questão sendo utilizada em um teste!",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        DialogResult resposta = MessageBox.Show(
         $"Você deseja realmente excluir o registro \"{mesaSelecionada.Numero}\" ",
         "Confirmar Exclusão",
         MessageBoxButtons.YesNo,
         MessageBoxIcon.Warning
         );

        if (resposta != DialogResult.Yes)
            return;

        repositorioMesa.Excluir(idSelecionado);

        CarregarRegistros();

        TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{mesaSelecionada.Numero}\" foi excluído com sucesso!");
    }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }
    }
}
