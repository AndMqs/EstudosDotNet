using System;
using System.Dynamic;
using Biblioteca;

BibliotecaClass bb = new BibliotecaClass();
Livro livro1 = new Livro(1, "Romeu e Julieta");
Livro livro2 = new Livro(2, "She gets the girl");
Livro livro3 = new Livro(3, "Mobi Dick");

bb.CadastrarLivro(livro1);
bb.CadastrarLivro(livro2);
bb.CadastrarLivro(livro3);

static void AguardarEnter()
{
    Console.Write("\n Pressione ENTER para continuar...");
    Console.ReadLine(); 
}


bool sistemaAtivo = true;

while (sistemaAtivo)
{
    Console.WriteLine("Bem-vindo a Biblioteca Ponei!");
    Console.WriteLine("Escolha uma opção: ");
    Console.WriteLine("1 - Listar todos os livros");
    Console.WriteLine("2 - Emprestar livro");
    Console.WriteLine("3 - Sair");

int opcaoEscolhida = int.Parse(Console.ReadLine());


    switch (opcaoEscolhida)
    {
        case 1:
            Console.Clear();
            bb.ListarLivros();
            AguardarEnter();
            break;

        case 2:
            Console.Clear(); 
            Console.WriteLine("Por favor, cadastre o usuário. Digite o nome do locatário: ");

            string nomeUsuario = Console.ReadLine();
            int novoId = bb.Pessoas.Count + 1;

            Pessoa novoUsuario = new Pessoa(novoId, nomeUsuario);
            bb.CadastrarUsuario(novoUsuario);

            Console.WriteLine("Por favor, digite o id do livro desejado: ");
            bb.ListarLivros();
            int idLivroSelecionado = int.Parse(Console.ReadLine());
            Livro? livroEscolhido = bb.Livros.Find(item => item.Id == idLivroSelecionado);
            if(livroEscolhido == null)
            {
                Console.WriteLine("Erro");
                return;
            }
            bb.EmprestarLivro(livroEscolhido, novoUsuario);

            Console.WriteLine("Emprestimo concluído! Veja o novo estoque disponível: ");
            bb.ListarLivros();
            AguardarEnter();
            break;

        case 3:
            Console.Clear();
            Console.WriteLine("Encerrando Sistema...");
            sistemaAtivo = false;
            break;

        default:
            Console.WriteLine("Opção inválida.");
            AguardarEnter();
            break;


}



    
}


