public class Notificacao
{
    
    private string Nome {get;set;}
    private string Destino {get;set;}
    private string Mensagem {get;set;}
    
    public Notificacao(string nome, string destino, string mensagem)
    {
        Nome = nome;
        Destino = destino;
        Mensagem = mensagem;
    }

    public void Enviar()
    {
        Console.WriteLine($"A pessoa "+ Destino + " irá receber essa mensagem: " + Mensagem + " por " + Nome);
    }
}