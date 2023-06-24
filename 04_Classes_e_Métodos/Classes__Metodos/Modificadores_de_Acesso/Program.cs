using Modificadores_de_Acesso;

Console.WriteLine("Modificadores de acesso\n");


MinhaClasse minhaClasse = new MinhaClasse();

MinhaEnum minhaEnum = new MinhaEnum();


Console.ReadKey();



internal class MinhaClasse
{
    int MeuCampo;

    string? MinhaPropriedade { get; set; }

    void MeuMetodo()
    {
        Console.WriteLine("Meu Método");
    }

}


