public class NotificacaoSms : Notificacao
{
    public NotificacaoSms(string mensagem, string numero) 
        : base("Sms", mensagem, numero)
    {
    }
}