using Biblioteca;

public class BibliotecaClass
{
 public List<Livro> Livros {get; set; }
 public List<Pessoa> Pessoas {get; set;}

 public BibliotecaClass()
    {
        Livros = new List<Livro>();
        Pessoas = new List<Pessoa>();
    }

    
 public void CadastrarLivro(Livro livro)
    {
        Livros.Add(livro);
    }

 public void CadastrarUsuario(Pessoa pessoa)
    {
        Pessoas.Add(pessoa);
    }
 public void ListarLivros()
    {
        Console.WriteLine("LIVROS CADASTRADOS:");

        if(Livros.Count == 0)
        {
            Console.Write("Não existem livros cadastrados no momento.");
        }
        else
        {
             foreach(var l in Livros)
            {
                Console.WriteLine($"{l.Titulo}");
                Console.WriteLine($"Status: {l.Status}");
                Console.WriteLine($"ID: {l.Id}");
                Console.WriteLine("---");
            }
            
        }
       
    }

    public void EmprestarLivro(Livro livro, Pessoa pessoa)
    {
        livro.Emprestar(pessoa.Nome);
        pessoa.PegarLivro(livro);
    }
}