Console.WriteLine("Exercícios Práticos #01\n");


Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110);
chevrolet.Acelerar(chevrolet.Marca);
Console.WriteLine($"{chevrolet.Modelo} {chevrolet.Montadora} {chevrolet.Marca}" + $" {chevrolet.Ano} {chevrolet.Potencia} CV");
Carro ford = new("SUV", "Ford", "EcoSport", 2018, 120);
ford.Acelerar(ford.Marca);
Console.WriteLine($"{ford.Modelo} {ford.Montadora} {ford.Marca}" + $" {ford.Ano} {ford.Potencia} CV");


Console.ReadKey();

public class Carro
{
    public string? Modelo { get; set; }
    public string? Montadora { get; set; }
    public string? Marca { get; set; }
    public int Ano { get; set; }
    public int Potencia { get; set; }

    public Carro(string? Modelo, string? Montadora, string? Marca, int Ano, int Potencia)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
    }


    public void Acelerar(string marca)
    {
        Console.WriteLine("\nAcelerando o meu " + marca);
    }


}
