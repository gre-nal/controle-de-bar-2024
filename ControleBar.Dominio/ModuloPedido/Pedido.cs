using ControleBar.Dominio.Produto; 

namespace ControleBar.Dominio.Pedido
{
    public class Pedido : EntidadeBase
    {
        public Pedido(int id, int quantidade)
        {
            Id = id;
            Quantidade = quantidade;
        }
        public int Id { get; set; }
        public Pedido pedido { get; set; }
        public int Quantidade { get; set; }
        public decimal Total => Produto.Preco * Quantidade;
        public Produto Produto { get; set; }
        
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Pedido pedidoEditada = (Pedido)novoRegistro;

            Produto = pedidoEditada.Produto;
            Quantidade = pedidoEditada.Quantidade;
        }
        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (Quantidade <= 0)
                erros.Add($"Quantidade precisa ser maior que 0");

            return erros;
        }
    }
}
