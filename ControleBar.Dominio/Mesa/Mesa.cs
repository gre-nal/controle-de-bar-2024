using Microsoft.EntityFrameworkCore;

namespace ControleBar.Dominio.ModuloMesa
{
    public class Mesa : EntidadeBase
    {
        public Mesa(int id, int numero, bool ocupada)
        {
            Id = id;
            Numero = numero;
            Ocupada = ocupada;
        }
        public int Id { get; set; }
        public int Numero { get; set; }
        public bool Ocupada { get; set; }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Mesa mesaEditada = (Mesa)novoRegistro;

            Id = mesaEditada.Id;
            Numero = mesaEditada.Numero;
            Ocupada = mesaEditada.Ocupada;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (int.IsNegative(Numero))
                erros.Add($"O número da mesa não pode ser negativo.");

            if (Numero == null)
                erros.Add($"O número da mesa é obrigatório.");

            return erros;
        }
    }

}
