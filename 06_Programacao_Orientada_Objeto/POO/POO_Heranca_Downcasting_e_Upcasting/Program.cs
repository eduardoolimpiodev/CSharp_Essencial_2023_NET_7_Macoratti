//Upcasting: Converte um objeto de um tipo especializado(classe derivada ou filha) para um tipo mais geral(classe base ou pai).
//Downcasting: Converte um objeto de um tipo geral(classe base) para um tipo mais especializado(classe filha). 
using POO_Heranca_Downcasting_e_Upcasting;

Console.WriteLine("Herança - Downcasting e Upcasting\n");

//Upcasting

Forma circulo = new Circulo(10, 20);

circulo.Desenhar();

Circulo circulo2 = new Circulo(10, 20);
Forma forma = circulo;
forma.Desenhar();

Console.WriteLine(forma == circulo);


//Downcasting

Circulo c = (Circulo)forma;

c.PintarCirculo();
c.Desenhar();

Console.WriteLine(c == forma);
Console.WriteLine(c == circulo);


Console.ReadKey();
