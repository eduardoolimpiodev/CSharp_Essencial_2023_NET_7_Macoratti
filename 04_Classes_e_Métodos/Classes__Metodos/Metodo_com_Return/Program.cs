Console.WriteLine("Metodo com Return\n");


Calculadora calc = new Calculadora();
int valor = calc.Somar(1, 2);
Console.WriteLine(valor);
Console.WriteLine(calc.Somar(1,2));


Console.ReadKey();

public class Calculadora
{
    public int Somar(int n1, int n2)
    {
        return n1 + n2;
    }

    public int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }

    public int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }

    public int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }
}