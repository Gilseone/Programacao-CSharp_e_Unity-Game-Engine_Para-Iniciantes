using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exemplo_CollectionsQueue
{
    static void ImprimirQueue(Queue<string> collectionQ)
    {
        Console.WriteLine();
        //Para imprimir o conteúdo de um Queue
        foreach (string item in collectionQ)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        //Forma de implementação de uma fila ==> "FIFO"
        //Declaração e instanciação de um objeto Queue que poderá conter strings
        Queue<string> collectionQueue = new Queue<string>();

        //Adição de itens na coleção
        collectionQueue.Enqueue("Idosos");
        collectionQueue.Enqueue("Grávidas");
        collectionQueue.Enqueue("Deficientes");
        collectionQueue.Enqueue("Funcionários");

        //Para verificar a quantidade de itens do Collection
        Console.WriteLine("O Queue possui " + collectionQueue.Count + " itens");

        Console.WriteLine();

        //Chamando a função para imprimir o Queue
        Console.WriteLine("Queue original");
        ImprimirQueue(collectionQueue);

        //Como obter o primeiro item da lista
        string strPrimeiroDaFila = collectionQueue.Peek();
        Console.WriteLine("Primeiro da fila: " + strPrimeiroDaFila);

        //Para remover o primeiro elemento do Queue
        collectionQueue.Dequeue();

        Console.WriteLine();

        //Chamando a função para imprimir o Queue
        Console.WriteLine("Queue com '" + strPrimeiroDaFila + "' removido");
        ImprimirQueue(collectionQueue);

        //Como remover todos os items do Queue
        collectionQueue.Clear();

        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}