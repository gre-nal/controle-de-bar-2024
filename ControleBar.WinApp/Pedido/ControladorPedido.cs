using ControleBar.WinApp.Compartilhado;
using ControleBar.WinApp.Pedido;
//using ControleBar.WinApp.Produto;
using System.Drawing.Drawing2D;

namespace ControleBar.WinApp.Pedido
{
    public class ControladorPedido : ControladorBase
    {
        public override string TipoCadastro => "Pedido";

        public override string ToolTipAdicionar => "Cadastrar um novo Pedido";

        public override string ToolTipEditar => "Editar um Pedido";

        public override string ToolTipExcluir => "Excluir um Pedido";

        TabelaPedidoControl tabelaPedido;

        public override void Adicionar()
        {
            List<Produto> produtosCadastrados = repositorioProduto.SelecionarTodos();

            TelaPedidoForm telaPedido = new TelaPedidoForm(produtosCadastrados);

            DialogResult resultado = telaPedido.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Pedido novoRegistro = telaPedido.Pedido;

            repositorioPedido.Cadastrar(novoRegistro);

            CarregarRegistros();

            //TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoRegistro.Nome}\" foi criado com sucesso!");
        }

        public override void CarregarRegistros()
        {
            List<Pedido> pedidos = repositorioPedido.SelecionarTodos();

            tabelaPedido.AtualizarRegistros(pedidos);
        }

        public override void Editar()
        {
            int idSelecionado = tabelaPedido.ObterRegistrosSelecionado();

            Pedido pedidoSelecionado = repositorioPedido.SelecionarPorId(idSelecionado);

            if(pedidoSelecionado == null)
            {
                MessageBox.Show(
                    "Você precisa selecionar um registro para executar esta ação!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaPedido.ObterRegistroSelecionado();

            Questao questaoSelecionado = repositorrioPedido.SelecionarPorId(idSelecionado);

            if(pedidoSelecionado == null)
            {
                MessageBox.Show(
                    "Você precisa selecionar um registro para executar esta ação",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        public override UserControl ObterListagem()
        {
            if (tabelaPedido == null)
                tabelaPedido = new TabelaPedidoControl();

            CarregarRegistros();

            return tabelaPedido;
        }
    }
}
