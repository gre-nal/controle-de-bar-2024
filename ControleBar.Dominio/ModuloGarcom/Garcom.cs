using ControleBar.Dominio.Compartilhado;
using FluentValidation;

namespace ControleBar.Dominio.ModuloGarcom;

public class Garcom : EntidadeBase
{
    public Garcom(string nome, string cpf)
    {
        Nome = nome;
        Cpf = cpf;
    }

    public string Nome { get; set; }
    public string Cpf { get; set; }

    public override List<string> Validar()
    {
        var validator = new GarcomValidator();
        var result = validator.Validate(this);
        var erros = result.Errors.Select(error => error.ErrorMessage).ToList();
        return erros;
    }

    public override void AtualizarRegistro(EntidadeBase novoRegistro)
    {
        var garcom = (Garcom)novoRegistro;

        Nome = garcom.Nome;
        Cpf = garcom.Cpf;
    }

    public override string ToString()
    {
        return $"{Nome}";
    }
}

public class GarcomValidator : AbstractValidator<Garcom>
{
    public GarcomValidator()
    {
        RuleFor(garcom => garcom.Nome)
            .NotEmpty().WithMessage("O campo \"nome\" é obrigatório");

        RuleFor(garcom => garcom.Cpf)
            .NotEmpty().WithMessage("O campo \"cpf\" é obrigatório")
            .Length(14).WithMessage("O campo \"cpf\" não foi preenchido corretamente");
    }
}