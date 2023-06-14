// Executa o bloco de repetições repetidamente até que a condição específica retorne false.

Console.WriteLine("Laço FOR #02\n");

for(int i = 0, j = 0; i + j <= 20; i++, j++)
{
    Console.WriteLine($"i = {i} e j = {j}");
}

Console.WriteLine();

int u = 1;
for (; u <= 10; )
{
    Console.WriteLine($"u = {u}");
    u++;
}


Console.WriteLine("\nFim do processamento...");

Console.ReadKey();