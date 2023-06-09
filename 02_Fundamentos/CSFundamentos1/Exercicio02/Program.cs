Console.WriteLine("Exercício 02\n");

var nome = "Paulo";
var idade = 17;
var nota = 7.5;
Console.WriteLine($"O aluno {nome} tem {idade} anos e tirou a nota {nota}.\n");

Console.WriteLine($" Nome: {nome}\n Idade: {idade}\n Nota: {nota}");


Console.WriteLine("*******************************************************");

//Console.WriteLine("Digite 3 letras");
//var letra1 = Console.Read();
//var letra2= Console.Read();
//var letra3 = Console.Read();
//Console.WriteLine($"{letra3} {letra2} {letra1}");


Console.WriteLine("*******************************************************");

Console.WriteLine("Informe o seu nome\n");
string nome1 = Console.ReadLine();
Console.Write("\nInforme a senha \t");
int senha = Convert.ToInt32(Console.ReadLine());
var resultado = (nome1 == "admin" || nome1 == "maria") && senha == 123 ? "Login Legal" : "Falhou";
Console.WriteLine(resultado);






Console.ReadKey();
