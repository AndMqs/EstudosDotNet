public class Gato : Animal
{
    public string Raca {get; set;}

    public Gato(string nome, string raca) : base(nome)
    {
        Raca = raca; 
    }
    public override string EmitirSom()
    {
         return "Miau, Miau";
    }
}