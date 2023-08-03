Console.WriteLine("Lançando Exceções - Throw\n");


//Console.WriteLine("Antes de lançar uma exception");

//throw new Exception("Lançando uma eecção manualmente");

//RECOMENDADO SEMPRE USAR THROW E NÃO THROW EX.

try
{
    A.ProcessarA();
}
catch (Exception ex)
{
    Console.WriteLine("\nTratando o erro em Main\n");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}



Console.ReadKey();


class A
{
    public static void ProcessarA()
    {
        try
        {
            B.ProcessarB();
        }
        catch (Exception)
        {
            throw;
            Console.WriteLine("Tratando o erro em A");
        }
    }


    class B
    {
        public static void ProcessarB()
        {
            try
            {
                C.ProcessarC();
            }
            catch (Exception)
            {
                throw;
                Console.WriteLine("Tratando o erro em B");
            }
        }
    }

    class C
    {
        public static void ProcessarC()
        {
            throw new NotImplementedException("Método não implementado.");
        }
    }
}
