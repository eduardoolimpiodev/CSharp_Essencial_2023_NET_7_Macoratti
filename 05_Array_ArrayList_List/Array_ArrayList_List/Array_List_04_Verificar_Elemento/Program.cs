using System.Collections;

Console.WriteLine("ArrayList - #04 - Verificar Elemento\n");


/* Métodos:
 *Contains(): Para determinar se um elemento especificado existe na ArrayList ou não. O método retorna um True se existir, caso contrário retorna False.
 *Sort(): Para ordenar uma ArrayList com elementos do mesmo tipo na order ascendente. Usa algorítimo QuickSort para classificar os elementos da ArrayList.
 *Clear(): Para remover todos os elementos de uma ArrayList sem alterar sua capacidade.
*/


var lista = new ArrayList()
{
    "Eduardo", 5, true, 4.5, null, DateTime.Now
};

var contem = lista.Contains("Eduardo");
Console.WriteLine(contem);

Console.WriteLine($"\nArrayList Original \n");

var lista2 = new ArrayList()
{
    "Maria", "Marcele", "Eduardo", "Roberto", "Paula", "Roberta"
};

foreach (var item in lista2)
{
    Console.WriteLine($"{item} ");
}

lista2.Sort();

Console.WriteLine($"\nArrayList Ordenado \n");
foreach (var item in lista2)
{
    Console.WriteLine($"{item} ");
}

//Limpar o Array
lista.Clear();
Console.WriteLine("\nNúmero de elementos no array depois do Clear = " + lista.Count);

Console.ReadKey();