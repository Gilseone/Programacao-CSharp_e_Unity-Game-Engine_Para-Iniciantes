using System;
using System.Collections.Generic;

    class Exemplo_CollectionsGenericDictionary
    {
    static void ImprimirDictionary(Dictionary<string, string> collectionD)
    {
        Console.WriteLine();
        //Para imprimir o conteúdo de um Dictionary
        foreach (KeyValuePair<string, string> item in collectionD)
        {
            Console.WriteLine("Key: " + item.Key + " Value: " + item.Value);
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        //Declaração e instanciação de um objeto Dictionary
        //que poderá conter inteiros como key e string como value
        Dictionary<string, string> meuDictionary = new Dictionary<string, string>();

        //Adição de itens na coleção
        meuDictionary.Add("1º mês", "Janeiro");
        meuDictionary.Add("2º mês", "Feveiro");
        meuDictionary.Add("3º mês", "Março");
        meuDictionary.Add("4º mês", "Abril");
        meuDictionary.Add("5º mês", "Maio");
        meuDictionary.Add("6º mês", "Junho");
        meuDictionary.Add("7º mês", "Julho");
        meuDictionary.Add("8º mês", "Agosto");
        meuDictionary.Add("9º mês", "Setembro");
        meuDictionary.Add("10º mês", "Outubro");
        meuDictionary.Add("11º mês", "Novembro");
        meuDictionary.Add("12º mês", "Dezembro");

        //Para verificar a quantidade de itens do Dictionary
        Console.WriteLine("O Dictionary possui " + meuDictionary.Count + " itens");

        Console.WriteLine();

        //Chamando a função para imprimir o Dictionary
        Console.WriteLine("Dictionary original");
        ImprimirDictionary(meuDictionary);

        //#######################################################################################

        //Para remover o elemento com uma Key específica do Dictionary
        meuDictionary.Remove("3º mês");

        //Chamando a função para imprimir o Dictionary
        Console.WriteLine("Dictionary com item removido");
        ImprimirDictionary(meuDictionary);

        Console.WriteLine();

        //#######################################################################################

        //Para vefificar se o Dictionary contem uma Key em específico
        //Obs.: Você também pode pesquisar por um Value pelo método .ContainsValue(value)
        if (meuDictionary.ContainsKey("2º mês"))
        {
            string value = meuDictionary["2º mês"];
            Console.WriteLine("Valor pesquisado: " + value);
        }

        Console.WriteLine();

        //#######################################################################################

        //Como remover todos os items do Dictionary
        meuDictionary.Clear();

        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}