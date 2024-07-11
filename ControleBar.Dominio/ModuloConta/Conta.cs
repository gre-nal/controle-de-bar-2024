using ControleBar.Dominio.Compartilhado;
using ControleBar.Dominio.ModuloGarcom;
using ControleBar.Dominio.ModuloMesa;
using FluentValidation;

namespace ControleBar.Dominio.ModuloConta;

public class Conta : EntidadeBase
{
    public Conta()
    {
    }

    public Conta(Mesa mesa, Garcom garcom)
    {
        Mesa = mesa;
        Garcom = garcom;
        Pedidos = new List<Pedido>();
        ValorTotal = 0;
        Concluida = false;
        DataConclusao = DateTime.Parse("01/01/2000");
    }

    public List<Pedido> Pedidos { get; set; }
    public Mesa Mesa { get; set; }
    public Garcom Garcom { get; set; }
    public double ValorTotal { get; set; }
    public bool Concluida { get; set; }
    public DateTime DataConclusao { get; set; }

    public override List<string> Validar()
    {
        var validator = new ContaValidator();
        var result = validator.Validate(this);
        return result.Errors.Select(error => error.ErrorMessage).ToList();
    }

    public override void AtualizarRegistro(EntidadeBase novoRegistro)
    {
        var conta = (Conta)novoRegistro;

        Pedidos = conta.Pedidos;
        Mesa = conta.Mesa;
        Garcom = conta.Garcom;
        ValorTotal = conta.ValorTotal;
        Concluida = conta.Concluida;
    }

    public void CalcularValorTotal()
    {
        ValorTotal = 0;
        foreach (var p in Pedidos) ValorTotal += p.CalcularValor();
    }

    public void Concluir()
    {
        Concluida = true;
        DataConclusao = DateTime.Now;
    }
}

public class ContaValidator : AbstractValidator<Conta>
{
    public ContaValidator()
    {
        RuleFor(conta => conta.Mesa)
            .NotNull()
            .WithMessage("O campo \"mesa\" é obrigatório");

        RuleFor(conta => conta.Garcom)
            .NotNull()
            .WithMessage("O campo \"garcom\" é obrigatório");
    }
}