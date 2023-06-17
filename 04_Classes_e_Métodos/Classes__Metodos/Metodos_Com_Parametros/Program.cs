Console.WriteLine("Metodos com Parametros\n");

MinhaClasse minhaClasse1 = new MinhaClasse();
minhaClasse1.Saudacao("Eduardo", DateTime.Now.ToLongDateString());


Console.ReadKey();

public class MinhaClasse
{
    public void Saudacao(string nome, string data)
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}