using ControleBar.Dominio.Compartilhado;
using FluentValidation;

namespace ControleBar.Dominio.ModuloMesa;

public class Mesa : EntidadeBase
{
    public Mesa(int numeroMesa)
    {
        NumeroMesa = numeroMesa;
    }

    public bool Ocupada { get; set; }
    public int NumeroMesa { get; set; }

    public override List<string> Validar()
    {
        var validator = new MesaValidator();
        var result = validator.Validate(this);
        var erros = new List<string>();

        if (!result.IsValid)
            foreach (var error in result.Errors)
                erros.Add(error.ErrorMessage);

        return erros;
    }

    public override void AtualizarRegistro(EntidadeBase novoRegistro)
    {
        var mesa = (Mesa)novoRegistro;

        Ocupada = mesa.Ocupada;
        NumeroMesa = mesa.NumeroMesa;
    }

    public override string ToString()
    {
        return $"Mesa Nº {NumeroMesa}";
    }
}

public class MesaValidator : AbstractValidator<Mesa>
{
    public MesaValidator()
    {
        RuleFor(mesa => mesa.NumeroMesa)
            .GreaterThan(0)
            .WithMessage("O número da Mesa precisa ser maior que 0.");
    }
}