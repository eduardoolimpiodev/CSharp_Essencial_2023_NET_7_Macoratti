/*
 - HashSet<T> e SortedSet<T>
    * Uma coleção que contém apenas items distintos é conhecida pelo conjunto de termos ou Set.
    * São dois conjuntos ou sets definidos como coleções genéricas usadas para armazenar e manipular conjuntos de dados não dupli
      cados e estão presentes no namespace System.Collection.Generics.
    * Em termos de desempenho, HashSet<T> geralmente é mais rápido que SortedSet<T> para operações como adicionar e remover elementos,
      mas SortedSet<T> é mais rápido para operações que dependem da ordem dos elementos, como localizar o primeiro ou o último elemento.
 - HashSet<T> é uma coleção genérica não ordenada que implementa a interface ISet<T> e representa um conjunto de itens exclusivos
   (não permite a inclusão de elementos duplicados).
   Usa uma função Hash para determinar a posição de um item na coleção, o que permite o acesso rápido de elementos.
   A interface ISet<T> oferece métodos para criar uma união de múltiplos conjuntos, para criar uma interseção de conjuntos, ou para
   fornecer informações se um conjunto for um superconjunto ou subconjunto de outro.
*/
Console.WriteLine("Coleção Set - HashSet<T> e SortedSet<T> \n");

//Criação da coleção HashSet com itens
var numeros = new HashSet<int> { 1, 2, 3, 4, 5};

var frutas = new HashSet<string> { "uva", "banana", "pera"};

HashSet<int> pares = new HashSet<int>();

for (int i = 0; i < 6; i++)
{
    pares.Add(i * 2);
}

//construtor usando IEnumerable
var lista1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
var conjunto = new HashSet<int>(lista1);

var lista2 = new List<string> { "uva", "banana", "pera" };
HashSet<string> minhasFrutas = new HashSet<string>(lista2);

var impares = new int[] { 1, 3, 5, 7, 9, 11, 13 };
HashSet<int> meuHashset = new HashSet<int>(impares);




Console.ReadKey();
