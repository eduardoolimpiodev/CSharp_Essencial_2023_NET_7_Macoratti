/*
    GetHashCode e Equals são métodos da classe Object que são usados para comparar se dois objetos são iguais.
    Todos os objetos no C# herdam de Object e assim herdam os métodos GetHashCode e Equals.
    GetHashCode retorna um valor inteiro (código Hash) com base nas informações do objeto ( estado do objeto ), 
    enquanto Equals compara o objeto com outro objeto e retorna um booleano indicando se eles são iguais.
*/

Console.WriteLine("GetHashCode e Equals #02\n");

string a = "Eduardo";
string b = "Fátima";

int x = 100;
int y = 100;

Console.WriteLine(a + " = " + a.GetHashCode());
Console.WriteLine(b + " = " + b.GetHashCode());
Console.WriteLine(x + " = " + x.GetHashCode());
Console.WriteLine(y + " = " + y.GetHashCode());



var pessoa1 = new Pessoa(1, "Eduardo");
var pessoa2 = new Pessoa(1, "Eduardo");
Console.WriteLine(pessoa1.GetHashCode());
Console.WriteLine(pessoa2.GetHashCode());
//Pessoa1 e Pessoa2 não são o mesmo objeto e possuem referências diferentes.

public class Pessoa
{
    public Pessoa(int id, string? nome)
    {
        Id = id;
        Nome = nome;
    }

    public int Id { get; set; }
    public string? Nome { get; set; }
}

//Console.ReadKey();