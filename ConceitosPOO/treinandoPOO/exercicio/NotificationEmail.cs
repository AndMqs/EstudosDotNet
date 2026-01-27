public class NotificacaoEmail : Notificacao
{
    public NotificacaoEmail(string mensagem, string destinatario) 
        : base("Email", mensagem, destinatario)
    {
    }
}