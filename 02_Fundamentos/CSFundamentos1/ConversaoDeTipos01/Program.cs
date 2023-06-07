Console.WriteLine("Conversão de Tipos #01\n");
Console.WriteLine("Conversão Implícita\n");

int varInt = 100;
double varDouble = varInt;




Console.WriteLine(varDouble);

int numeroInt = 2145678;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;

Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);

Console.WriteLine("Conversão Explícita\n");

double varDouble2 = 12.456;
int varInt2 = (int)varDouble2;
Console.WriteLine(varInt2);

int num1 = 10;
int num2 = 4;
float resultado = (float) num1 / num2;
Console.WriteLine(resultado);

Console.ReadLine();

