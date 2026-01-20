/*
1 - Crie um array de string com 3 posições. 
2 - Preencha o array com 3 frutas (por exemplo: Banana, Maçã, Uva). 
3 - Imprima todas as frutas usando um laço for. 
4 - Atualize a fruta na posição 1 para "Pera". 5 - Reimprima o array atualizado.
*/

class Program
{
    static void Main(string[] args)
    {
        string[] frutas = new string[3];
        frutas[0] = "Maçã";
        frutas[1] = "Pitaya";
        frutas[2] = "Banana";

        for(int i = 0; i < frutas.Length; i++)
        {
            Console.WriteLine($"Fruta na posição {i} : {frutas[i]}");
        }

        frutas[1] = "Pera";

        Console.WriteLine("\nArray atualizado:");

        for(int i = 0; i < frutas.Length; i++)
        {
            Console.WriteLine($"Fruta na posição {i} : {frutas[i]}");
        }
    }
}