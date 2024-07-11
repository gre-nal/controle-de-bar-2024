﻿using ControleBar.Dominio.ModuloConta;
using ControleBar.Infraestrutura.Orm.Compartilhado;
using Microsoft.EntityFrameworkCore;

namespace ControleBar.Infraestrutura.Orm.ModuloConta;

public class RepositorioContaEmOrm : IRepositorioConta
{
    private readonly ControleDeBarDbContext dbContext;

    public RepositorioContaEmOrm(ControleDeBarDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public void Cadastrar(Conta novaConta)
    {
        dbContext.Contas.Add(novaConta);
        dbContext.SaveChanges();
    }

    public bool Editar(int id, Conta contaEditada)
    {
        var conta = dbContext.Contas.Find(id)!;

        if (conta == null)
            return false;

        conta.AtualizarRegistro(contaEditada);
        dbContext.SaveChanges();

        return true;
    }

    public bool Excluir(int id)
    {
        var conta = dbContext.Contas.Find(id)!;

        if (conta == null)
            return false;

        dbContext.Contas.Remove(conta);
        dbContext.SaveChanges();

        return true;
    }

    public List<Conta> SelecionarEmAberto()
    {
        return dbContext.Contas.Include(c => c.Mesa).Include(c => c.Garcom).Include(c => c.Pedidos)
            .Where(c => c.Concluida == false).ToList();
    }

    public Conta SelecionarPorId(int idSelecionado)
    {
        return dbContext.Contas.Find(idSelecionado);
    }

    public List<Conta> SelecionarTodos()
    {
        return dbContext.Contas.Include(c => c.Mesa).Include(c => c.Garcom)
            .Include(c => c.Pedidos).ToList();
    }
}