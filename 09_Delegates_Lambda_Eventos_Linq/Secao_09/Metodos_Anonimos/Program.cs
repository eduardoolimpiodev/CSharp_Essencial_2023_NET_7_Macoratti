Console.WriteLine("Métodos/Funções anônimas\n");
/*
    Uma função anônima é uma função que não possui nome e que pode ser definida usando a palavra-chave delegate e pode ser atribuída a uma
    variável do tipo delegate.

    Uma função anônima é uma declaração "in-line" ou expressão que pode ser usada swempre que um tipo de delegate for esperado.

    Podemos usá-las para inicializar um delegate nomeado ou passar um método anônimo em vez de um tipo de delegate nomeado como um
    parâmetro de método.

    Existem dois tipos de funções anônimas:
    1 - Métodos Anônimos(Anonymous Method).
    2 - Expressões Lambdas(Lambdas Expressions).

*/

List<string> nomes = new List<string>();
nomes.Add("Eduardo");
nomes.Add("Maria");
nomes.Add("Marcele");
nomes.Add("Roberto");

//string resultado = nomes.Find(VerificaNomeNaLista);
//Utilizando método anônimo
string resultado = nomes.Find(delegate(string nome)
{
    return nome.Equals("Eduardo");
});
Console.WriteLine(resultado);



Imprimir imprimir = delegate (int valor)
{
    Console.WriteLine($"Método anônimo:  {valor}");
};

imprimir(100);
imprimir(200);


Console.ReadKey();


public delegate void Imprimir(int valor);