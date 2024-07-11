using ControleBar.Dominio.Compartilhado;
using ControleBar.Dominio.ModuloProduto;
using FluentValidation;

namespace ControleBar.Dominio.ModuloConta;

public class Pedido : EntidadeBase
{
    public Pedido()
    {
    }

    public Pedido(Produto produto, int quantidade)
    {
        Produto = produto;
        Quantidade = quantidade;
    }

    public Produto Produto { get; set; }
    public int Quantidade { get; set; }

    public override List<string> Validar()
    {
        var validator = new PedidoValidator();
        var result = validator.Validate(this);
        var erros = new List<string>();

        if (!result.IsValid)
            foreach (var error in result.Errors)
                erros.Add(error.ErrorMessage);

        return erros;
    }

    public override void AtualizarRegistro(EntidadeBase novoRegistro)
    {
        var pedido = (Pedido)novoRegistro;

        Produto = pedido.Produto;
        Quantidade = pedido.Quantidade;
    }

    public double CalcularValor()
    {
        return Produto.Preco * Quantidade;
    }

    public override string ToString()
    {
        return $"Produto: {Produto} | Quantidade: {Quantidade}";
    }
}

public class PedidoValidator : AbstractValidator<Pedido>
{
    public PedidoValidator()
    {
        RuleFor(pedido => pedido.Produto)
            .NotNull()
            .WithMessage("O campo \"Produto\" é obrigatório!");

        RuleFor(pedido => pedido.Quantidade)
            .GreaterThan(0)
            .WithMessage("O campo \"Quantidade\" é obrigatório!");
    }
}