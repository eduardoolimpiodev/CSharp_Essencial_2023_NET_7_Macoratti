//Executa o código pelo menos uma vez, antes de avaliar a condição, depois executa o código novamente e avalia novamente a condição.
Console.WriteLine("Loop Do-While Aninhado\n");


int x = 0;
do
{
    int y = 0;
    do
    {
        Console.Write($"({x},{y}) ");
        y++;
    }
    while (y < 5);
    x++;
    Console.WriteLine();
}
while (x < 5);


Console.WriteLine("\nFim do programa...");


Console.ReadLine();