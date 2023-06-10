Console.WriteLine("## Estrutura Switch #02!\n");

Console.WriteLine("Informe o nome do mês\t");
var mes = Console.ReadLine().ToLower();

switch(mes)
{
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("Este mês possui 31 dias.");
        break;
    case "fevereiro":
        Console.WriteLine("Este mês possui 28 ou 29 dias.");
        break;
    default:
        Console.WriteLine("Este mês possui 30 dias.");
        break;
}

Console.WriteLine("Instrução Switch aninhadas");

int cargo = 0;
int funcao = 0;
Console.WriteLine("Você é GERENTE(1) ou PROGRAMADOR(2) ?\t");
cargo = Convert.ToInt32(Console.ReadLine());

if (cargo == 2)
{
    Console.WriteLine("Você é Júnior(1) ou Sênior(2) ?");
    funcao = Convert.ToInt32(Console.ReadLine());
}

switch (cargo)
{
    case 1:
        Console.WriteLine("\nBem vindo GERENTE!");
        break;
    case 2:
        Console.WriteLine("\nBem vindo PROGRAMADOR!");
        switch (funcao)
        {
            case 1:
                Console.WriteLine("\nVocê é Júnior");
                break;
            case 2:
                Console.WriteLine("\nVocê é Sênior");
                break;
            default:
                Console.WriteLine("Função desconhecida!");
                break;
        }
        break;
    default:
        Console.WriteLine("\nNão consigo te identificar!");
        break;

}


Console.WriteLine("Fim do processamento...");
Console.ReadKey();
