using System.IO.Pipes;

Console.WriteLine("## Exercício 01 ##");

int idade = 35;
Console.WriteLine($"A idade é: {idade}.");

string nome = "Maria";
Console.WriteLine($"O nome é {nome}.");

float altura = 3.45f;
Console.WriteLine($"A altura é: {altura}.");

DateTime data = new DateTime(1999, 09, 04);
Console.WriteLine(data.ToShortDateString());

const int ANO = 12;
Console.WriteLine(ANO);

double? nota = 7.80d;
Console.WriteLine(nota);

int x = 77;
int y = 66;
int soma = x + y;
Console.WriteLine(soma);

Console.ReadLine();