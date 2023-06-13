//Avalia a condição antes de entrar no bloco de execução.

Console.WriteLine("## Expressão While #01\n");

var i = 10;
while (i > 0)
{
    Console.WriteLine($"i= {i}");
    i--;
}

Console.WriteLine("##TABUADA\n");

int numero;
int contador = 1;

Console.WriteLine("Insira um número maior que zero\t");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0 )
{
    Console.WriteLine($"\n## TABUADA DO {numero} ##\n");
    while (contador < 11)
    {
        Console.WriteLine($"{numero} x {contador} = {numero * contador}");
        contador++;
    }
}
else
{
    Console.WriteLine("\n O número deve ser maior que zero!!!");
}



Console.WriteLine("\nFim do processamento...");

Console.ReadKey();