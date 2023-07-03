/*
 - Principais métodos usados nas consultas LINQ:
 * Any() : Utilizado para determinar se qualquer elemento de uma sequência existe ou atende a uma condição.(Determina se a coleção
   possui elementos.
 * FirstOrDefault() : Retorna o primeiro elemento da coleção que satisfaz uma condição opcional. Retorna o valor padrão do tipo caso
   não encontre nenhum elemento.
 * OrderBy() : Classifica os elementos na coleção em ordem crescente com base em uma determinada condição e retorna a coleção 
   classificada.
 * ToList() : Recebe um topo de IEnumerable e converte em um tipo List.
 * Where() : Retorna todos os elementos da coleção que satisfazem uma determinada condição.(execução adiada).
  
 
 - IEnumerable descreve um comportamento e List implementa esse comportamento. 
   IEnumerable é somente leitura, "read-only", ou seja, eu não consigo alterar a coleção, somente ler.
 - List implementa uma variedade de métodos capazes de acessar e alterar a coleção.
 - IEnumerable possui um método para retornar o próximo item na coleção,
   Não precisa ter toda a coleção na memória, não sabe quantos elementos a coleção possui, ao ser iterada em uma laço foreach
   ela vai retornando o próximo item até o fim da coleção.
 - List possui toda a coleção em memória e sabe quantos itens possui a coleção.
 - IEnumerable dá ao compilador a chance de adiar a execução.
   Somente é executada ao ser iterada em um laço for/foreach ou ter um valor extraído.
 */


Console.WriteLine("List<T> e IEnumerable e Principais métodos usados na consulta LINQ\n");

var limiteCredito = new List<Limite>();

for (int i = 1; i < 16; i++)
{
    limiteCredito.Add(new Limite() { Numero = i });
}

var limitesComRestricao = limiteCredito.Where(x => x.AnalisaLimite()).ToList();

var primeiroLimiteComRestricao = limitesComRestricao.FirstOrDefault();

Console.WriteLine($"\n ### {primeiroLimiteComRestricao.Numero}");


Console.WriteLine("\nFim do processamento...");


Console.ReadKey();

public class Limite
{
    public int Numero { get; set; }
    private bool isRestricao;

    public Limite()
    { 
        var semente = Guid.NewGuid().GetHashCode();
        var numeroAleatorio = new Random(semente).Next(1, 4);
        isRestricao = numeroAleatorio == 1;
    }

    public bool AnalisaLimite()
    {
        Console.WriteLine($"Executa análise de limite de Crédito para o limite {Numero}");
        return isRestricao;
    }
}
