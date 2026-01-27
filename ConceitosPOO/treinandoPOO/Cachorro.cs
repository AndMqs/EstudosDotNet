public class Cachorro : Animal
{
    public string Raca {get; set;}

    public Cachorro(string nome, string raca) : base(nome)
    {
        Raca = raca;   
    }

    //para o override (sobreposição) funcionar, precisa ter o mesmo nome, retorno e parâmetros que o metodo da classe pai
    public override string EmitirSom()
    {
        return "Au,Au";
    }
}