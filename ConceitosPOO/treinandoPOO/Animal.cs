using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;

public class Animal{

    public string Nome {get; set;}
    

    public Animal(string nome)
    {
        Nome = nome;
    }

//virtual define que o método pode ser sobrescrito pela classe filha
   public virtual string EmitirSom()
   {
        return "";
   }

}

