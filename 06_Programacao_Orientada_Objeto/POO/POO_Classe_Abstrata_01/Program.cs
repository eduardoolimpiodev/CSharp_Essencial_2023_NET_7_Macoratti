//O modificador abstratic indica que o recurso que está sendo modificado tem uma implementação ausente ou incompleta.

using POO_Classe_Abstrata_01;

Console.WriteLine("Classe Abstrata\n");

Quadrado q = new Quadrado();
Console.WriteLine(q.Descricao());

Console.WriteLine("\nInforme a cor da figura");
q.Cor =Console.ReadLine();

Console.WriteLine("\nInforme o valor do lado do quadrado");
q.Lado = Convert.ToInt32(Console.ReadLine());

q.CalcularArea();
q.CalcularPerimetro();

Console.WriteLine($"\nÁrea do quadrado : {q.Area} m2");
Console.WriteLine($"\nPerímetro do quadrado : {q.Perimetro} m");

Console.WriteLine($"\nO quadrado tem a cor : {q.Cor}");



Console.ReadKey();

