using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{

    internal class ContaBancaria
    {
        private double saldo;
        private Pessoa titular;
        // Como declarar uma lista em C#
        // List<string> nomes = new List<string>();

        // Como declarar um array em C#
        // string[] nomesArray = new string[5];

        //Como declarar um dicionário em C#
        // Dictionary<string, int> idades = new Dictionary<string, int>();

        private List<Transacao> historicoTransacoes = new List<Transacao>();

        public ContaBancaria(Pessoa pessoa)
        {
            saldo = 0;
            historicoTransacoes = new List<Transacao>();
            titular = pessoa;
        }

        public void depositarSaldo(double valor)
        {
            saldo += valor;
            Transacao transacao = new Transacao();
            transacao.tipo = "Depósito";
            transacao.valor = valor;

            historicoTransacoes.Add(transacao);
        }

        public void sacarSaldo(double valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
            }
            else
            {
                saldo -= valor;

                Transacao transacao = new Transacao();
                transacao.tipo = "Saque";
                transacao.valor = valor;

                historicoTransacoes.Add(transacao);
            }
        }

        public void exibirSaldo()
        {
            Console.WriteLine($"Olá {titular.Nome}, seu saldo é de atual: R$ {saldo}");
        }

        public void exibirTransacoes()
        {
            foreach (var transacao in historicoTransacoes)
            {
                Console.WriteLine($"{transacao.tipo}: R$ {transacao.valor}");
            }
        }
    }
}