Console.WriteLine("Struct\n");

Cliente cliente = new();
cliente.Nome = "Eduardo";
cliente.Idade = 37;

Console.WriteLine($"{cliente.Nome}, {cliente.Idade}.");


MinhaClasse mcls1 = new(), mcls2 = null;
MinhaStruct mstr1 = new(), mstr2 = new();

mcls1.x = mstr1.x = 5;
mcls1.y = mstr1.y = 10;

mcls2 = mcls1; //ref
mstr2 = mstr1; //valor



Console.ReadKey();


public struct Cliente
{
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public Cliente(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}



public class MinhaClasse
{
    public int x;
    public int y;
}

public struct MinhaStruct
{
    public int x;
    public int y;
}