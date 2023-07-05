//Usada para gerar números aleatórios com base no valor de uma semente ( seed );

Console.WriteLine("Classe Random\n");

Random random = new Random();

Console.WriteLine(random.Next());
Console.WriteLine(random.Next(20));
Console.WriteLine(random.Next(0,20));
Console.WriteLine(random.NextDouble());

byte[] randBytes = new byte[10];
Random random2 = new Random();
random2.NextBytes(randBytes);


for (int i = 0; i < 6; i++)
{
    Console.WriteLine(randBytes[i]);
}



Console.ReadKey();
