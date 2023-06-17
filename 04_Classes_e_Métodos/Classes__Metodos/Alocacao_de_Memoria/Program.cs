Console.WriteLine("Alocacao de Memoria\n");


int x = 100;

Pessoa p1 = new Pessoa();
p1.Nome = "Eduardo";
p1.Idade = 37;
p1.Sexo = "Masculino";

Console.WriteLine($"{p1.Nome} {p1.Idade} {p1.Sexo}");

Pessoa p2 = p1;


//Pessoa p2 = new Pessoa();
//p2.Nome = "Maria";
//p2.Idade = 72;
//p2.Sexo = "Feminino";

Console.WriteLine($"{p2.Nome} {p2.Idade} {p2.Sexo}");

Console.ReadKey();

class Pessoa
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string? Sexo { get; set; }
}