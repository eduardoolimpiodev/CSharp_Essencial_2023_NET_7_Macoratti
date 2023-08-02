﻿Console.WriteLine("\nQueue<T> Exemplo");

//Criando a fila de pedidos
Queue<Pedido> filaPedidos = new Queue<Pedido>();

//adicionar pedidos na fila
filaPedidos.Enqueue(new Pedido(101, 10.0));
filaPedidos.Enqueue(new Pedido(201, 20.0));
filaPedidos.Enqueue(new Pedido(301, 30.0));

//Exibir o número de pedidos na fila
Console.WriteLine($"Número de pedidos na fila : {filaPedidos.Count}");

//processar os pedidos na fila

while (filaPedidos.Count > 0)
{
    //retirar o próximo pedido da fila
    Pedido proximoPedido = filaPedidos.Dequeue();

    Console.WriteLine($"Processando pedido {proximoPedido.Numero}, " + 
        $"valor {proximoPedido.Valor}");
}

//Adicionar mais alguns pedidos à fila.

filaPedidos.Enqueue(new Pedido(401, 40));
filaPedidos.Enqueue(new Pedido(501, 50));
filaPedidos.Enqueue(new Pedido(601, 60));

//localizar um pedido na fila
int numeroPedido = 501;
Pedido? pedidoLocalizado = filaPedidos.FirstOrDefault(p => p.Numero == numeroPedido);
if (pedidoLocalizado != null)
    Console.WriteLine($"Pedido {numeroPedido} localizado na fila, " + $"valor {pedidoLocalizado.Valor}");
else
    Console.WriteLine($"Pedido {numeroPedido} não encontrado na fila");

Console.ReadKey();


class Pedido
{
    public Pedido(int numero, double valor)
    {
        Numero = numero;
        Valor = valor;
    }

    public int Numero { get; set; }
    public double Valor { get; set; }
}