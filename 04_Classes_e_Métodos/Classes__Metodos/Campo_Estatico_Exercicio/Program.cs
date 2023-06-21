Console.WriteLine("Campo Estático - Exercício\n");

ContaCorrente c1 = new ContaCorrente();
c1.Conta = 101;
c1.Nome = "Maria";
c1.Juros = 3.99f;

ContaCorrente c2 = new ContaCorrente();
c2.Conta = 102;
c2.Nome = "Eduardo";
c2.Juros = 4.99f;

Console.WriteLine();


Console.ReadKey();

public class ContaCorrente
{
    public int Conta;
    public string? Nome;
    public float Juros;

    public float JurosAnual()
    {
        return Juros * 12;
    }
}