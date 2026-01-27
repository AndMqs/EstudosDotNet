public class Carro : Transporte
{
    public const double KM_POR_LITRO = 12.5;
    private const double PRECO_LITRO = 6.50;

    public override void Mover()
    {
        Console.WriteLine("O carro está em movimento...");
    }

    public override void CalcularCusto()
    {
        CustoPorKm = PRECO_LITRO / KM_POR_LITRO;
        Console.WriteLine($"Custo de combustível por km do carro: R$ {CustoPorKm:F2}");
    }
}