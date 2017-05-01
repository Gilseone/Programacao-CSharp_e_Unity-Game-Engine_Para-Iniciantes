using System;
using System.Collections.Generic;

class Exemplo_CollectionsStack
{
    static void ImprimirStack(Stack<int> collectionS)
    {
        Console.WriteLine();
        //Para imprimir o conteúdo de um Stack
        foreach (int item in collectionS)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        //Forma de implementação de uma pilha ==> "LIFO"
        //Declaração e instanciação de um objeto Stack que poderá conter inteiros
        Stack<int> collectionStack = new Stack<int>();

        //Adição de itens na coleção
        collectionStack.Push(1);
        collectionStack.Push(2);
        collectionStack.Push(3);
        collectionStack.Push(4);
        collectionStack.Push(5);
        collectionStack.Push(6);

        //Para verificar a quantidade de itens do Collection
        Console.WriteLine("O Stack possui " + collectionStack.Count + " itens");

        Console.WriteLine();

        //Chamando a função para imprimir o Stack
        Console.WriteLine("Stack original");
        ImprimirStack(collectionStack);

        //Como obter o item no topo da lista
        int strTopoDaPilha = collectionStack.Peek();
        Console.WriteLine("O último item da pilha: " + strTopoDaPilha);

        //Para remover o elemento do topo do Stack
        collectionStack.Pop();

        Console.WriteLine();

        //Chamando a função para imprimir o Stack
        Console.WriteLine("Stack com '" + strTopoDaPilha + "' removido");
        ImprimirStack(collectionStack);

        //Como remover todos os items do Stack
        collectionStack.Clear();

        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}