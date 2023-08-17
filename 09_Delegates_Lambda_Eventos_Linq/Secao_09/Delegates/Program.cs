Console.WriteLine("Delegates - Delegado#01\n");
//Delegado - Uma pessoa que recebe de alguém o poder de representa-lo.
//Delegar um trabalho a outra pessoa que vai fazer no seu lugar.

/*
    Delegate: É um tipo que representa referências a métodos com uma lista de parâmetros e um tipo de retorno específico.
    Delegate é um tipo de dado.
    Ao instanciar um delegate, podemos associar a sua instância a qualquer método com um assinatura compatível e tipo de retorno,
    e podemos invocar o método por meio da instância delegada.
    os delegates são usados para implementar eventos, métodos de retorno de chamada e para passar métodos como argumentos para outros métodos.
    Usando delegates temos a flexibilidade para implementar qualquer funcionalidade em tempo de execução.

    Um delegate é um tipo de dado ( tipo de referência ) que define a assinatura de um método.
    Podemos definir variáveis de um tipo delegate que podem se referir a qualquer método que tiverem a mesma assinatura do delegate.

    Existem três etapas envolvidas ao trabalhar com delegates:
    1 - Declarar um delegate.
    2 - Definir um método de destino.
    Depois de declarar um delegate, precisamos definir o método de destino ou uma expressão lambda.
    Podemos fazer isso criando um objeto do delegate usando a palavra-chave new e passando um método
    cuja assinatura corresponde á assinatura do delegate.

    3 - Invocar ou chamar um delegate.

    Um delegate pode ser declarado usando a palavra-chave delegate seguido pela assinatura do método.
    [modificador de acesso] delegate [tipo de retorno] [nome do delegate]([parâmetros])
    
*/




//método de destino
static void MeuMetodo(string msg)
{
    Console.WriteLine(msg);
}

//atribuir o método de destino
MeuDelegate del1 = new MeuDelegate(MeuMetodo);
del1.Invoke("Minha Mensagem");
//ou
MeuDelegate del2 = MeuMetodo;
del2("Minha Mensagem");
// ou define uma expressão lambda
MeuDelegate del3 = (msg) => Console.WriteLine(msg);
del3("Minha Mensagem");

//Invocação do delegate: Depois de definir um método de destino, um delegate pode ser invocado usando o método Invoke() ou
// usando o operador() passando os parâmetros definidos.





Console.ReadKey();


public delegate void MeuDelegate(string mensagem);



//Tipo de retorno -> void
//Parâmetros usados -> um parâmetro do tipo string
