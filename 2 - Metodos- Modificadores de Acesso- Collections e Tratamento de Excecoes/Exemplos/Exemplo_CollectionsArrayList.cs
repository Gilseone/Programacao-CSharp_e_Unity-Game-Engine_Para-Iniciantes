using System;
using System.Collections;

class Exemplo_CollectionsArrayList
{
    static void ImprimirArrayList(ArrayList meuArray)
    {
        Console.WriteLine();
        //Para imprimir o conteúdo de um ArrayList
        foreach (string item in meuArray)
            Console.WriteLine(item);
        Console.WriteLine();
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        //Criação do ArrayList
        ArrayList meuArrayList = new ArrayList();
        //Adicionando itens ao ArrayList
        meuArrayList.Add("Domingo");
        meuArrayList.Add("Segunda-feira");
        meuArrayList.Add("Terça-feira");
        meuArrayList.Add("Quarta-feira");
        meuArrayList.Add("Quinta-feira");
        meuArrayList.Add("Sexta-feira");
        meuArrayList.Add("Sábado");

        Console.WriteLine();
        //Para imprimir a quantidade de itens do ArrayList
        Console.WriteLine("O ArrayList possui " + meuArrayList.Count + " itens");

        //Chamando a função para imprimir o ArrayList
        ImprimirArrayList(meuArrayList);

        //#######################################################################################

        Console.WriteLine("Inserir um item em uma posição específica");
        //Para inserir um item em uma posição específica
        meuArrayList.Insert(7, "um segundo sábado :D");

        //Chamando a função para imprimir o ArrayList
        ImprimirArrayList(meuArrayList);

        //#######################################################################################

        Console.WriteLine("Remover um item específico pelo seu valor");
        //Para remover um item específico pelo seu valor
        meuArrayList.Remove("Sábado");

        //Chamando a função para imprimir o ArrayList
        ImprimirArrayList(meuArrayList);

        //#######################################################################################

        Console.WriteLine("Remover um item em uma posição específica");
        //Para remover um item em uma posição específica
        meuArrayList.RemoveAt(1);

        //Chamando a função para imprimir o ArrayList
        ImprimirArrayList(meuArrayList);

        //#######################################################################################

        Console.WriteLine("Remover um item em uma faixa de valor específica");
        //Para remover um item em uma faixa de valor específica
        meuArrayList.RemoveRange(0, 3);

        //Chamando a função para imprimir o ArrayList
        ImprimirArrayList(meuArrayList);

        //#######################################################################################

        ArrayList meuArrayListAux1 = new ArrayList();
        ArrayList meuArrayListAux2 = new ArrayList();

        Console.WriteLine("Forma errada de copiar o conteúdo de ArrayList");
        //Forma errada de copiar o conteúdo de ArrayList
        meuArrayListAux1 = meuArrayList;
        meuArrayList.Add("Outro dia qualquer que foi removido do meuArrayList");

        //Chamando a função para imprimir o ArrayList
        ImprimirArrayList(meuArrayListAux1);

        //VEJA BEM: eu adicionei no meuArrayList e imprimi o meuArrayListAux. Algo de errado?

        Console.WriteLine("Forma correta de copiar o conteúdo de ArrayList");
        //Forma correta de copiar o conteúdo de ArrayList            
        meuArrayListAux2 = (ArrayList)meuArrayList.Clone();
        meuArrayList.Add("Um feriado");
        ImprimirArrayList(meuArrayListAux2);
		
		//#######################################################################################
		
		//Para remover todo o conteúdo de um ArrayList
        meuArrayList.Clear();

        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}