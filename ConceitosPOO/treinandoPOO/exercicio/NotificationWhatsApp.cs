public class NotificacaoWhatsApp : Notificacao
{
	public NotificacaoWhatsApp(string mensagem, string destinatario)
		: base("WhatsApp", mensagem, destinatario)
	{
	}
}