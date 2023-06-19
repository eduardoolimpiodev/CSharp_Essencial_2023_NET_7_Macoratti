Console.WriteLine("Exercícios Práticos #03\n");


Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110);
chevrolet.Acelerar(chevrolet.Marca);
Console.WriteLine($"{chevrolet.Modelo} {chevrolet.Montadora} {chevrolet.Marca}" + $" {chevrolet.Ano} {chevrolet.Potencia} CV");

Console.WriteLine("Aumentando a Potencia (por valor : + 3CV) : ");
var novaPotenciaChevrolet = chevrolet.AumentarPotencia(chevrolet.Potencia);

Console.Write("-> " + novaPotenciaChevrolet);
Console.WriteLine("\nO valor do campo Potencia não foi alterado : " + chevrolet.Potencia);


Carro ford = new("SUV", "Ford", "EcoSport", 2018, 120);
ford.Acelerar(ford.Marca);
Console.WriteLine($"{ford.Modelo} {ford.Montadora} {ford.Marca}" + $" {ford.Ano} {ford.Potencia} CV");

Carro ford2 = new("SUV", "Ford");


Carro ford3 = new("SUV", "Ford", "EcoSport", 2018, 120);

Console.Write("\nAumentando a Potencia (por referência : +5CV) : ");
var novaPotenciaFord = ford3.AumentarPotencia(ref ford3.Potencia);
Console.Write("-> " + novaPotenciaFord);
Console.WriteLine("\nO valor do campo Potencia foi alterado : " + ford3.Potencia);



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

    public Carro(string? modelo, string? montadora)
    {
        Modelo = modelo;
        Montadora = montadora;
    }

    public void Acelerar(string marca)
    {
        Console.WriteLine("\nAcelerando o meu " + marca);
    }

    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }

    public int AumentarPotencia(int potencia)
    {
        potencia += 3;
        return potencia;
    }

    public int AumentarPotencia(ref int potencia)
    {
        potencia += 5;
        return potencia;
    }


}