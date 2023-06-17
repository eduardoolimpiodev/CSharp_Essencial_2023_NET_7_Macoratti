Console.WriteLine("O que é um objeto\n");

//Um objeto é uma instância de uma classe



Cachorro bilu = new Cachorro();
bilu.nome = "Bilu";
bilu.cor = "Marrom";
bilu.sexo = "macho";

Cachorro pipoca = new Cachorro();
pipoca.nome = "Pipoca";
pipoca.cor = "Branco com pintas";
pipoca.sexo = "macho";

Console.WriteLine($"{bilu.nome} {bilu.cor} {bilu.sexo}");
Console.WriteLine($"{pipoca.nome} {pipoca.cor} {pipoca.sexo}");


public class Cachorro
{
    public string? nome { get; set; }
    public string? cor { get; set; }
    public string? sexo { get; set; }

    //public void Comer();
    //public void Latir();
}
