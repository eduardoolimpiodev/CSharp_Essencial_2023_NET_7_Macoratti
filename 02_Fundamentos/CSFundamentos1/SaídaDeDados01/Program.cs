Console.WriteLine("Saída de dados: Formatação!");
Console.WriteLine();

int idade = 25;
string nome = "Maria";
Console.WriteLine(idade);
Console.WriteLine(nome);

// Maria tem 25 anos
Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.Write(" anos.");
Console.WriteLine();

// Concatenação
Console.WriteLine(nome + " tem " + idade + " anos.");

// Interpolação de strings
Console.WriteLine($"{nome} tem {idade} anos.");

// com place holders: usa {} com numeração com início em zero

Console.WriteLine("{0} tem {1} anos.", nome, idade);



Console.ReadLine();
