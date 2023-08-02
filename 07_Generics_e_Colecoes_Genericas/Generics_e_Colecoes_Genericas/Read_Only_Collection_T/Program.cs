using System.Collections.ObjectModel;

Console.WriteLine("ReadOnly Collection\n");

/*
    * São estruturas de dados que permitem que os dados sejam acesados, mas não modificados.
    
    * ReadOnlyCollection<T>:
     - Fornece a classe base para uma coleção somente leitura genérica.
     - É criada a partir de uma coleção mutável (Array ,List).
    * ReadOnlyDisctionary<TKey, TValue>:
     - Representa uma coleção somente leitura genérica de pares chave/valor.
     - Ela é criada a partir de um dicionário mutável.
 */


var planetas = new List<string>() { "Mercúrio", "Vênus", "Terra", "Marte"};
var listaPLanetas = new ReadOnlyCollection<string>(planetas);
Console.WriteLine(listaPLanetas);


Console.ReadKey();
