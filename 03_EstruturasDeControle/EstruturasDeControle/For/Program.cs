// Executa o bloco de repetições repetidamente até que a condição específica retorne false.

Console.WriteLine("Laço FOR\n");

int resultado, numero;
Console.WriteLine("Informe o número inteiro maior que zero: \t");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    for (int i = 1; i <= 10; i++)
    {
        resultado = numero * i;
        Console.WriteLine($"{numero} X {i} = {resultado}");
    }
}
else
{
    Console.WriteLine("Número inválido!");
}
Console.WriteLine("\nFim do processamento...");

Console.ReadKey();