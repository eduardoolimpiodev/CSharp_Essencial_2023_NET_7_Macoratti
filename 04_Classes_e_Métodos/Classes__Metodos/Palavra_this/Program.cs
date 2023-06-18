//Representa o objeto que está em execução
Console.WriteLine("Palavra this\n");

Teste t1 = new Teste();
t1.Num1 = 1;
t1.Num2 = 2;
t1.Exibir();

Teste t2 = new Teste();
t2.Num1 = 3;
t2.Num2 = 4;
t2.Exibir();



Console.ReadKey();

public class Teste
{
    public int Num1;
    public int Num2;

    public void PassarParametros(Teste t)
    {
        Console.WriteLine($"\nthis = {this}");
        Console.WriteLine("Num1: " + t.Num1);
        Console.WriteLine("Num1: " + t.Num2);
    }

    public void Exibir()
    {
        PassarParametros(this);
    }
}




