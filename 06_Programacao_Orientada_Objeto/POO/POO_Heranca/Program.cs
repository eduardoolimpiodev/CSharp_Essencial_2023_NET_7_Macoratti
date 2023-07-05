//Modificador de acesso "protected".
/*
Um membro com modificador protected é acessível dentro da sua classe e por instâncias das classes derivadas. 
Uma classe derivada tem acesso aos membros definidos com o modificador public, internal, protected e protected internal de 
uma classe base.

*/

Console.WriteLine("Herança\n");

ClasseDerivada cd = new ClasseDerivada();
cd.VerificaAcesso();


Console.ReadKey();

public class ClasseDerivada : ClasseBase
{
    //campos
    public int public_var = 1;
    protected int protected_var = 2;
    internal int internal_var = 3;
    private int private_var = 4;

    //propriedade
    //Encapsulamento
    public int Private_var
    {
        get { return private_var; }
        set { private_var = value; }
    }

    public void VerificaAcesso()
    {
        Public_Membro();
        Protected_Membro();
        Protected_Internal_Membro();
        Internal_Membro();
        //PrivateMembro();   //-> Não consegue acessar o PRIVATE

        Console.WriteLine("\nAvesso ao campo private : private_var usando uma propriedade GET");
        int soma = public_var + protected_var + internal_var + Private_var;
        Console.WriteLine("\nTotal soma : " + soma);
    }

}


public class ClasseBase
{
    public void Public_Membro()
    {
        Console.WriteLine("ClasseBase - Método Público");
    }

    protected void Protected_Membro()
    {
        Console.WriteLine("ClasseBase - Método Protected");
    }

    internal void Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Método Internal");
    }

    protected internal void Protected_Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Método Protected Internal");
    }

    private void Private_Membro()
    {
        Console.WriteLine("ClasseBase - Método Private");
    }
}