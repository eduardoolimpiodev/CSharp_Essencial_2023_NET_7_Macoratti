/*
 Se quisermos que um membro da subclasse substitua um membro com o mesmo nome na classe base, deve-se fazer o seguinte: 
    1 - Usar o modificador virtual na declaração do membro da classe base.
    2 - A seguir, usar o modificador override na declaração do memebro na classe derivada.
    Virtual trabalha em conjunto com o Override.
*/

Console.WriteLine("Herança - Virtual e Override\n");

var gato = new Gato();
gato.Nome = "Eduardo";
gato.ExibeNome();

var cao = new Cachorro();
cao.Nome = "Pipoca";
cao.ExibeNome();



Console.ReadKey();


//classe base
class Animal
{
    public string? Nome { get; set; }
    public virtual void ExibeNome()
    {
        Console.WriteLine($"\nMeu nome é {Nome}.");
    }
}

class Gato : Animal
{
    public override void ExibeNome()
    {
        Console.WriteLine($"\nEu sou um gato. Meu nome é : {Nome}.");
    }
}

class Cachorro : Animal
{
   
}