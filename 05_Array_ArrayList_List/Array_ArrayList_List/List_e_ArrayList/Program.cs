//Usando o List<T> ganhamos segurança e performance, pois não há processo de boxing e unboxing e é fortemente tipado.

using System.Collections;

Console.WriteLine("List e ArrayList\n");

ArrayList lista = new ArrayList();
lista.Add(3);
lista.Add(4);

var elemento = lista[0];
int numero = (int)lista[1];
Console.WriteLine(numero);

List<int> lista1 = new List<int>();
lista1.Add(1);

var item = lista[0];


Console.ReadKey();
