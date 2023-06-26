Console.WriteLine("Arrays #01\n");

int[] numerosInteiros;
numerosInteiros = new int[10]
{
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10
};

Console.WriteLine(numerosInteiros[0]);
Console.WriteLine(numerosInteiros[1]);
Console.WriteLine(numerosInteiros[2]);
Console.WriteLine(numerosInteiros[3]);
Console.WriteLine(numerosInteiros[4]);
Console.WriteLine(numerosInteiros[5]);
Console.WriteLine(numerosInteiros[6]);
Console.WriteLine(numerosInteiros[7]);
Console.WriteLine(numerosInteiros[8]);
Console.WriteLine(numerosInteiros[9]);
Console.WriteLine("\n");

string[] nomes = new string[3]
{
    "Eduardo",
    "Maria",
    "Marcele"
};

string[] nomes2 =
{
    "José",
    "Maria",
    "João"
};


Console.WriteLine(nomes2[0]);
Console.WriteLine(nomes2[1]);
Console.WriteLine(nomes2[2]);

Console.WriteLine("\n");

int[] numeros1;
numeros1 = new int[3];

numeros1[0] = 1;
numeros1[1] = 2;
numeros1[2] = 3;

Console.WriteLine(numeros1[0]);
Console.WriteLine(numeros1[1]);
Console.WriteLine(numeros1[2]);

Console.ReadKey();
