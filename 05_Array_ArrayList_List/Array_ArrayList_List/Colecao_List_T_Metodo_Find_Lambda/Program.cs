﻿Console.WriteLine("Métodos Find com Expressão Lambda\n");


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

Console.WriteLine("");

//FindLast com Lambda Expression: Retorna a última ocorrência que atende o critério.
Console.WriteLine("FindLast com Lambda Expression");
var fruta3 = frutas.FindLast(f => f.Contains("n"));
Console.WriteLine($"\nFindLast : {fruta3}");


//FindIndex -> Retorna o índice da primeira ocorrência.
var fruta4 = frutas.FindIndex(f => f.Contains("n"));
Console.WriteLine($"\nFindIndex : indice = {fruta4} item = {frutas[fruta4]}");

//FindLastIndex -> Retorna o índice da última ocorrência.
var fruta5 = frutas.FindLastIndex(f => f.Contains("n"));
Console.WriteLine($"\nFindLastIndex : indice = {fruta5} item = {frutas[fruta5]}");


Console.WriteLine("Exibindo o resultado de FindAll:\n");
//Retorna todos os elementos que atendem o critério.
var frutas6 = frutas.FindAll(f => f.Contains("n"));
foreach(var fruta in frutas6)
{
    Console.Write($"\nFindAll : {fruta}");
}

Console.ReadKey();

static bool Procura(string item)
{
    //return item.Contains("n"); // -> que contem a letra n -> Banana
    return item.StartsWith("L"); // -> Que inicia com a letra L -> Laranja
}

