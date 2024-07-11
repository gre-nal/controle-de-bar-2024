using ControleBar.Dominio.ModuloGarcom;
using ControleBar.Infraestrutura.Orm.Compartilhado;

namespace ControleBar.Infraestrutura.Orm.ModuloGarcom;

public class RepositorioGarcomEmOrm : IRepositorioGarcom
{
    private readonly ControleDeBarDbContext dbContext;

    public RepositorioGarcomEmOrm(ControleDeBarDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public void Cadastrar(Garcom novoGarcom)
    {
        dbContext.Garcoms.Add(novoGarcom);
        dbContext.SaveChanges();
    }

    public bool Editar(int id, Garcom garcomEditado)
    {
        var garcom = dbContext.Garcoms.Find(id)!;

        if (garcom == null)
            return false;

        garcom.AtualizarRegistro(garcomEditado);
        dbContext.SaveChanges();

        return true;
    }

    public bool Excluir(int id)
    {
        var garcom = dbContext.Garcoms.Find(id)!;

        if (garcom == null)
            return false;

        dbContext.Garcoms.Remove(garcom);
        dbContext.SaveChanges();

        return true;
    }

    public Garcom SelecionarPorId(int idSelecionado)
    {
        return dbContext.Garcoms.Find(idSelecionado)!;
    }

    public List<Garcom> SelecionarTodos()
    {
        return dbContext.Garcoms.ToList();
    }
}