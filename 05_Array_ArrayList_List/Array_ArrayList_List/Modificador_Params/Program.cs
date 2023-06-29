//Usamos o método static para não precisar de criar uma instância nova da classe Calcular para acessar o método Soma.
Console.WriteLine("Modificador Params\n");

int[] valores = { 1, 2, 3, 4, 5 };
Calcular.Soma(valores);

var resultado = Calcular.Soma(valores);
Console.WriteLine(resultado);

var resultado2 = Calcular.Soma(new int[] { 10, 20, 30 });
Console.WriteLine(resultado2);

//Com o argumento Params
int resultado3 = Calcular.Soma(10, 20, 30, 40, 50);
Console.WriteLine(resultado3);

Console.ReadKey();

public class Calcular
{
    public static int Soma(params int[] numeros)
    {
        int total = 0;
        foreach (var numero in numeros)
        {
            total += numero;
        }
        return total;
    }
}
