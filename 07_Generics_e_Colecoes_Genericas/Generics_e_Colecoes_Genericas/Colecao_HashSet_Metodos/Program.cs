/*
    - Operações com conjuntos:
    * IsSubsetOf : Indica se um objeto HashSet<T> é um subconjunto da coleção especificada.
    * IsSupersetOf : Indica se um objeto HashSet<T> é um superconjunto da coleção especificada.
    * Overlaps : Indica se o objeto HashSet<T> atual e uma coleção especificada compartilham elementos comuns.
    * SetEquals : Indica se um objeto HashSet<T> atual e uma coleção especificada contêm os mesmos elementos.
*/

Console.WriteLine("Coleção HashSet<T> - Métodos\n");

var timesSP = new HashSet<string> { "São Paulo", "Palmeiras", "Santos" };
var timesRJ = new HashSet<string> { "Fluminense", "Vasco", "Flamengo" };
var timesMG = new HashSet<string> { "Cruzeiro", "América", "Atlético" };
var timesMundiais = new HashSet<string>() { "Santos", "Palmeiras", "Cruzeiro", "Fluminense" };

//if(!timesSP.Contains("Corinthians"))
//{
//    timesSP.Add("Corinthians");
//    timesSP.Add("Santos");
//}

//var resultado = timesMG.Remove("Atlético");

//Subconjunto

if (timesSP.IsSubsetOf(timesMundiais))
{
    Console.WriteLine("timeSP é um subconjunto de timesMundiais\n");
}

//Superconjunto
if (timesSP.IsSupersetOf(timesMundiais))
{
    Console.WriteLine("timeSP é um superconjunto de timesMundiais\n");
}

//Indica se o objeto HashSet<T> atual e uma coleção especificada compartilham elementos comuns.
if (timesRJ.Overlaps(timesMundiais))
{
    Console.WriteLine("Pelo menos um time do RJ tem título Mundial");
}

if(!timesSP.SetEquals(timesRJ))
{
    Console.WriteLine("\ntimesSP e timesRJ não contém os mesmos elementos.");
}


//Operações com conjuntos
Console.WriteLine("\nJuntando os HashSet<T> : SP, RJ e MG");
timesSP.UnionWith(timesRJ);
timesSP.UnionWith(timesMG);

ExibirColecao(timesSP);

Console.WriteLine("\nJuntando os Times de SP, RJ e MG ordenados");
var todosTimes = new SortedSet<string>(timesSP);
ExibirColecao(todosTimes);

Console.WriteLine("\nInterseção de dois HashSet<T> : timesSP e timesMundiais");
timesSP.IntersectWith(timesMundiais);
ExibirColecao(timesSP);

Console.WriteLine("\nDiferença de dois HashSet<T> : timesMundias e timesSP");
timesMundiais.ExceptWith(timesSP);
ExibirColecao(timesMundiais);

Console.WriteLine("\nRemove todos os elementos de timesMundiais");
timesMundiais.Clear();
ExibirColecao(timesMundiais);
Console.WriteLine("Fim do processamento...");

Console.ReadKey();

static void ExibirColecao<T>(IEnumerable<T> colecao)
{
    Console.WriteLine();
    foreach (var time in colecao)
    {
        Console.WriteLine($"{time}");
    }
}