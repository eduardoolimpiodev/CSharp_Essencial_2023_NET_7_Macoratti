Console.WriteLine("Classe Math \n");

Console.WriteLine("Informe o valor de x:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y:");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\n Raiz quadrada de x = {Math.Sqrt(x)}");
Console.WriteLine($"\n Potência de x elevado a y é: {Math.Pow(x, y)}");
Console.WriteLine($"\n Valor mínimo entre x e y é: {Math.Min(x, y)}");
Console.WriteLine($"\n Valor máximo entre x e y é: {Math.Max(x, y)}");
Console.WriteLine($"\n Coseno de x é: {Math.Cos(x)}");
Console.WriteLine($"\n Seno de x é: {Math.Sin(x)}");
Console.WriteLine($"\n Exponencial de x é: {Math.Exp(x)}");






//Console.WriteLine($"A Soma de X e Y é: {x + y}");
//Console.WriteLine($"A Subtração de X e Y é: {x - y}");
//Console.WriteLine($"A multiplicação de X e Y é: {x * y}");
//double divisao = (double) x / y;
//Console.WriteLine($"A divisão de X e Y é: {divisao}");
//Console.WriteLine($"O módulo de X e Y é: {x % y}");



Console.ReadKey();


