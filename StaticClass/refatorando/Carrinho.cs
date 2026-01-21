public class Carrinho
{
    public double Total {get; private set;}

    public Carrinho (double total)
    {
        Total = total;
    }

       public double TotalComDesconto(Pedido pedido)
    {
        return Total - pedido.CalcularDesconto();
    }
}