/*
    - Stack<T> é uma coleção genérica de tamanho variável que funciona com base no princípio LIFO (Last In First Out, ou
    Último a entrar - Primeiro a sair) e está presente no namespace System.Collections.Generic.
    Podem ter elementos duplicados e aceita Null como valores.
    É útil quando precisamos de armazenamento temporário para obter informações.
    Elementos podem ser adicionados com o método Push().
    Elementos podem ser recuperaros com o método Pop() e Peek().

    Construtores: 
    Stack<T>(): É usado para inicializar uma nova instância da classe Stack que está vazia e tem a capacidade inicial padrão.
    
    Stack<T>(IEnumerable<T>): É usado para inicializar uma nova instância da classe Stack que contém elementos copiados da coleção
    especificada e tem capacidade suficiente para acomodar o número de elementos copiados.

    Stack<T>(int capacity): É usado para inicializar uma nova instância da classe Stack que está vazia e tem a capacidade inicial
    especificada ou a capacidade inicial padrão, o que for maior.

    Métodos Stack<T>:
    * Propriedade - Count: Retorna o total de elementos na pilha.
    * Push(): Inclui um elemento no topo da pilha.
    * Pop(): Remove e retorna um elemento do topo da pilha.
    * Peek(): Retorna o elemento do topo da pilha sem removê-lo.
    * Contains(): Verifica se existe um elemento na pilha (true/false).
    * Clear(): Remove todos os elementos da pilha.
    * ToArray(): Copia a pilha em um novo array unidimensional.
*/

Console.WriteLine("Coleção Stack<T>\n");

Stack<string> diasSemana = new Stack<string>();
diasSemana.Push("Segunda");
diasSemana.Push("Terça");
diasSemana.Push("Quarta");

int[] array1 = new int[] { 2, 4, 6, 8 };
Stack<int> pares = new Stack<int>(array1);

var lista = new List<string>() { "uva", "pera" };
var frutas = new Stack<string>(lista);

var impares = new Stack<int>(3);
impares.Push(1);
impares.Push(2);
impares.Push(3);

Stack<int> numeros = new Stack<int>();
numeros.Push(10);
numeros.Push(20);
numeros.Push(30);
numeros.Push(10);

Console.WriteLine($"A pilha original contém {numeros.Count} itens");

ExibirPilha(numeros);

//retorna sem remover
Console.WriteLine($"\nItem obtido da pilha (Peek) : {numeros.Peek()}");

//remove e retorna:
Console.WriteLine($"\nItem Removido da pilha (Pop) : {numeros.Pop()}");

Console.WriteLine($"\n A pilha agora contém {numeros.Count} itens");

if(numeros.Contains(20))
{
    Console.WriteLine("\nItem 20 esta na pilha");
}
else
{
    Console.WriteLine("\nItem 20 não está na pilha.");
}

//Copiar a pilha usando ToArray
Console.WriteLine("\nCopia a pilha usando ToArray");
var copia = new Stack<int>(numeros.ToArray());
ExibirPilha(copia);

//Remover todos os items da pilha
Console.WriteLine("\nRemovendo todos os itens da pilha\n");
numeros.Clear();
Console.WriteLine($"{numeros.Count} items na pilha");

ExibirPilha(numeros);

Console.ReadKey();

//foreach (var item in pilha)
//{
//    Console.WriteLine(item);
//}

static void ExibirPilha<T>(IEnumerable<T> numeros)
{
    Console.WriteLine();
    foreach (var item in numeros)
    {
        Console.WriteLine(item);
    }
}