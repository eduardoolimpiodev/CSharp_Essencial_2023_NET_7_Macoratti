Console.WriteLine("Parâmetros opcionais\n");

Console.WriteLine("Informe o destino: ");
string destino = Convert.ToString(Console.ReadLine());

Console.WriteLine("Informe o Título: ");
string titulo = Convert.ToString(Console.ReadLine());

Console.WriteLine("Informe o Assunto: ");
string assunto = Convert.ToString(Console.ReadLine());

Email email = new Email();
email.Enviar();
email.Enviar(destino);
email.Enviar(destino, titulo);
email.Enviar(destino, titulo, assunto);


Console.ReadKey();

public class Email
{
    public void Enviar(string destino = "Destino Padrão", string titulo = "Titulo Padrão", string assunto = "Assunto Padrão")
    {
        Console.WriteLine($"\nPara {destino} = {titulo} \n Assunto: {assunto}");
    }
}
   

