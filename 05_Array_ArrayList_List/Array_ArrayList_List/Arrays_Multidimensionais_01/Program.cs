//Aloca memória, declara e inicializa o array.
Console.WriteLine("Arrays Multidimensionais\n");

int[,] a;

a = new int[2, 2];

a[0, 0] = 0;
a[0, 1] = 1;
a[1, 0] = 2;
a[1, 1] = 3;

Console.WriteLine("\nArray a\n");


Console.WriteLine(a[0, 0]);
Console.WriteLine(a[0, 1]);
Console.WriteLine(a[1, 0]);
Console.WriteLine(a[1, 1]);

int[,] b = new int[2, 2] { { 20, 30 }, { 40, 50 } };

Console.WriteLine("\nArray b\n");

Console.WriteLine(b[0, 0]);
Console.WriteLine(b[0, 1]);
Console.WriteLine(b[1, 0]);
Console.WriteLine(b[1, 1]);


Console.ReadKey();
