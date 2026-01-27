# Exercício – Polimorfismo e sobrecarga

---

## Descrição - Apenas sobrecarga

Você tem uma classe chamada ‘Notificacao’ no seu sistema.


Uma notificacao tem:
- Nome
- Destinatario
- Mensagem
- Enviar() -> deve exibir um “A seguinte mensagem … foi enviada para …”


Crie uma classe NotificacaoService, ela terá dois metodos:

- Enviar(Notificacao notificacao) -> deve enviar uma unica notificacao 
- Enviar(List<Notificacao> notificacoes) -.> deve percorrer a lsita de enviar uma por uma


**Lembre-se de testar!**


---

## Descrição - Polimorfismo + Sobrecarga

Você tem o seguinte código abaixo:

```
public class NotificacaoService {
    public void Enviar(string tipo, string destino, string mensagem)
    {
        if (tipo == "Email")
            Console.WriteLine($"EMAIL para {destino}: {mensagem}");
        else if (tipo == "SMS")
            Console.WriteLine($"SMS para {destino}: {mensagem}");
        else if (tipo == "WhatsApp")
            Console.WriteLine($"WHATSAPP para {destino}: {mensagem}");
        else
            Console.WriteLine("Tipo inválido.");
    }
}

```

Refatore-o para:
- Notificacao (classe pai)
- NotificacaoEmail, NotificacaoSms, NotificacaoWhatsApp

No NotificacaoService, ele terá dois métodos:

- Enviar(Notificacao notificacao)
- Enviar(List<Notificacao> notificacoes)


**Lembre-se de testar!**
