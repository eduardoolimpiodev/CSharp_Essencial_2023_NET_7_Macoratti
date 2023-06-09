Console.WriteLine("Instrução Switch #01\n");

int compra = 600;
Console.WriteLine("Valor da Compra R$ 600,00 \n");

Console.WriteLine("Insira a quantidade de meses ( 1 a 3):\t");
var prestacao = Convert.ToInt32(Console.ReadLine());

switch (prestacao)
{
    
    case 1:
        Console.WriteLine($"O valor de cada prestação é R$ {compra / prestacao}");
        break;
    case 2:
        Console.WriteLine($"O valor de cada prestação é R$ {compra / prestacao}");
        break;
    case 3:
        Console.WriteLine($"O valor de cada prestação é R$ {compra / prestacao}");
        break;
        default:
        Console.WriteLine("\nValor inválido, informe 1, 2 ou 3");
        break;
}


Console.WriteLine("Informe um número inteiro\t");
int numero = Convert.ToInt32(Console.ReadLine());

switch (numero % 2)
{
    case 0:
        Console.WriteLine("\n" + numero + " é par");
        break;
    case 1:
        Console.WriteLine("\n" + numero + " é ímpar");
        break;
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();
