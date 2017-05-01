using System;
using System.Collections.Generic;

class Exemplo_CollectionsGenericList
{
    static void ImprimirList(List<string> collectionL)
    {
        Console.WriteLine();
        //Para imprimir o conteúdo de um List
        foreach (string item in collectionL)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        //Declaração e instanciação de um objeto List que poderá conter inteiros
        List<string> meuList = new List<string>();

        //Adição de itens na coleção
        meuList.Add("Janeiro");
        meuList.Add("Feveiro");
        meuList.Add("Março");
        meuList.Add("Abril");
        meuList.Add("Maio");
        meuList.Add("Junho");
        meuList.Add("Julho");
        meuList.Add("Agosto");
        meuList.Add("Setembro");
        meuList.Add("Outubro");
        meuList.Add("Novembro");
        meuList.Add("Dezembro");

        //Para verificar a quantidade de itens do List
        Console.WriteLine("O List possui " + meuList.Count + " itens");

        Console.WriteLine();

        //Chamando a função para imprimir o List
        Console.WriteLine("List original");
        ImprimirList(meuList);

        Console.WriteLine("O primeiro item da lista: " + meuList[0]);
        Console.WriteLine("O último item da lista: " + meuList[meuList.Count - 1]);

        //Para remover o elemento específico do List
        meuList.Remove("Janeiro");

        //Chamando a função para imprimir o List
        Console.WriteLine("List com item removido");
        ImprimirList(meuList);

        //Para remover o elemento em posição específica do List
        meuList.RemoveAt(2);

        //Chamando a função para imprimir o List
        Console.WriteLine("List com item removido");
        ImprimirList(meuList);

        //Para remover itens em uma faixa de posições específica
        meuList.RemoveRange(1, 3);

        //Chamando a função para imprimir o List
        Console.WriteLine("List com itens removido");
        ImprimirList(meuList);

        Console.WriteLine();

        //Como remover todos os items do List
        meuList.Clear();

        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}