Console.WriteLine("Definindo variáveis do tipo string, object e dynamic.");

string nome = "Curso C#";
string titulo = "Curso C# Essencial";

Console.WriteLine(nome);
Console.WriteLine(titulo);

//As strings são imutáveis.

string valor = "Isto é uma string";
valor = "Isto é uma string alterada";

Console.WriteLine(valor);

//Tipo object suporta todos os tipos de dados.

object nota1 = 10;
object valor1 = 8.55m;
object nome1 = "Maria";
object ativa = true;
object letra1 = 'A';

Console.WriteLine(nota1);
Console.WriteLine(valor1);
Console.WriteLine(nome1);
Console.WriteLine(ativa);
Console.WriteLine(letra1);

//Tipo dynamic também suporta todos os tipos de dados. Ele é útil quando precisamos usar recursos avançados como Reflection e/ou recursos da linguagem dinamica.

dynamic nota2 = 10;
dynamic valor2 = 8.55m;
dynamic nome2 = "Maria";
dynamic ativa1 = true;
dynamic letra2 = 'A';

Console.WriteLine(nota2);
Console.WriteLine(valor2);
Console.WriteLine(nome2);
Console.WriteLine(ativa1);
Console.WriteLine(letra2);



Console.ReadLine();
