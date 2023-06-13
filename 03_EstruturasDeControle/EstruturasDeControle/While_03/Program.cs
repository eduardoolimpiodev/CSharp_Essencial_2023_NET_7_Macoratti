Console.WriteLine("Instrução While Aninhado #03\n");
Console.WriteLine("Coordenadas de um plano cartesiano para x e y\n");

int x = 0;
while(x < 5)
{
    int y = 0;
    while (y < 5)
    {
        Console.Write($"({x},{y}) ");
        y++;
    }
    x++;
    Console.WriteLine();
}


Console.WriteLine("\nFim do processamento...");
Console.ReadKey();
