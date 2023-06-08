Console.WriteLine("Operador Uniário e Ternário\n");

int positivo = 1;
int resultado;

resultado = +positivo;
Console.WriteLine(positivo);

Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

Console.WriteLine("Informe um número: \n");
var n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O negativo de {n} é {-n}");

Console.WriteLine("Operador Ternário");

Console.WriteLine("Informe a temperatura: \n");

var temperatura = Convert.ToDouble(Console.ReadLine());

var result = temperatura > 27 ? "Quente" : "Normal";
Console.WriteLine($"O tempo está: {result}");


Console.ReadKey();
