Console.WriteLine("Construtor Estático\n");

Pessoa p1 = new("Maria", 18);

Console.WriteLine(p1.Nome + " - " + p1.Idade);
Console.WriteLine("Idade Mínima : " + Pessoa.IdadeMinima);



Console.ReadKey();


public class Pessoa
{
    public static int IdadeMinima;

    public string? Nome { get; set; } = string.Empty;
    public int Idade { get; set; }

    public Pessoa(string? nome, int idade)
    {
        Console.WriteLine($"\nExecutando o contrutor parametrizado");
        Nome = nome;
        Idade = idade;
    }

    public Pessoa() { }

    static Pessoa()
    {
        Console.WriteLine("\nExecutando o construtor estático.");
        Console.WriteLine("Inicializando o campo IdadeMinima");
        IdadeMinima = 18;
    }
}