using System;
public static class Validador
{
        
    public static void EhMaiorDeIdade(int idade)
    {
        if (idade < 18)
        {
            Console.WriteLine("Você não é maior de idade.");
        }
        else
        {
            Console.WriteLine("Você é maior de idade.");

        }
    }

    public static void EmailValido(string email)
    {
        if(email.Contains("@") && email.Contains(".com"))
        {
            Console.WriteLine("Esse email é valido.");
        }
        else
        {
            Console.WriteLine("E-mail inválido.");
        }
    }

}