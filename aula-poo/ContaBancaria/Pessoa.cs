
namespace ConsoleApp2
{
    internal class Pessoa
    {
        public Pessoa(string nome, int idade)
        {
            (Nome, Idade) = (nome, idade);

            // this.Nome = nome;
            // this.Idade = idade;
        }


        public string Nome { get; set; }
        public int Idade { get; set; }

        

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}