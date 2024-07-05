﻿public class Conta
{
    public int Id { get; set; }
    public Mesa Mesa { get; set; }
    public Garcom Garcom { get; set; }
    //public List<Pedido> Pedidos { get; set; } = new List<Pedido>();
    public DateTime? DataFechamento { get; set; }
    public bool EstaAberta => !DataFechamento.HasValue;

    //public decimal Total => Pedidos.Sum(p => p.Total);

    public Garcom Garcom1
    {
        get => default;
        set
        {
        }
    }

    public Mesa Mesa1
    {
        get => default;
        set
        {
        }
    }

    //public Pedido Pedido
    //{
    //    get => default;
    //    set
    //    {
    //    }
    //}

    //public void AdicionarPedido(Pedido pedido)
    //{
    //    Pedidos.Add(pedido);
    //}

    //public void RemoverPedido(Pedido pedido)
    //{
    //    Pedidos.Remove(pedido);
    //}

    public void FecharConta()
    {
        DataFechamento = DateTime.Now;
    }
}