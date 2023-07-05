//Tanto a classe base e a classe derivada podem possuir seus próprios construtores.
//A classe derivada não vai herdar o construtor da classe base, mas pode invoca-lo.
Console.WriteLine("### Herança - Construtores\n");


Aluno aluno1 = new();
Aluno aluno2 = new("Eduardo");


Console.ReadKey();  

//classe base
class Pessoa
{
	public Pessoa()
	{
        Console.WriteLine("Construtor da classe Pessoa - Classe Base");
    }
    public Pessoa(string nome)
    {
        Console.WriteLine("Construtor da classe Pessoa - Classe Base - Com parâmetro.");
    }
}

//classe derivada
class Aluno : Pessoa
{
    public Aluno() : base()
    {
        Console.WriteLine("Construtor da classe Aluno - Classe Derivada");
    }
    public Aluno(string nome) : base(nome)
    {
        Console.WriteLine("Construtor da classe Aluno - Classe Derivada - Com parâmetro.");
    }
}