using ControleBar.Dominio.ModuloMesa;
using ControleBar.Infraestrutura.Orm.Compartilhado;

namespace ControleBar.Infraestrutura.Orm.ModuloMesa;

public class RepositorioMesaEmOrm : IRepositorioMesa
{
    private readonly ControleDeBarDbContext dbContext;

    public RepositorioMesaEmOrm(ControleDeBarDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public void Cadastrar(Mesa novaMesa)
    {
        dbContext.Mesas.Add(novaMesa);
        dbContext.SaveChanges();
    }

    public bool Editar(int id, Mesa mesaEditada)
    {
        var mesa = dbContext.Mesas.Find(id)!;

        if (mesa == null)
            return false;

        mesa.AtualizarRegistro(mesaEditada);
        dbContext.SaveChanges();

        return true;
    }

    public bool Excluir(int id)
    {
        var mesa = dbContext.Mesas.Find(id)!;

        if (mesa == null)
            return false;

        dbContext.Mesas.Remove(mesa);
        dbContext.SaveChanges();

        return true;
    }

    public Mesa SelecionarPorId(int idSelecionado)
    {
        return dbContext.Mesas.Find(idSelecionado);
    }

    public List<Mesa> SelecionarTodos()
    {
        return dbContext.Mesas.ToList();
    }
}