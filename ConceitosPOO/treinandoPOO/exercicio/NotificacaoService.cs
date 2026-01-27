public static class NotificacaoService
{
    public static void Enviar(Notificacao notificacao)
    {
        notificacao.Enviar();
    }

    public static void Enviar(List<Notificacao> notificacoes)
    {
        Console.WriteLine("Lista de notificações enviadas...");
        foreach(Notificacao notificacao in notificacoes)
        {
            notificacao.Enviar();
        }
    }
}