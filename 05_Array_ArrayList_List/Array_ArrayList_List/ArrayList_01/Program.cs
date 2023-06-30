//Array List - Coleção não genérica cujo o tamanho pode ser alterado dinamicamente e armazena elementos de vários dados.

using System.Collections;

Console.WriteLine("Array List #01\n");

ArrayList lista = new();
lista.Add("Eduardo");
lista.Add("Ramos");
lista.Add("Junqueira");
lista.Add("Olimpio");
lista.Add(37);
lista.Add("");
lista.Add(true);
lista.Add(null);


//Inicializadores de objeto -> fazer a declaração, criar a instância e já inicializar sem a necessidade de criar um construtor.

var lista2 = new ArrayList()
{
    "Eduardo", 37, true, " ", null
};


Console.ReadKey();