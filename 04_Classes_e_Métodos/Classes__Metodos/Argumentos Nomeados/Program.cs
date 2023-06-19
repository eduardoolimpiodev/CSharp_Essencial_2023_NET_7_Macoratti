Console.WriteLine("Argumentos  nomeados\n");

Email email = new Email();
email.Enviar(destino:"Teste E-mail",titulo: "URGENTE",assunto: "Reunião de orçamentos");


Console.ReadLine();

public class Email
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \n Assunto: {assunto}");
    }
}