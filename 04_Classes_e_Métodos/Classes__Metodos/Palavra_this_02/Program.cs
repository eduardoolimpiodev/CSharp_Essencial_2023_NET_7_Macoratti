//Invocar outro construtor da mesma classe
Console.WriteLine("Palavra this #02\n");

Teste t1 = new Teste(999);


Console.ReadKey();

public class Teste
{
    public Teste(int num1, int num2)
    {
        Console.WriteLine($"\nConstrutor com dois parâmetros {num1} e {num2}");
    }

    public Teste(int num) : this(777, 888)
    {
        Console.WriteLine("\nContrutor com um parâmetro " + num);
    }
}
