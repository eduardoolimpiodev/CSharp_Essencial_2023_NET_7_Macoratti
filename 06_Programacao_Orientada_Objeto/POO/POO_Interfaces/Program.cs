/*
Interfaces: Uma interface é um tipo de classe que pode conter assinatura de métodos, eventos, propriedades e indexadores, e também
pode conter métodos públicos e estáticos que contém uma implementação.
Por padrão, os membros da interface são públicos, e podemos especificar explicitamente modificadores de acessibilidade,
como public, protected, internal, private, protected internal ou private protected.
Uma interface não podeconter campos de instância, construtores de instância ou finalizadores.
Para implementar um membro de interface, o membro corresponde da classe de implementação deve ser público, não estático e ter o mesmo
nome e assinatura do membro de interface.
*/

Console.WriteLine("POO - Interfaces\n");

IControle d = new Demo();
d.Nome = "Teste";
d.Desenhar();
d.Exibir();

Console.ReadKey();


interface IControle
{
    string? Nome { get; set; }
    void Desenhar();
    public void Exibir()
    {
        Console.WriteLine("Teste...");
    }
}

interface IGrafico
{
    void Pintar();
}

public class Demo : IControle, IGrafico
{
    public string? Nome { get; set; }

    public void Desenhar()
    {
        Console.WriteLine("Desenhando...");
    }

    public void Pintar()
    {
        Console.WriteLine("Pintando...");
    }
}