//É uma coleção genérica que armazena dados no formato chave/valor de forma ordenada onde a ordenação é feita pela chave.
//As chaves da coleção SortedDictionary devem ser exclusivas e não nulas e manter a ordem crescente sendo usadas para realizar
//pesquisas e remover elementos da coleção.
/*
 Propriedades SortedDictionary:
    Count(): Obtém o número de pares chave/valor do SortedDictionary<TKey, TValue>
    Item[]: Obtém ou define o elemento com a chave especificada no SortedDictionary<TKey,TValue>
    Keys: Retorna a coleção de chaves do SortedDictionary<TKey,TValue>
    Values: Retorna a coleção de valores no SortedDictionary<TKey,TValue>
    Comparer: Obtém o IComparer<T> que é usado para ordenar os elementos.

    Métodos SortedDictionary:
  - Add(TKey,TValue): Adiciona a chave e o valor ao Dictionary(TKey,TValue). Lança uma exceção ArgumentException se a chave já existir.
  - Clear(): Remove todas as chaves e valores do Dictionary<TKey,TValue>.
  - ConstainsKey(TKey): Determina se o Dictionary<TKeu,TValue> atual contém a chave especificada.
  - ContainsValue(TValue): Determina se o Dictionary<TKey,TValue> atual contém o valor especificado.
  - Remove(TKey): Remove o valor com a chave especificada do Dictionary<TKey,TValue>.
  - TryGetValue(TKey,TValue): Obtém o valor associoado à chave especificada. Se a chave não existir retorna o valor padrão para o tipo do parâmetro TValue.
 */

Console.WriteLine("Sorted Dictionary<TKey,TValue\n");

SortedDictionary<int, string> sortdict1 = new SortedDictionary<int, string>();
// ou
var sortdict2 = new SortedDictionary<int, string>();

//incluir elementos
var brics = new SortedDictionary<int, string>();
brics.Add(30, "Brasil");
brics.Add(20, "China");
brics.Add(100,"URSS");
Console.WriteLine(brics);

var brics2 = new SortedDictionary<int, string>()
{
    {30, "Brasil" },
    {20, "China" },
    {10, "URSS" },
};

Console.ReadKey();



