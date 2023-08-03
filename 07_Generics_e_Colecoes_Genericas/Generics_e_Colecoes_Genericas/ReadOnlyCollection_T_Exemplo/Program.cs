using System.Collections.ObjectModel;

Console.WriteLine("ReadOnly Collection - Exemplo\n");

var exoPlanetas = new ReadOnlyCollection<ExoPlaneta>(ExoPlaneta.GetExoPlanetas());

foreach (var item in exoPlanetas)
{
    Console.WriteLine(item.Nome);
}

Console.ReadKey();


class ExoPlaneta
{
    public string? Nome { get; set; }

    public static List<ExoPlaneta> GetExoPlanetas()
    {
        return new List<ExoPlaneta>()
        {
            new ExoPlaneta() { Nome = "Proxima Centauri b"},
            new ExoPlaneta() { Nome = "Kleper 186-f"},
            new ExoPlaneta() { Nome = "Gliesi 1061-c"},
        };
    }
}
