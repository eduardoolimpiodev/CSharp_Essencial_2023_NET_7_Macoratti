//O campo Y Pertence a classe e não ao objeto, pois é um campo estático.

Console.WriteLine("Campos estáticos\n");

A a1 = new A();
a1.x = 10;

A a2 = new A();
a2.x = 20;

A.y = 30;

Console.WriteLine($" a1.X = {a1.x} a2.x = {a2.x} a.y = {A.y} ");

Console.ReadKey();

public class A
{
    public int x;
    public static int y;
}