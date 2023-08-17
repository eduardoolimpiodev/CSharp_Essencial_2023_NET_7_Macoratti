Console.WriteLine("Delegate MultiCast\n");

/*
    Podemos encapsular mais de uma referência de método em um delegate usando um multicast delegate. 
    O Multicast delegate é um delegate que contém as referências a mais de método.
    Quando invocamos o multicast delegate, todos os métodos referenciados pelo delegate serão invocados em ordem.
    Um multicast delegate é útil em situações em que várias ações precisam ser executadas quando um evento ocorrer.
*/

MeuDelegate delegateMultiCast = new MeuDelegate(Metodo1);
delegateMultiCast += Metodo2;
delegateMultiCast += Metodo3;

delegateMultiCast("Olá, multicast delegate!");

Console.WriteLine();

delegateMultiCast -= Metodo3;
delegateMultiCast("O método3 foi removido...");


Console.ReadKey();

static void Metodo1(string mensagem)
{
    Console.WriteLine("Método 1: " + mensagem);
}

static void Metodo2(string mensagem)
{
    Console.WriteLine("Método 2: " + mensagem);
}

static void Metodo3(string mensagem)
{
    Console.WriteLine("Método 3: " + mensagem);
}

public delegate void MeuDelegate(string mensagem);
