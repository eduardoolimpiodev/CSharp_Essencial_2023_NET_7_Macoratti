Console.WriteLine("Operadores de Incremento e decremento\n");

int x = 10;
x++;
Console.WriteLine(x);

x--;
Console.WriteLine(x);

// pós-incremento x++
// pré-incremento: ++x

// pós-decremento: x--
// pré-decremento: --x

int z = 0;
int w = 0;
Console.WriteLine($"z = {z}");

// pós-incremento -> primeiro resolve e depois incrementa:
int resultado1 = z++ + 10;
Console.WriteLine($"pós-incremento ==> {resultado1}");
Console.WriteLine($"valor de z ==> {z}\n");

// pré-incremento -> primeiro incrementa e depois resolve a expressão:
int resultado2 = ++w + 10;
Console.WriteLine($"pós-incremento ==> {resultado2}");
Console.WriteLine($"valor de w ==> {w}\n");


Console.ReadKey();
