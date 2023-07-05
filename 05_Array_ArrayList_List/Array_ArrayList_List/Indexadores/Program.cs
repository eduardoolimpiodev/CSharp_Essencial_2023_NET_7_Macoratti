/*
    - Indexadores: Os indexadores permitem que as intâncias de uma classe ou struct sejam indexadas como um array.
    Eles lembrarm as propriedades mas seus assessores {get; set; } recebem parâmetros.
    Um indexador é um membro da classe que permite acessar uma variável de membro da classe ou struct usando os recursos de
    um array.
    Quando definimos um indexador para uma classe, essa classe se comporta com um array virtual e podemos acessar a instância
    da classe usando o operador de acesso ao array ([]) e também usar índices para acessar e atribuir valores como nos arrays.
    Para declarar um indexador em um classe ou struct, usa-se a palabra this.
 */

using Indexadores;
Console.WriteLine("\n### Indexadores ###");


//Atribuir valores
Time time = new Time();
time[1] = "Cruzeiro";
time[3] = "São Paulo";
time[5] = "Vasco";
time[6] = "Palmeiras";

//Obter valores 
string valor1 = time[1];
string valor2 = time[3];
string valor3 = time[5];
string valor4 = time[6];

//exibir valores
Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
Console.WriteLine(valor4);

Console.ReadKey();


