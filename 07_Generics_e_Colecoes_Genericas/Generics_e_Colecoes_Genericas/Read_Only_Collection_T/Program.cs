using System.Collections.ObjectModel;

Console.WriteLine("ReadOnly Collection\n");

/*
    * São estruturas de dados que permitem que os dados sejam acesados, mas não modificados.
    
    * ReadOnlyCollection<T>:
     - Fornece a classe base para uma coleção somente leitura genérica.
     - É criada a partir de uma coleção mutável (Array ,List).
    
    * ReadOnlyDisctionary<TKey, TValue>:
     - Representa uma coleção somente leitura genérica de pares chave/valor.
     - Ela é criada a partir de um dicionário mutável.

    * Uma outra forma de criar é usando o método:
    List<T>.AsReadOnly() - Retorna um invólucro ReadOnlyCollection<T> somente leitura para a coleção atual.

    * Propriedades da coleção ReadOnlyCollection<T>:
    - Count : Obtém o número de elementos na instância da coleção somente leitura.
    - Item[] : Obtém um elemento no índice especificado.
    - Items - Retorna a IList<T> que a coleção envolve(protected).
    
    * Métodos da coleção ReadOnlyCollection<T>:
    - Contains(T item) - Determina se um elementos esta na coleção.
    - CopyTo(T[] array, int arrayIndex) - Copia os elementos da coleção para um Array unidimensional compatível, começando no índice especificado do array de destino.
    - GetEnumerator() - Retorna um enumerador que itera pela coleção.
    - IndeOf(T item) - Pesquisa o objeto espeficificado e retorna o índice baseado em zero da primeira ocorrência em toda a coleção. Este método executa uma pesquisa linear,
      portanto esse método é uma operação O(n)). Determina a igualdade usando o comparador padrão EqualityComparer<T>.Default.

 */


var planetas = new List<string>() 
{ 
    "Mercúrio", "Vênus", "Terra", "Marte"
};
var listaPLanetas = new ReadOnlyCollection<string>(planetas);
Console.WriteLine(listaPLanetas);


var planetas2 = new List<string>()
{ 
    "Saturno", "Urano", "Netuno", "Plutão"
};
var novaLista = planetas2.AsReadOnly();

Console.WriteLine("\nPlanetas não gasosso no sistema solar:");

foreach (var planet in novaLista)
{
    Console.WriteLine(planet);
}


Console.WriteLine($"\n\nPlanetas na coleção: {novaLista.Count}");

Console.WriteLine("\nJúpter esta na coleção? ");
Console.WriteLine(novaLista.Contains("Urano") ? "Sim" : "Não");

Console.WriteLine($"\nPlaneta de índice 3: {novaLista[3]}");

Console.WriteLine($"\nÍndice do planeta Urano: {novaLista.IndexOf("Urano")}");

Console.WriteLine("\n\nCopiando os elementos da cole~ção para um Array unidimensional");
string[] planetasArray = new string[novaLista.Count + 2];
novaLista.CopyTo(planetasArray, 1);

Console.WriteLine($"\nO Array copiado possui {planetasArray.Length} elementos");
foreach (var planet in planetasArray)
{
    Console.WriteLine($"\"{planet}\"");
}

Console.ReadKey();
