public static class Desconto
{
    private const double Percentual = 0.10;
    public static decimal CalcularDesconto(decimal valor)
    {
        return valor * Percentual;
    }
}