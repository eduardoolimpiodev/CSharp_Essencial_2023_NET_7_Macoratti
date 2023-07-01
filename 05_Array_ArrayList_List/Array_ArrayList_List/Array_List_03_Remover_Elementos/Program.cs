using System.Collections;

Console.WriteLine("ArrayList #03 - Removendo Elementos\n");


/* Métodos:
 * Remove(Object value) - Remove a primeira ocorrência de um objeto específico.
 * RemoveAt(int index) - Remove o elemento no índice especificado.
 * RemoveRange(int index, int count) - Remove um número definido de elementos a partir de um índice especificado.
 */


var lista = new ArrayList()
{
    "Ana", 5, true, " ", null, 1.1, "Zé", 3, 9, 0
};

lista.Remove(null);

lista.RemoveAt(4);

lista.RemoveRange(0, 2);

 Console.ReadKey();