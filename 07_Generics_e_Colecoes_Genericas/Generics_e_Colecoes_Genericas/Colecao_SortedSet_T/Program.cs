/*
  - SortedSet<T> : É uma coleção genérica ordenada que implementa a interface ISet<T> e representa um conjunto de items exclusivos
    (não permite a inclusão de elementos duplicados).
  * Possui uma propriedade SortedSet<T>.Comparer que garante que todos os elementos no objeto estejam na ordem correta.
  * Esta propriedade implementa a interface IComparer<T>, que compara elementos e garante que os elementos da coleção estejam
    na ordem correta.
*/

Console.WriteLine("Coleção SortedSet<T>\n");

var numeros = new SortedSet<int> { 1, 5, 3, 4, 2 };
ExibirColecao(numeros);

var frutas = new SortedSet<string> { "uva", "banana", "pera", "kiwi" };
ExibirColecao(frutas);

SortedSet<int> pares = new SortedSet<int>();
for (int i = 6; i > 0; i--)
{
    pares.Add(i * 2);
}
ExibirColecao(pares);
Console.WriteLine();
Console.WriteLine("Com Lista");
var numeros2 = new List<int>() { 1, 7, 3, 6, 5, 4, 2};
SortedSet<int> conjunto = new SortedSet<int>(numeros);
ExibirColecao(conjunto);

var frutas2 = new List<string> { "uva", "banana", "pera", "manga" };
SortedSet<string> minhasFrutas = new SortedSet<string>(frutas);
ExibirColecao(minhasFrutas);

static void ExibirColecao<T>(IEnumerable<T> numeros)
{
    Console.WriteLine();
    foreach (var numero in numeros)
    {
        Console.WriteLine(numero);
    }
}

