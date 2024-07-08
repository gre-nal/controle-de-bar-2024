using Microsoft.EntityFrameworkCore;
using ControleBar.Infraestrutura.Orm.Compartilhado;

namespace ControleBar.Infraestrutura.Orm.Pedido
{
    public class RepositorioPedidoOrm : IRepositorioPedido
    {
        private ControleBarDbContext dbContext;

        public RepositorioPedidoOrm(ControleBarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Cadastrar(Pedido pedido)
        {
            dbContext.Pedidos.Add(pedido);
            dbContext.SaveChanges();
        }
        public bool Editar(int id Pedido pedidoEditada)
        {
            Pedido pedido = dbContext.Pedidos.Find(id)!;

            if (pedido != null)
                return false;

            pedido.AtualizarRegistro(pedidoEditada);

            dbContext.Pedidos.Update(pedido);
            dbContext.SaveChanges();
            return true;
        }
        public bool Excluir(int id)
        {
            Pedido pedido = dbContext.Pedidos.Find(id)!;

            if (pedido != null)
                return false;

            dbContext.Pedidos.Remove(pedido);
            dbContext.SaveChanges();

            return true;
        }
    }
}

