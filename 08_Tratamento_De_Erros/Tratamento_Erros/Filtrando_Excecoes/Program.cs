Console.WriteLine("Filtrando Exceções\n");


try
{
    Console.WriteLine("\nInforme o dividendo");
    int dividendo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nInforme o divisor");
    int divisor = Convert.ToInt32(Console.ReadLine());

    int resultado = (dividendo / divisor);
    Console.WriteLine($"\n{dividendo} / {divisor} = {resultado}\n");

    Console.ReadKey();
}
catch (DivideByZeroException ex) when (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
{
    Console.WriteLine($"\n Hoje é sexta-feira e não capturamos estas exeções por motivos óbvios...\n\nSextouuuuuu\n\n");
    //Console.WriteLine($"\n{ex.GetType()} informa : {ex.Message}");
    //Console.WriteLine($"\n{ex.Message}");
    //Console.WriteLine($"\n{ex.Source}");
    //Console.WriteLine($"\n{ex.StackTrace}");
}
catch (Exception ex) when (ex.Message.Contains("format"))
{
    Console.WriteLine("filtro de exceção com format.");
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.Message);
}





Console.ReadKey();
