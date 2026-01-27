using Biblioteca;

public class Pessoa{
    public int Id { get; set; }
    public string Nome { get; set; }
    public List<Livro> Livros { get; set; }

    public Pessoa(int id, string nome){
        Id = id;
        Nome = nome;
        Livros = new List<Livro>();
    }

    public void PegarLivro(Livro livro)
    {
        //Livros.Add(livro);

        if(livro.Status == "Disponível")
        {
            Livros.Add(livro);
            livro.Status = "Emprestado";
            livro.Locatario = this.Nome;
            Console.WriteLine($"O livro '{livro.Titulo}' foi emprestado pata {this.Nome}");
        }
        else
        {
            Console.WriteLine($"'{livro.Titulo}' = status: {livro.Status}");

        }
        
        
    }

    public void DevolverLivro(Livro livro)
    {

        //Livros.Remove(livro);
        if (Livros.Contains(livro))
        {
            Livros.Remove(livro);
            livro.Status="Disponível";
            livro.Locatario = "";
            Console.WriteLine($"O livro '{livro.Titulo}' foi devolvido por {this.Nome}.");
        }
     
    }
}