Console.WriteLine("## Nullable Types ##\n");

Nullable<int> i = null;
Nullable<double> d = null;
Nullable<bool> b = null;

Console.WriteLine(i);
Console.WriteLine(d);
Console.WriteLine(b);

Console.WriteLine("## Simplificar a declaração do Nullable Type ##\n");

int? i2 = null;
double? d2 = null;
float? f2 = null;
bool? b2 = null;

Console.WriteLine(i2);
Console.WriteLine(d2);
Console.WriteLine(f2);
Console.WriteLine(b2);

Console.WriteLine("## Operador de coalescência nula ##\n");

int? a3 = null;
int b3 = a3 ?? 10;
Console.WriteLine(b3);

int? x = 4;
int? y = 3;
int? z = x * y;
Console.WriteLine(z);

Console.WriteLine("## Propriedades somente leitura: HasValue e Value. ##\n");

int? p = 100;
if(p.HasValue)
{
    Console.WriteLine($"p = {p.Value}");
}
else
{
    Console.WriteLine("p não possui um valor, ou seja, é null.");
}


Console.ReadKey();
