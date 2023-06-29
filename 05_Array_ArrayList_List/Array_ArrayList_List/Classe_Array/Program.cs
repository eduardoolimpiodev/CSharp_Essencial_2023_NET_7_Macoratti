//Fornece recursos para trabalhar com Arrays
Console.WriteLine("Classe Array \n");

string[] nomes = { "Eduardo", "Marcele", "Maria", "Paula", "Roberta", "Roberto" };

Console.WriteLine("\n\nExibindo o array original...");
ExibeArray(nomes);

Console.WriteLine("\n\nInvertendo a oredem do array...");
Array.Reverse(nomes);
ExibeArray(nomes);

Console.WriteLine("\n\nOrdenando o array em ordem crescente...");
Array.Sort(nomes);
ExibeArray(nomes);

Console.WriteLine("\n\nLocalizando um item no array...");
Console.WriteLine("Informe o nome: ");
string nome = Console.ReadLine();

var indice = Array.BinarySearch(nomes, nome);

if(indice >= 0)
{
    Console.WriteLine($"\n{nome} foi encontrado com índice = {indice}");
}
else
{
    Console.WriteLine($"\n{nome} Não foi encontrado...");
}




Console.ReadKey();

static void ExibeArray(string[] nomes)
{
    foreach (string nome in nomes)
    {
        Console.WriteLine($"{nome} ");
    }
}