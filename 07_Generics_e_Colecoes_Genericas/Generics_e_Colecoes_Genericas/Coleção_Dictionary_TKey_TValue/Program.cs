/*
 A classe Dictionary representa uma coleção do tipo chave/valor e implementa a interface IDIctionary(e outras interfaces) que possui duas coleções no seu interior, uma para
 guardar a chave e outra para guardar o valor.
 Cada chave deve ser exclusiva na coleção.
 Requer uma implementação de igualdade para determinar se as chaves são iguais.
 Podemos especificar uma implementação da interface genérica IEqualityComparer<T> usando um construtor que aceita um parâmetro de comparação.
 Caso não especifiquemos uma implementação, o comparador de igualdade genérica padrão EqualityComparer<T>.Default será usado.
 Na definição da chave, não podemos utilizar valores repetidos ou valores Null, mas para os valores podemos.
 
 * Principais propriedades da coleção Dictionary:
  - Count: Obtém o número total de elementos no DIctionary<TKey, TValue>
  - IsReadOnly: Retorna um booleano indicando se o Dictionary<TKey,TValue> é somente leitura.
  - Item: Obtem ou define o elemento com a chave especificada no Dictionary<TKey,TValue>
  - Keys: Retorna a coleção de chaves do Dictionary<TKey,TValue>
  - Values: Retorna a coleção de valores no Dictionary<TKey,TValue>
  - Comparer: Obtém o IEqualityComparer<T> que é usado para determinar a igualdade de chaves para o dicionário.

 * Principais Métodos:
  - Add(TKey,TValue): Adiciona a chave e o valor ao Dictionary(TKey,TValue). Lança uma exceção ArgumentException se a chave já existir.
  - TryAdd(TKey,TValue): Tenta adicionar um elemento com chave e valor definidos e retorna um true ou false.
  - Clear(): Remove todas as chaves e valores do Dictionary<TKey,TValue>.
  - ConstainsKey(TKey): Determina se o Dictionary<TKeu,TValue> atual contém a chave especificada.
  - ContainsValue(TValue): Determina se o Dictionary<TKey,TValue> atual contém o valor especificado.
  - Remove(TKey): Remove o valor com a chave especificada do Dictionary<TKey,TValue>.
  - TryGetValue(TKey,TValue): Obtém o valor associoado à chave especificada. Se a chave não existir retorna o valor padrão para o tipo do parâmetro TValue.
*/

Console.WriteLine("Coleção Genérica - Dictionary<TKey, TValue>\n");



Dictionary<string, int> dict1 = new Dictionary<string, int>();

Dictionary<string, int> dict2 = new Dictionary<string, int>(5);

IDictionary<int, string> dict3 = new Dictionary<int, string>();
Dictionary<int, string> dict4 = new Dictionary<int, string>(5);

