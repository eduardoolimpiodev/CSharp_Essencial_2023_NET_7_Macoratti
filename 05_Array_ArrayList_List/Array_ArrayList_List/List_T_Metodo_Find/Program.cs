/*
 List<T> possui 5 métodos Find:
    * Find() : Retorna o primeiro elemento que corresponde ao predicado fornecido.
    * FindLast() : Retorna o último elemento que corresponde ao predicado fornecido.
    * FindIndex() : Retorna o índice do primeiro elemento que corresponde ao predicado fornecido. Ele retorna -1 se não houver correspondência encontrada.
    * FindLastIndex() : Retorna o índice do último elemento que corresponde ao predicado fornecido. Ele retorna -1 se não houver correspondência encontrada.
    * FindAll() : Recupera todos os elementos que correspondem as condições definidas pelo predicado especificado.
    
    * Predicado é uma função/método de argumento único que retorna um valor booleano. 
 
 */

Console.WriteLine("List<T> - Método Find()\n");


List<string> frutas = new()
{
    "Uva", "Banana", "Maça", "Pera", "Abacate", "Laranja", "Morango"
};


//Usando o predicado como uma função.
Console.WriteLine("Usando o predicado como uma função.\n");
var fruta1 = frutas.Find(Procura);
Console.WriteLine(fruta1); //Banana -> Pois o fins busca o primeiro elemento que atende o predicado fornecido.

Console.WriteLine("");

//Usando a expressão Lambda.
Console.WriteLine("Usando a expressão Lambda:\n");
var fruta2 = frutas.Find(f => f.Contains("t")); //Abacate
Console.WriteLine(fruta2);


Console.ReadKey();

static bool Procura(string item)
{
    //return item.Contains("n"); // -> que contem a letra n -> Banana
    return item.StartsWith("L"); // -> Que inicia com a letra L -> Laranja
}

