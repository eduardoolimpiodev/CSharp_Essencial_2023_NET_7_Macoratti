Console.WriteLine("SortedDictionary<TKey,TValue>\n");

var brics = new SortedDictionary<int, string>()
{
    { 20, "Brasil"},
    { 10, "China"},
    { 40, "India"},
    { 30, "URSS"},
};

//Incluindo um novo elemento
Console.WriteLine("\nIncluindo o elemento de chave=70 e valor=África do Sul");
if (brics.ContainsKey(70))
    Console.WriteLine("Chave já existe");
else
    brics.Add(70, "África do Sul");

//Quantos elementos temos na coleção utilizando o Método Count:

Console.WriteLine($"\nNúmero de pares de chaves(elementos) no dicionário: {brics.Count}");

Console.WriteLine("\nAcessando um elemento pela chave -> bric[20]");
var valor = brics[20];
Console.WriteLine($"Chave 20 -> {brics[20]}");

//Atualizar um elemento
Console.WriteLine("\nAlterando o valor da chave 20 para Argentina");
brics[20] = "Argentina";
Console.WriteLine($"Chave 20 -> {brics[20]}");

//Remover um elemento
Console.WriteLine("\nRemovendo a chave 10 : brics.Remove(10) -> China");
brics.Remove(10);

//Verificando se uma chave existe
Console.WriteLine("\nVerificando se uma chave existe com ContainsKey");
Console.WriteLine($"Existe a chave: 30 ? -> {brics.ContainsKey(30)}");

//Verificando se um valor existe no ContainsValue

Console.WriteLine("\nVerificando se um valor existe com ContainsValue");
Console.WriteLine($"Existe o valor : 'URSS' ? -> {brics.ContainsValue("URSS")}");
Console.WriteLine($"Existe o valor : 'Chile' ? -> {brics.ContainsValue("Chile")}");

//Obtendo um valor
Console.WriteLine("\nObtendo o valor da chave 30 usando TryGetValue");
if(brics.TryGetValue(30, out string? meuValor))
{
    Console.WriteLine($"Valor da chave 30: {meuValor}");
}

//Percorrendo coleção com FOrEach
Console.WriteLine("\nPercorrendo um SortedDictionary com foreach\n");

foreach(var pais in brics)
{
    Console.WriteLine($"Chave/Valor = {pais.Key} {pais.Value}");
}



Console.ReadKey();
