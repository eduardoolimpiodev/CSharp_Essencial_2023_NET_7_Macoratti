﻿/*
 Principais métodos utilizados em uma List<T>:
    - Inclusão de Items:
    * Add(T) : 
    
    * Insert(int index, T value) : 
    
    - Inclusão de coleções:
    * AddRange(ICollection) : 
    
    * InsertRange(int index, ICollection) :  
 
    - Acessar os elementos usando o índice:
    * lista[indice] : 
    
    - Iteração na lista : laço for (Count) e laço foreach : 

    - Verificar se um elemento esta na lista: 
    * Contains(T) : 
    
    - Remoção de itens: 
    * Remove(T value) :
        
    RemoveAt(int index) :

    RemoveRange(int index, int count) :
    
    - Ordenação da lista e remõção de todos os elementos da lista :
    *Sort() : 
    *Clear() :
    
 * */

Console.WriteLine("Coleção List<T> #02 \n");


//Inclusão de elementos: com Add e Insert.

var lista = new List<string>()
{
    "Eduardo", "Ramos", "Junqueira"
};

lista.Add("Olimpio");
lista.Insert(3, "Olimpio");

// Inclusão de coleção de elementos.

string[] array1 =
{
    "Marcele", "Meireles"
};

lista.AddRange(array1);
lista.InsertRange(1, array1);

Console.WriteLine(lista.Count + " itens \n");


//Remover Elementos:

var listaInt = new List<int>()
{
    9, 5, 4, 1, 7, 8, 3, 6, 0
};

listaInt.Remove(7);

//Remove por Índice:
listaInt.RemoveAt(4);

//A partir do índice 0 irá remover 2 elementos.
listaInt.RemoveRange(0, 2);


//Acessar elementos de uma List<T> utilizando o índice.

Console.WriteLine("Acessar elementos de uma List<T> utilizando o índice.");

var listaString = new List<string>()
{
    "Maria", "Marcele", "Eduardo"
};

var primeiro = listaString[0];
var segundo = listaString[1];
var terceiro = listaString[2];

Console.WriteLine(primeiro);
Console.WriteLine(segundo);
Console.WriteLine(terceiro);

Console.WriteLine("\n");

//Alterar o valor da lista:
Console.WriteLine("Alterar o valor da lista:\n");

listaString[0] = "Maria de Fátima";
listaString[1] = "Marcele Meireles";
listaString[2] = "Eduardo Olimpio";

Console.WriteLine(listaString[0]);
Console.WriteLine(listaString[1]);
Console.WriteLine(listaString[2]);

Console.WriteLine("");

//Iteração usando o Laço For:
//Count é igual ao número total de elementos da List<T>.
Console.WriteLine("Iteração usando o laço for\n");

var listaFor = new List<string>()
{
    "Maria", "Eduardo", "Marcele", "Paula", "Roberta", "Roberto"
};

for (int i = 0; i < listaFor.Count; i++)
{
    Console.WriteLine($"{listaFor[i]}");
}

Console.WriteLine("");


//Iteração usando o Laço forEach:
//Não precisamos usar índices.
Console.WriteLine("Iteração usando o laço forEach\n");

var listaForEach = new List<string>()
{
    "Maria", "Eduardo", "Marcele", "Paula", "Roberta", "Roberto"
};

foreach (var item in listaForEach)
{
    Console.WriteLine(item);
}

Console.WriteLine("");
Console.WriteLine("Verificando elementos na coleção:");

//Verificar se um elemento está na coleção:
//Utilizamos o método Contains() para determinar se um elemento especificado existe na List<T> ou não. O método retorna True ou False.

var listaVerificada = new List<string>()
{
    "Eduardo", "Ramos", "Junqueira", "Olimpio"
};

var resposta01 = listaVerificada.Contains("Edu");
var resposta02 = listaVerificada.Contains("Junqueira");
var resposta03 = listaVerificada.Contains("Manoel");

Console.WriteLine(resposta01);
Console.WriteLine(resposta02);
Console.WriteLine(resposta03);
Console.WriteLine(listaVerificada.Contains("Eduardo"));


Console.WriteLine("");
Console.WriteLine("Ordenação e Remoção de todos os elementos da coleção:");

//Ordenação e Remoção de todos os elementos da coleção:
//Utilizamos o método Sort() para ordenar uma List<T> com elementos do mesmo tipo na ordem ascendente.
//Usa algorítimo QuickSort para classificar os elementos da List<T>.

var listaOrdenada = new List<string>()
{
    "Eduardo", "Ramos", "Junqueira", "Olimpio"
};

Console.WriteLine("Lista Original");
ExibirLista(listaOrdenada);

Console.WriteLine("");

Console.WriteLine("Lista Ordenada");
listaOrdenada.Sort();
ExibirLista(listaOrdenada);



//Remover todos so elementos de uma List<T> sem alterar sua capacidade usamos o método Clear().

Console.WriteLine("");
Console.WriteLine("Remover todos so elementos com Clear().");

listaOrdenada.Clear();
ExibirLista(listaOrdenada);
Console.WriteLine(listaOrdenada.Count + " items. ");

Console.ReadKey();


//Ordenação com Sort():

static void ExibirLista(List<string> listaOrdenada)
{
    foreach (var item in listaOrdenada)
    {
        Console.WriteLine(item);
    }
}