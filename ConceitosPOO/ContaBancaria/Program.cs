
using ConsoleApp2;
using System;
using aula_poo.ContaBancaria;

Console.WriteLine("Hello, World!");


Console.WriteLine("Digite seu nome:");

string name = Console.ReadLine();
Pessoa pessoa = new Pessoa(name, 30);

Console.WriteLine(" ");

ContaBancaria conta = new ContaBancaria(pessoa);
Console.WriteLine("Você depositou R$500.00 ");
conta.depositarSaldo(500);
Console.WriteLine("Você sacou R$300.00 ");

conta.sacarSaldo(300);
Console.WriteLine("Você tentou sacar R$400.00 ");

conta.sacarSaldo(400);

Console.WriteLine(" ");

conta.exibirSaldo();
conta.exibirTransacoes();