Console.WriteLine("Bloco Try Catch - Tratamento de Erros\n");

Console.WriteLine("Divisão de números inteiros");
Console.WriteLine(" x / y");

Console.WriteLine("\nInforme o valor de X");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nInforme o valor de Y");
int y = Convert.ToInt32(Console.ReadLine());





try
{
    int z = x / y;
    Console.WriteLine($"\n{x} / {y} = {z}");
}
catch (Exception ex)
{

    Console.WriteLine("\nNão existe divisão por zero, tente outro número.");

    Console.WriteLine($"\nErro: <<< {ex.Message} >>>");
    Console.WriteLine($"\nDetalhes : {ex?.StackTrace?.ToString()}");
}
finally
{
    Console.WriteLine("Fim do programa...");
}


Console.ReadKey();