Console.WriteLine("Exercício 08\n");


//struct
Cliente cliente = new("Maria", "maria@email.com", 19);
Cliente.ExibirInfo(email: cliente.Email, nome: cliente.Nome, idade: cliente.Idade);
Console.WriteLine("\nExibindo informação sem informar a idade");
Cliente.ExibirInfo(email: cliente.Email, nome: cliente.Nome);


Console.ReadKey();

public struct Cliente
{
    public string Nome;
    public string Email;
    private int idade;
    public int Idade
    {
        get { return idade; }
        set
        {
            if (value < 18)
            {
                idade = 18;
                Console.WriteLine("Cliente menor que 18 anos");
            }
            else
            {
                Console.WriteLine("Cliente maior que 18 anos");
                idade = value;
            }
        }
    }
    public Cliente(string nome, string email, int idade)
    {
        Nome = nome;
        Email = email;
        Idade = idade;
    }
    public static void ExibirInfo(string nome, string email, int idade = 18)
    {
        Console.WriteLine($"{nome} - {email} - {idade}");
    }
}

