Console.WriteLine("Operadores de atribuição\n");

//Usando operadores de atribuição com tipos numéricos

float x = 10;
x = 20;

Console.WriteLine($"O Valor inicial de x = {x}");
Console.WriteLine($"x += 5 => {x+=5}");
Console.WriteLine($"x -= 3 => {x-=3}");
Console.WriteLine($"x *= 4 => {x*=4}");
Console.WriteLine($"x /= 5 => {x/=5}");
Console.WriteLine($"x %= 5 => {x%=5}");

//Usando operadores de atribuição com strings

string y = "123";
Console.WriteLine($"Valor inicial de y = {y}");
Console.WriteLine($"y += \"456\" => {y +=456}");



Console.ReadLine();
