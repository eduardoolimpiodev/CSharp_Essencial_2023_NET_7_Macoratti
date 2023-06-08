Console.WriteLine("Operador Uniário e Ternário\n");

int positivo = 1;
int resultado;

resultado = +positivo;
Console.WriteLine(positivo);

Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

Console.WriteLine("Informe um número: \n");
var n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O negativo de {n} é {-n}\n");

Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

Console.WriteLine("Operador Ternário");

Console.WriteLine("Informe a temperatura: \n");

var temperatura = Convert.ToDouble(Console.ReadLine());

var result = temperatura > 27 ? "Quente" : "Normal";
Console.WriteLine($"O tempo está: {result}");

Console.WriteLine("Operador Condicional Ternário");

Console.WriteLine("Informe o valor de X");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de Y");
int y = Convert.ToInt32(Console.ReadLine());

string resultados = x > y ? "x é maior que y" :
                                x < y ? "x é menor que y" :
                                x == y ? "x é igual a y" : "Sem resultado";

Console.WriteLine(resultados);

Console.ReadKey();
