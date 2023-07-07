//Considerado o 3º pilar da POO. Depois de Encapsulamento e Herança.
//1º Polimorfismo em tempo de compilação (Overloading ou Sobrecarga)
//2º Polimorfismo em tempo de execução (Overriding ou Sobrescrita) - Late Binding/Ligação tardia

using POO_Polimorfismo;

Console.WriteLine("POO - Polimorfismo\n");

var figuras = new List<Figura>
{
    new Triangulo(),
    new Circulo()
};

foreach (var figura in figuras)
{
    figura.Desenhar();
}




Console.ReadKey();