/* 
Instruções

Abra o código fornecido anteriormente.
Adicione as seguintes variáveis:

int quantidadeFrutas = 3;
double precoMedio = 2.50;
bool estoqueDisponivel = true;
string mensagem = "Bem-vindo ao programa de frutas!";


Imprima cada variável com uma frase explicativa, por exemplo:

"Quantidade de frutas: " + quantidadeFrutas
"Preço médio: R$" + precoMedio
"Estoque disponível? " + estoqueDisponivel
mensagem


Faça uma operação simples com cada tipo:

int: Some +2 à quantidade.
double: Aumente o preço médio em 10%.
bool: Inverta o valor (estoqueDisponivel = !estoqueDisponivel).
string: Concatene " Aproveite nossas ofertas!".


Imprima os novos valores após as alterações.

*/


class Program
{
    static void Main(string[] args)
    {
       int quantidadeFrutas = 3;
        double precoMedio = 2.50;
        bool estoqueDisponivel = true;
        string mensagem = "Bem-vindo ao programa de frutas!";

        Console.WriteLine("Quantidade de frutas: " + quantidadeFrutas);
        Console.WriteLine("Preço médio: R$" + precoMedio);
        Console.WriteLine("Estoque disponível? " + estoqueDisponivel);
        Console.WriteLine(mensagem);

        // Operações simples
        quantidadeFrutas += 2;
        precoMedio += (precoMedio * 0.10);
        estoqueDisponivel = !estoqueDisponivel;
        mensagem += " Aproveite nossas ofertas!";

        Console.WriteLine("\nNovos valores após as alterações:");
        Console.WriteLine("Quantidade de frutas: " + quantidadeFrutas);
        Console.WriteLine("Preço médio: R$" + precoMedio);
        Console.WriteLine("Estoque disponível? " + estoqueDisponivel);
        Console.WriteLine(mensagem);
    }
}