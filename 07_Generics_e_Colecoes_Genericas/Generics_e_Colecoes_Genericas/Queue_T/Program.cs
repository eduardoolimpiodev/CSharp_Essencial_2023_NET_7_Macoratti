Console.WriteLine("Queue<T>\n");

/*
    É uma coleção genérica de tamanho variável que funciona com base no princípio FIFO ( First In First Out, ou Primeiro a entrar - Primeiro a sair ).
    Esta coleção contém os elementos na ordem em que foram adicionados e serão removidos nesta ordem. Um item incluído primeiro será removido primeiro.
    Permite valores duplicados e nulos na coleção.

    Características da Queue<T>:
    * Atua no estilo FIFO.
    * Uma Queue<T> pode conter elementos do tipo T especificado.
    * Fornece verificação de tipo em tempo de compilação e não executa boxing-unboxing.
    * Os elementos podem ser adicionados usando o método Enqueue().
    * Os elementos podem ser recuperados usando os métodos Dequeue() e Peek().
    * Não é possível usar a sintaxe do inicializador de coleção.
    * Não oeferece suporte a um indexador.
    
    Construtores usados para criar uma Coleção Queue<T>:
    * Queue<T>() - Inicialza uma nova instância da classe Queue<T> que está vazia e tem a capacidade inicial padrão.
    
    * Queue<T>(IEnumerable<T>) - Inicializa uma nova instância da classe Queue<T>, que contém os elementos copiados da coleção especificada e tem
      capacidade sufucuente para acomodar o número de elementos copiados.

    * Queue<T>(int32) - Inicializa uma nova instância da classe Queue<T> que está vazua e tem a capacidade inicial especificada.
    
    Queue<T> - Propriedades e Métodos:
    - Propriedades:
    * Count - Retorna o total de itens na fila.
    
    - Métodos:
    * Enqueue(T) - Inclui um item no final da fila.
    * Dequeue - Retorna um item do início da file e o remove da fila.
    * Peek() - Retorna o item do início da fila sem removê-lo.
    * Contains() - Verifica se um item existe na fila. (true/false)
    * Clear() - Remove todos os elementos da fila.
    
    
*/
//Construtor #01
Queue<string> diasSemana = new Queue<string>();
diasSemana.Enqueue("Segunda");
diasSemana.Enqueue("Terça");
diasSemana.Enqueue("Quarta");

foreach (var item in diasSemana)
{
    Console.WriteLine(item);
}

Console.WriteLine();

//Construtor #02
int[] awway1 = new int[] { 2, 4, 6, 8 };
Queue<int> pares = new Queue<int>(awway1);

foreach (var item in pares)
{
    Console.WriteLine(item);
}

Console.WriteLine();

var lista = new List<string>() { "uva", "pera" };
var frutas = new Queue<string>(lista);

foreach (var item in frutas)
{
    Console.WriteLine(item);
}

Console.WriteLine();

//Construtor #03
var impares = new Queue<int>(3);
impares.Enqueue(1);
impares.Enqueue(2);
impares.Enqueue(3);

foreach (var item in impares)
{
    Console.WriteLine(item);
}

Console.WriteLine();

string[] cursos = { "C#", "Phyton", "Java", "SQL", "ASP.NET" };
Queue<string> fila1 = new Queue<string>(cursos);
Console.WriteLine("Nº. de Elementos na fila 1 = " + fila1.Count());
Console.WriteLine();

ExibirFila(fila1);
fila1.Enqueue(".NET MAUI");
ExibirFila(fila1);

Console.WriteLine("\nObtém o primeiro item da fila com Peek");
var elemento = fila1.Peek();
Console.WriteLine(elemento);
Console.WriteLine();

Console.WriteLine("\nMétodo Dequeue - Remove item do início da fila");
fila1.Dequeue();
ExibirFila(fila1);

Console.WriteLine();
Console.WriteLine("Verificando se o C# está na fila:");

if (fila1.Contains("C#"))
    Console.WriteLine("C# Está na fila.");
else
    Console.WriteLine("C# Não está na fila.");

Console.WriteLine();

Console.WriteLine("\nLimpa a fila com Clear()");
fila1.Clear();
Console.WriteLine("Nº. de Elementos na fila1 = " + fila1.Count());

static void ExibirFila<T>(IEnumerable<T> fila1)
{
    Console.WriteLine();
    foreach (var item in fila1)
    {
        Console.WriteLine(item);
    } 
}


Console.ReadKey();
