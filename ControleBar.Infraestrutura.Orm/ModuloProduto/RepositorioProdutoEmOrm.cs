using ControleBar.Dominio.ModuloProduto;
using ControleBar.Infraestrutura.Orm.Compartilhado;

namespace ControleBar.Infraestrutura.Orm.ModuloProduto;

public class RepositorioProdutoEmOrm : IRepositorioProduto
{
    private readonly ControleDeBarDbContext dbContext;

    public RepositorioProdutoEmOrm(ControleDeBarDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public void Cadastrar(Produto produto)
    {
        dbContext.Produtos.Add(produto);
        dbContext.SaveChanges();
    }

    public bool Editar(int id, Produto novoProduto)
    {
        var produto = dbContext.Produtos.Find(id)!;

        if (produto == null)
            return false;

        produto.AtualizarRegistro(novoProduto);

        dbContext.Produtos.Update(produto);
        dbContext.SaveChanges();

        return true;
    }

    public bool Excluir(int id)
    {
        var produto = dbContext.Produtos.Find(id)!;

        if (produto == null)
            return false;

        dbContext.Produtos.Remove(produto);
        dbContext.SaveChanges();

        return true;
    }

    public Produto SelecionarPorId(int id)
    {
        return dbContext.Produtos.Find(id);
    }

    public List<Produto> SelecionarTodos()
    {
        return dbContext.Produtos.ToList();
    }
}