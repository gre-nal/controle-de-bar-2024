using ControleBar.Dominio.ModuloConta;
using ControleBar.Infraestrutura.Orm.Compartilhado;
using Microsoft.EntityFrameworkCore;

namespace ControleBar.Infraestrutura.Orm.ModuloConta;

public class RepositorioPedidoEmOrm : IRepositorioPedido
{
    private readonly ControleDeBarDbContext dbContext;

    public RepositorioPedidoEmOrm(ControleDeBarDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public void Cadastrar(Pedido novoPedido)
    {
        dbContext.Pedidos.Add(novoPedido);
        dbContext.SaveChanges();
    }

    public bool Editar(int id, Pedido pedidoEditado)
    {
        var pedido = dbContext.Pedidos.Find(id)!;

        if (pedido == null)
            return false;

        pedido.AtualizarRegistro(pedidoEditado);
        dbContext.SaveChanges();

        return true;
    }

    public bool Excluir(int id)
    {
        var pedido = dbContext.Pedidos.Find(id)!;

        if (pedido == null)
            return false;

        dbContext.Pedidos.Remove(pedido);
        dbContext.SaveChanges();

        return true;
    }

    public Pedido SelecionarPorId(int idSelecionado)
    {
        return dbContext.Pedidos.Find(idSelecionado)!;
    }

    public List<Pedido> SelecionarTodos()
    {
        return dbContext.Pedidos.Include(x => x.Produto).ToList();
    }
}