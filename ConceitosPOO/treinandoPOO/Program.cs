
//Cachorro dog = new Cachorro("Billy", "Bulldog");
//Console.WriteLine("O nome do cachorro é " + dog.Nome + ". Sua raça é: " + dog.Raca);
//Console.Write($"O cachorro faz: "); dog.EmitirSom();

//Cachorro dog1 = new Cachorro("Ted", "Pug");
//Console.WriteLine("O nome do cachorro é " + dog1.Nome + ". Sua raça é: " + dog1.Raca);
//Console.Write($"O cachorro faz: "); dog1.EmitirSom();

//Gato cat = new Gato("Dina", "SRD");
//Console.WriteLine("O nome do gato é " + cat.Nome + ". Sua raça é: " + cat.Raca);
//Console.Write($"O cachorro faz: "); cat.EmitirSom();



//Crie uma lista de animais (do tipo Animal), adicione um gato, umcachorro e outro animal definido por vc.
//Percorra essa lista e emita, para cada animal,seu nome e seu som;

//List<Animal> animais = new List<Animal>();
//animais.Add(dog);
//animais.Add(dog1);
//animais.Add(cat);

//foreach (Animal animal in animais)
//{
//    Console.WriteLine($"Meu animal {animal.Nome} faz esse som {animal.EmitirSom()}");
//}

//Notificacao notificacao1 = new Notificacao("Andresa", "Maria", "Não irei hoje...");
//Notificacao notificacao2 = new Notificacao("Bob", "Jim", "Futebol amanhã? ...");
//NotificacaoService.Enviar(notificacao1);
//NotificacaoService.Enviar(notificacao2);

//Console.WriteLine("---------------------------");

//List<Notificacao> notificacoes = new List<Notificacao>();
//notificacoes.Add(notificacao1);
//notificacoes.Add(notificacao2);
//NotificacaoService.Enviar(notificacoes);

Console.WriteLine("---------------------------");

Notificacao notificacao1 = new NotificacaoEmail("Chefe", "Estou doente...");
Notificacao notificacao2 = new NotificacaoSms("Bia", "Oi! Vamos sair hoje?...");
Notificacao notificacao3 = new NotificacaoWhatsApp("Empregado", "Estou indisponível no momento...");
List<Notificacao> notificacoes = [notificacao1, notificacao2, notificacao3];
NotificacaoService.Enviar(notificacoes);

