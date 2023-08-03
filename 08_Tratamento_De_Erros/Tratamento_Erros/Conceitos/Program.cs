Console.WriteLine("Bloco Try, Catch, Finally\n");

try
{
	Console.WriteLine("\nInforme o dividendo");
	int dividendo = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("\nInforme o divisor");
	int divisor = Convert.ToInt32(Console.ReadLine());

	int resultado = (dividendo/divisor);
	Console.WriteLine($"\n{dividendo} / {divisor} = {resultado}\n");
	
	Console.ReadKey();
}
catch (FormatException)
{
    Console.WriteLine($"\n Informe um valor inteiro.");
    //Console.WriteLine($"\n{ex.GetType()} informa : {ex.Message}");
    //Console.WriteLine($"\n{ex.Message}");
    //Console.WriteLine($"\n{ex.Source}");
    //Console.WriteLine($"\n{ex.StackTrace}");
}
catch(OverflowException)
{
    Console.WriteLine("Informe um valor inteio entre 1 e 999999.");
}
catch(DivideByZeroException)
{
    Console.WriteLine("Não existe divisão por zero, tente novamente.");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}



