public class Bicicleta : Transporte
{
 
    public override void Mover()
    {
        Console.WriteLine("A bicicleta está em movimento...");
    }

    public override void CalcularCusto()
    {
        Console.WriteLine($"Custo de combustível por km da bicicleta: R$ NADA. Só suas perninhas e as banha mesmo.");
    }
}