Exercício – Sistema de Biblioteca
Descrição

Você deverá desenvolver um sistema orientado a objetos que simula o funcionamento básico de uma biblioteca. O sistema será operado pelo bibliotecário e deve permitir as seguintes funcionalidades:
O sistema será composto por três classes:

-Livro (deve conter um status - “Disponível” ou “Emprestado” e o nome do locador)
-Pessoa (deve conter os livros que estão em sua posse)
-Biblioteca (deve armazenar a lista de livros e de pessoas)

O sistema deve conter um menu onde o bibliotecário pode:
1- Listar todos os livros e seus respectivos status
2- Emprestar um livro (exige cadastro do locatário)
3- Sair
 

1º Passo - Criar um projeto
Visual Studio Code
Criar uma pasta que irá conter o projeto
Usar o comando dotnet new console para criar um novo projeto

Visual Studio Community
Clicar em “Novo projeto”

2º Passo - Criar a classe Livro
Quais os atributos de um livro? 

Tombo int
Titulo string
Status string // ‘Disponível’ ou ‘Emprestado’
Locatario string 

O que o bibliotecário pode fazer com o livro?

Construtor()
Emprestar(string nomeLocatario)
Devolver()




3º Passo - Criar a classe Pessoa
Quais os atributos da pessoa? 

ID int
Nome string
Livros List<Livro>

O que uma pessoa pode fazer?

Constutor() // id, nome/ livros = []
PegarLivro(Livro livro) 
ele vai adicionar o livro enviado na minha lista de livros

DevolverLivro(Livro livro)
ele vai remover um livro da minha lista de livros

4º Passo - Criar a classe Biblioteca
Quais os atributos da biblioteca? 

Livros List<Livro>
Pessoas List<Pessoa>

O que a biblioteca pode fazer?
CadastrarLivro(Livro livro)
// Adicionar um livro na minha lista de livros

CadastrarUsuario(Pessoa pessoa)
// adicionar um usuário na minha lista de livros

ListarLivros()
// percorrer os itens da lista e exibir id, nome e status de cada livro

EmprestarLivro(Livro livro, Pessoa pessoa)
// mudar o status do livro para emprestado -> livro.Emprestar()
// adicionar o livro na lista do usuario -> pessoa.PegarLivro()



5º Passo - Adicione livros na lista da biblioteca
Usar o metodo Cadastrar Livro

6º Passo - Crie a primeira opção do menu (listar todos os livros)

7º Passo - Crie a segunda opção do menu (emprestar livro)

Passo a passo do empréstimo:
- Por favor, registre o locatario
- Digite o nome do locatario:
- CadastrarUsuario na biblioteca
- Por favor, escolha o livro desejado
- Listar todos os livros para o usuario escolher pelo ID
- Pegar o livro escolhido pelo ID 
- EmprestarLivro(livroEscolhido, pessoaCadastrada)



8º Passo - Crie a terceira opção do menu (sair)

9º Passo - Crie o repositório do github
