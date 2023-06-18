Console.WriteLine("Metodos Geral\n");

//Cliente cliente = new Cliente();

Cadastro cadastro = new Cadastro();
var cliente = cadastro.Registrar();

cadastro.ExbirDados(cliente);

//Alterar Renda
cliente = cadastro.Registrar(cliente);
cadastro.ExbirDados("Renda Alterada", cliente);

Console.ReadKey();


public class Cliente
{
    public string? Nome;
    public int Idade;
    public decimal Renda;

    public Cliente(string? nome, int idade, decimal renda)
    {
        Nome = nome;
        Idade = idade;
        Renda = renda;
    }

    public Cliente()
    {}
}

public class Cadastro
{
    public Cliente Registrar()
    {
        Cliente cliente = new("Eduardo", 37, 5000);
        return cliente;
    }

    public Cliente Registrar(Cliente cliente)
    {
        cliente.Renda = 6000;
        return cliente;
    }

    public void ExbirDados(Cliente cliente)
    {
        Console.WriteLine($"{cliente.Nome} {cliente.Idade} {cliente.Renda.ToString(("c"))}");
    }

    public void ExbirDados(string texto, Cliente cliente)
    {
        Console.Write($"\n{texto}\t");
        Console.Write($"{cliente.Nome} {cliente.Renda.ToString(("c"))}");
    }
}
