public class Pedido
{
    public int Id { get; set; }
    public Produto Produto { get; set; }
    public int Quantidade { get; set; }
    public decimal Total => Produto.Preco * Quantidade;
}
