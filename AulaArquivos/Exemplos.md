### Exemplos do exercício feito em aula

```
Console.WriteLine("-- Geração de arquivos --");


string directory = "testes";
if (!Directory.Exists(directory))
{
    Directory.CreateDirectory(directory);
}


Console.WriteLine("Digite o nome do arquivo (com extensão): ");
string file = Console.ReadLine();

string path = Path.Combine(directory,file);
Console.WriteLine(path);

Console.WriteLine("1 - Escrever um texto ");
Console.WriteLine("2 - Adicionar um texto (sem apagar o anterior) ");
Console.WriteLine("3 - Ler o texto do arquivo ");
int option = int.Parse(Console.ReadLine());

if(option == 1)
{
    Console.WriteLine("Digite o texto escolhido: ");
    string text = Console.ReadLine();
    File.WriteAllText(path, text);
    return;
}

if(option == 2)
{
    Console.WriteLine("Digite o texto a ser adicionado: ");
    string text = Console.ReadLine();
    File.AppendAllText(path, "\n"+text);
    return;
}

if(option == 3)
{
    //string text = File.ReadAllText(file);
    //Console.WriteLine(text);
    string[] lines = File.ReadAllLines(path);
    foreach(string line in lines)
    {
        Console.WriteLine(line);
    }

    return;
}

Console.WriteLine(Directory.GetCurrentDirectory());
Console.WriteLine(path);
Console.WriteLine(option);

```
