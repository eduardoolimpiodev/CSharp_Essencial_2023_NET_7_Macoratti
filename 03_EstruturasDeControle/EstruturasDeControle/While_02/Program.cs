Console.WriteLine("Instrução While 02\n");

while(true)
{
    Console.WriteLine("\nInforme um número inteiro: (Para sair, tecle 999)");
    int numero = Convert.ToInt32(Console.ReadLine());

    if(numero == 999)
    {
        break;
    }

    if(numero%2 == 0)
    {
        Console.WriteLine($"{numero} é PAR!");
    }
    else
        Console.WriteLine($"{numero} é ÍMPAR!");

}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();  
