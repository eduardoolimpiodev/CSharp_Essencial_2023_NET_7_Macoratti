using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Inferência de Tipos (var)\n");

var idade = 25;
var nome = "Maria";
var salario = 2500.00m;

//ToString("c") para formatar para a moeda local.
Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString("c")} por mês.");

//Limitações VAR

var salaro = null; // Não posso atribuir null para VAR
var titulo; // Não posso inicializar uma VAR sem atribuir valor.
var salario, nome;  //Não posso declarar mais de uma variável na mesma linha sem incializa-las com um valor.

// não posso mudar o tipo de uma VAR após inicializar.
var num = 10;
num = num + 20;
num = "Teste";


var teste = new Teste();
teste.MeuMetodo();

class Teste
{
    public void MeuMetodo()
    {
        Console.WriteLine("Meu método");
    }
}

Console.ReadKey();
