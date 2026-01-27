// See https://aka.ms/new-console-template for more information
Console.WriteLine("-- Sistema de Cadastro e consulta de Usuários --");


string directory = "dados";
if (!Directory.Exists(directory))
{
    Directory.CreateDirectory(directory);
}

string file = "usuarios.csv";
string path = Path.Combine(directory,file);
Console.WriteLine(path);

bool rodando = true;

while (rodando)
{
    Console.WriteLine("Escolha uma opção: ");
    Console.WriteLine("1 - Cadastrar usuário ");
    Console.WriteLine("2 - Listar usuários ");
    Console.WriteLine("3 - Buscar usuários pelo nome ");
    Console.WriteLine("4 - Sair ");

    int opcao = int.Parse(Console.ReadLine());

 
    if(opcao == 1)
    {
        Console.WriteLine(" ---------------------------- ");
        Console.WriteLine("Digite o nome do usuário: ");
        string nome = Console.ReadLine();
        
        Console.WriteLine("Digite a idade do usuário: ");
        int idade = int.Parse(Console.ReadLine());

        string linha = $"{nome};{idade}";
        File.AppendAllText(path, linha + Environment.NewLine);
        
    }

    if(opcao == 2)
    {
        Console.WriteLine(" ---------------------------- ");
        Console.WriteLine("Lista de usuários: ");

        if (!File.Exists(path))
        {
            Console.WriteLine("Nenhum usuário cadastrado.");
        }

        string[] usuarios = File.ReadAllLines(path) ;

        foreach(string usuario in usuarios)
        {
            string[] dados = usuario.Split(';');
            string nome = dados[0];
            string idade = dados[1];
            Console.WriteLine($"Nome: {nome}, Idade: {idade}");
        }

    }

    if(opcao == 3)
    {
        Console.WriteLine(" ---------------------------- ");
        Console.WriteLine("Digite o nomedo usuário para a busca: ");
        string nomeBusca = Console.ReadLine();

        if (!File.Exists(path))
        {
            Console.WriteLine("Nenhum usuário cadastrado.");
        }

        string[] usuarios = File.ReadAllLines(path);
        bool encontrado = false;

        foreach(string usuario in usuarios)
        {
            string[] dados = usuario.Split(';');
            string nome = dados[0];
            string idade = dados[1];

            if(nome == nomeBusca)
            {
                Console.WriteLine($"Usuário encontrado = Nome: {nome}, Idade: {idade}");
                encontrado = true;
            }
            if(!encontrado)
            {
                Console.WriteLine("Usuário não encontrado.");
            }
        }

    }

    if(opcao == 4)
    {
        Console.WriteLine("Saindo...");
        rodando = false;
    }

}
