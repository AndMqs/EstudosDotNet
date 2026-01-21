namespace StaticClass
{
    public class Pedido
    {
        public decimal Valor { get; private set; }

        public Pedido(decimal valor)
        {
            Valor = valor;
        }

        public static bool ValorEhValido(decimal valor)
        {
            return valor > 0;
        }

        
    }
}
