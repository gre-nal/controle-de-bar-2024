using ControleBar.Dominio.Compartilhado;
using FluentValidation;

namespace ControleBar.Dominio.ModuloProduto;

public class Produto : EntidadeBase
{
    public Produto()
    {
    }

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public string Nome { get; set; }
    public double Preco { get; set; }

    public override void AtualizarRegistro(EntidadeBase novoRegistro)
    {
        var prod = (Produto)novoRegistro;

        Nome = prod.Nome;
        Preco = prod.Preco;
    }

    public override List<string> Validar()
    {
        var validator = new ProdutoValidator();
        var result = validator.Validate(this);
        var erros = new List<string>();

        if (!result.IsValid)
            foreach (var error in result.Errors)
                erros.Add(error.ErrorMessage);

        return erros;
    }

    public override string ToString()
    {
        return $"{Nome} -- R${Preco}";
    }
}

public class ProdutoValidator : AbstractValidator<Produto>
{
    public ProdutoValidator()
    {
        RuleFor(p => p.Nome)
            .NotEmpty().WithMessage("O campo \"Produto\" deve ser preenchido!");

        RuleFor(p => p.Preco)
            .GreaterThan(0).WithMessage("O campo \"Valor\" deve ser preenchido!");
    }
}