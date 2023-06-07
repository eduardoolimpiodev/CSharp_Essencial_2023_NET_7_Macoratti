// Link tabela ASCII : https://web.fe.up.pt/~ee96100/projecto/Tabela%20ascii.htm

Console.WriteLine("## Entrada de dados ##\n");

Console.WriteLine("\nInforme o seu nome:");

string nome = Console.ReadLine();

Console.WriteLine($"\nO seu nome é: {nome}.");

Console.WriteLine("\nInforme a sua idade:");

int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nA sua idade é: {idade}.");


Console.ReadKey();

