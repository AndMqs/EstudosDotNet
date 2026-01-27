/*
- Crie uma lista de inteiros chamada numeros.

- Adicione três números à lista: 10, 20, 30.

- Imprima todos os números usando um foreach.

- Atualize o número na posição 1 (índice 1) para 50.

- Atualize o número 10 para 5 utilizando indexOf para achar o índice.

- Remova o número 30 da lista.

- Imprima novamente os números atualizados.

- Mostre na tela a quantidade de itens na lista (Count).
namespace DemoTiposDeDados
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();
        numeros.Add(10);
        numeros.Add(20);
        numeros.Add(30);

        Console.WriteLine("Lista original:");
        imprimirLista(numeros);

        Console.WriteLine("\nLista atualizada (alterando por índice):");
        numeros[1] = 50;
        imprimirLista(numeros);

        Console.WriteLine("\nLista atualizada (usando IndexOf):");
        int indice = numeros.IndexOf(10);
        if (indice != -1)
        {
            numeros[indice] = 5;
        }
        imprimirLista(numeros);

        Console.WriteLine("\nLista atualizada (removendo 30):");
        numeros.Remove(30);
        imprimirLista(numeros);

        Console.WriteLine($"Quantidade de itens na lista: {numeros.Count}");
    }

    private static void imprimirLista(List<int> lista)
    {
        foreach (var num in lista)
        {
            Console.WriteLine($"Número: {num}");
        }
    }
}

