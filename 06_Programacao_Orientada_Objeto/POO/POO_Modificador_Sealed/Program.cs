//Quando aplicado a uma classe, o modificador sealed impede que outras classes herdem dela. Ou seja, impede a herança da classe base.

Console.WriteLine("Modificador Sealed\n");

Cliente cli = new();
cli.Nome = "Eduardo";
cli.ExibeNome();


Console.ReadKey();


//sealed class MinhaClasseBase
//{

//}

//class MinhaSubclasse : MinhaClasseBase
//{

//}

sealed class Pessoa
{
    public string? Nome { get; set; }
    public void ExibeNome()
    {
        Console.WriteLine($"Meu nome é {Nome}");
    }
}

class Cliente : Pessoa
{
    public void ExibeNome()
    {
        Console.WriteLine($"\nNome do cliente : {Nome}");
    }
}