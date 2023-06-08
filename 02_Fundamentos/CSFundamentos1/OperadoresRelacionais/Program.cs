
Console.WriteLine("Operadores Relacionais \n");

int x = 10;
int y = 20;

Console.WriteLine($"Valor de x: {x}");
Console.WriteLine($"Valor de y: {y}");

bool resultado = x == y;
Console.WriteLine(resultado);


Console.WriteLine(x == y);
Console.WriteLine(x > y);
Console.WriteLine(x < y);
Console.WriteLine(x >= y);
Console.WriteLine(x <= y);
Console.WriteLine(x != y);

Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

// Com String utilizando Equals.
string a = "Cursos";
string b = "cursos";

Console.WriteLine($"Valor de a: {a}");
Console.WriteLine($"Valor de b: {b}\n");

Console.WriteLine(a == b);
Console.WriteLine(a.Equals(b));

Console.ReadKey();
