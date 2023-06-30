
using System.Collections;

Console.WriteLine("Array List #02 - Adicionar Elementos \n");

/* Métodos:
 * Add : Permite incluir um único elemento ao final do ArrayList.
 * Insert (int index, Object value) : Permite incluir um elemento em uma posição qualquer usando um índice específico.
 
   Incluir uma coleção de elementos:
 * AddRange(ICollection) : Adiciona a coleção de elementos ao final da ArrayList.
 * InsertRange (int index, ICollection) : Adiciona a coleção de elementos na ArrayList na posição do íncide especificado. 
 
 */

var lista = new ArrayList()
    {
        "Eduardo", 37, true, " ", null
    };

lista.Add(3.5);

//INSERE NO ÍNCIDE 1.
lista.Insert(1, "Ramos");

//INSERIR COLEÇÃO NA ARRAYLIST COM ADDRANGE OU INSERTRANGE

int[] array1 = { 1, 2, 3 };
lista.AddRange(array1);

lista.InsertRange(2, array1);


Console.ReadKey();
