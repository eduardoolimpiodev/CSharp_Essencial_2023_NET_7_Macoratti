// Executa o bloco de repetições repetidamente até que a condição específica retorne false.

Console.WriteLine("Laço FOR Aninhado\n");

for(int x = 0; x<5; x++)
{
    for(int y = 0; y<5; y++)
    {
        Console.Write($"({x}, {y}) ");
    }
    Console.WriteLine();
}

Console.WriteLine("\nFim do processamento...");

Console.ReadKey();