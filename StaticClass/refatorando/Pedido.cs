public class Pedido
{
    public double Valor { get; private set; }

    public Pedido(double valor)
    {
        Valor = valor;
    }

    public double CalcularDesconto()
    {
        return Desconto.CalcularDesconto(Valor);
    }

}