//Usar os conceitos de abstração, encapsulamento e herança para expressar o comportamento de contas bancárias.

using System;
using POO_Heranca_Exercicio;

Console.WriteLine("Herança - Exercício\n");

//Conta Corrente:

Console.WriteLine("\nConta Corrente : Número: 2521 Titular: Eduardo Olimpio");
Conta conta = new();
conta.Numero = 2521;
conta.Titular = "Eduardo Olimpio";

Console.WriteLine("Depositando R$ 1.000,00");
conta.Depositar(1000);

Console.WriteLine("Sacando R$ 100,00");
conta.Sacar(100);

Console.WriteLine($"Saldo da conta : {conta.Saldo.ToString("c")}");

Console.WriteLine("Sacando R$ 2000,00");
conta.Sacar(2000);

Console.WriteLine($"Saldo da conta : {conta.Saldo.ToString("c")}");


//Conta Poupança

Console.WriteLine("\nConta Poupança : Número: 2521 Titular: Eduardo Olimpio");
ContaPoupanca contaPoupanca = new();
contaPoupanca.Numero = 2521;
contaPoupanca.Titular = "Eduardo Olimpio";
Console.WriteLine("Depositando R$ 1.000,00");
contaPoupanca.Depositar(1000);
Console.WriteLine($"Saldo da Conta Poupança : {contaPoupanca.Saldo.ToString("c")}");
Console.WriteLine("Sacando R$ 100,00");
contaPoupanca.Sacar(100);
Console.WriteLine($"Saldo da Conta Poupança : {contaPoupanca.Saldo.ToString("c")}");
contaPoupanca.Sacar(3000);

//Conta Investimento

Console.WriteLine("\nConta Investimento : Número: 2521 Titular: Eduardo Olimpio");
ContaInvestimento contaInvestimento = new();
contaInvestimento.Numero = 2521;
contaInvestimento.Titular = "Eduardo Olimpio";
Console.WriteLine("Depositando R$ 1.000,00...");
contaInvestimento.Depositar(1000);
Console.WriteLine($"Saldo da Conta Investimento : {contaInvestimento.Saldo.ToString("c")}");
Console.WriteLine("Sacando R$ 100,00");
contaInvestimento.Sacar(100);
Console.WriteLine($"Saldo da Conta Poupança : {contaInvestimento.Saldo.ToString("c")}");
contaInvestimento.Sacar(3000);





Console.ReadKey();

