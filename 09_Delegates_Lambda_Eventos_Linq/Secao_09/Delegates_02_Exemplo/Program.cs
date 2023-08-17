using Delegates_02_Exemplo;

Console.WriteLine("Delegate - Exemplo prático\n");

var resultado = Calculadora.Somar(10, 40);
Console.WriteLine(resultado);

//2ª etapa - Definir o método de destino, primeira forma
DelegateCalculadora calc = new DelegateCalculadora(Calculadora.Somar);
var resultado1 = calc.Invoke(20, 30);
Console.WriteLine($"Soma = {resultado1}");

//2ª etapa - Definir o método de destino, segunda forma
DelegateCalculadora calc2 = Calculadora.Somar;
var resultado2 = calc2.Invoke(20, 30);
Console.WriteLine($"Soma = {resultado2}");

//2ª etapa - Definir o método de destino, terceira forma
DelegateCalculadora calc3 = (float x, float y) => Calculadora.Somar(x, y);
var resultado3 = calc3.Invoke(20, 30);
Console.WriteLine($"Soma = {resultado3}");


//Para os demais métodos
DelegateCalculadora calcMulti = Calculadora.Multiplicar;
var resultadocalcMulti = calcMulti.Invoke(20, 30);
Console.WriteLine($"Multiplicação = {resultadocalcMulti}");

DelegateCalculadora calcDivi = Calculadora.Dividir;
var resultadocalcDivi = calcDivi.Invoke(100, 2);
Console.WriteLine($"Dividir = {resultadocalcDivi}");


Console.ReadKey();

//1ª etapa - Declarar o delegate.
public delegate float DelegateCalculadora(float x, float y);

