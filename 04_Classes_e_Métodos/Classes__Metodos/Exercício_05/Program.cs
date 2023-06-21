Console.WriteLine("Exercícios Práticos #05\n");


Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110);
chevrolet.Acelerar(chevrolet.Marca);
Console.WriteLine($"{chevrolet.Modelo} {chevrolet.Montadora} {chevrolet.Marca}" + $" {chevrolet.Ano} {chevrolet.Potencia} CV");

Carro chevrolet2 = new("Sedan", "Chevrolet", "Onix", 2016, 110);

Console.WriteLine("\nUsando parâmetro out => Aumenta potencia e velocidade ");
double novaPotencia = chevrolet2.AumentarPotenciaVelocidade(chevrolet2.Potencia, out double velocidade);
Console.WriteLine("-Nova Potencia : " + novaPotencia);
Console.WriteLine("-Nova Velocidade Máxima : " + velocidade);

Carro ford = new("SUV", "Ford", "EcoSport", 2018, 120);
ford.Acelerar(ford.Marca);
Console.WriteLine($"{ford.Modelo} {ford.Montadora} {ford.Marca}" + $" {ford.Ano} {ford.Potencia} CV");

Carro ford2 = new("SUV", "Ford");

Console.WriteLine("\nUsando argumentos nomeados e parâmetros opcionais \n");
Console.WriteLine("Sem informar o parâmetro opcional Ano");
ford.ExibirInfo(Modelo: ford.Modelo, Montadora: ford.Montadora,
Marca: ford.Marca, Potencia: ford.Potencia);
Console.WriteLine("\nInformando o parâmetro opcional Ano");
ford.ExibirInfo(Modelo: ford.Modelo, Montadora: ford.Montadora,
Marca: ford.Marca, Potencia: ford.Potencia, Ano: ford.Ano);



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

    public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
    {
        potencia += 7;
        velocidade = potencia * 1.75;
        return potencia;
    }

    public void ExibirInfo(string? Modelo, string? Montadora, string? Marca, int Potencia, int Ano = 2024)
    {
        Console.WriteLine(Modelo);
        Console.WriteLine(Montadora);
        Console.WriteLine(Marca);
        Console.WriteLine(Potencia);
        Console.WriteLine(Ano);
    }


}