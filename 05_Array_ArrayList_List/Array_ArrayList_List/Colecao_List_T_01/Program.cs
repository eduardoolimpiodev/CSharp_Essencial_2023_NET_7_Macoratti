/*
List<T> - Definição
    * A coleção List<T> é uma coleção de objetos fortemente tipados que podem ser acessados usando um índice que inicia em zero, e possui métodos para classificar, pesquisar, modificar
    * e manipular listas.
    * Esta coleção é a versão genérica da coleção ArrayList.
    * A classe List<T> pode ser usada para criar uma coleção de tipos diferentes, onde T representa o tipo do objeto que pode ser inteiro, string, double, etc...e também pode ser
    * um tipo complexo com uma classe definida pelo usuário.
    
    Métodos para adicionar elementos em uma List<T> : 
    Add(),
    AddRange(),
    Insert(),
    InsertRange()
    ou usando a sintaxe de inicializador de coleção.
    
*/

Console.WriteLine("Coleção List<T> #01 \n");


List<string> lista;
lista = new List<string>();
lista.Add("Eduardo");

//Posso criar dessa forma também:

var listas = new List<string>()
{
    "Eduardo", "Ramos", "Junqueira", "Olimpio"
};


// 3 Formas de declarar e instanciar uma coleção do tipo List<T>:

List<int> lista1 = new List<int>();

var lista2 = new List<float>();

List<double> lista3 = new();

Console.ReadKey();
