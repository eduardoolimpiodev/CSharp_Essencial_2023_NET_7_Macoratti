//Executa o código pelo menos uma vez, antes de avaliar a condição, depois executa o código novamente e avalia novamente a condição.
Console.WriteLine("Loop Do-While\n");


var i = 1;

do
{
    Console.WriteLine($"i = {i}");
    i++;
    if (i > 7)
        break;
}
while (i <= 10);

Console.WriteLine("\nFim do programa...");


Console.ReadLine();