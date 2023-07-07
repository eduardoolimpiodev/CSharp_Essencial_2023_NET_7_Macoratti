//Considerado o 3º pilar da POO. Depois de Encapsulamento e Herança.
//1º Polimorfismo em tempo de compilação (Overloading ou Sobrecarga)
//2º Polimorfismo em tempo de execução (Overriding ou Sobrescrita) - Late Binding/Ligação tardia

Calcular calc = new Calcular();
Console.WriteLine(calc.Somar(30,40));
Console.WriteLine(calc.Somar(30,40,50));


Console.ReadKey();



class Calcular
{
    public int Somar(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Somar(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }
}