Console.WriteLine("Intrução If");

Console.WriteLine("Cliente Especial (S/N) ");
var resposta = Console.ReadLine();

if (resposta == "S")
{
    Console.WriteLine("Desconto de 10%");
}

Console.WriteLine("FIM do PROCESSAMENTO!");

Console.WriteLine("********************************\n");

Console.WriteLine("Cliente Especial (true/false) ");
var resposta2 = Convert.ToBoolean(Console.ReadLine());

if (resposta2)
{
    Console.WriteLine("Desconto de 10%");
}

Console.WriteLine("FIM do PROCESSAMENTO!");

Console.WriteLine("********************************\n");


Console.WriteLine("Informe o valor de x \t");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y \t");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("X é maior que Y");
}
if (x < y)
{
    Console.WriteLine("X é menor que Y");
}
if (x == y)
{
    Console.WriteLine("X é igual a Y");
}



Console.ReadKey();
