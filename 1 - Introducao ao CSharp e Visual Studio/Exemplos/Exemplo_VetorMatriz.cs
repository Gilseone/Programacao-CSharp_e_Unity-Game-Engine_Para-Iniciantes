using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exemplo_VetorMatriz
{
    static void Main(string[] args)
    {
        //Declaração de arrays
        int[] numeros; // declara numeros como um array de qualquer tamnho de ints
        numeros = new int[10];  // converte numeros para um array de 10 elementos
        numeros = new int[20];  // converte numeros para um array de 20 elementos

        int[] novoArray = new int[10]; //Declara um novo array com um tamanho de 10 elementos


        //Declaração de Arrays multi-dimensionais (Matrizes)
        string[,] nomes;
        nomes = new string[12,12];
        string[,] nomes2 = new string[3,4];

        string[][] valores;
        valores = new string[12][]; // não possui o numero de colunos pré-definido
        string[][] valores2 = new string[12][]; // não possui o numero de colunos pré-definido

        //Arrays pré-populados
        int[] arrayPopulado = new int[5] { 1, 2, 3, 4, 5 };
        int[] arrayPopuladoForma2 = new int[] { 1, 2, 3, 4, 5 }; //Não é necessario especificar o tamanho do array a ser populado
        int[] arrayPopuladoForma3 = { 1, 2, 3, 4, 5 }; //Não é necessario especificar o tamanho do array a ser populado


        string[] arrayNomes = new string[3] { "Matt", "Joanne", "Robert" };
        string[] arrayNomesForma2 = new string[] { "Matt", "Joanne", "Robert" };
        string[] arrayNomesForma3 = { "Matt", "Joanne", "Robert" };


        //Exemplo iteração sobre arrays utilizando for
        for (int i = 0; i < arrayPopulado.Length; i++)
        {
            Console.WriteLine(arrayPopulado[i]);
        }

        int[][] array = new int[2][] { new int[3] { 1, 2, 3 }, new int[3] { 4, 5, 6 } };
        for (int j = 0; j < array.Length; j += 1)
        {
            for (int k = 0; k < array[j].Length; k += 1)
            {
                Console.Write(array[j][k]);
            }
        }
        //Exemplo de iteração sobre arrays utilizando for each
        foreach (int i in arrayPopulado)
        {
            Console.WriteLine(i);
        }

        foreach (int[] i in array)
        {
            foreach (int j in i)
            {
                Console.WriteLine("Matriz: " + j);
            }
        }

    }
}
