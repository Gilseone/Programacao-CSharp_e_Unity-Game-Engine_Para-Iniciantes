using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //Imprime uma string na tela
        Console.Write("Minha frase");

        //Imprime uma string na tela, pulando uma linha no final
        Console.WriteLine("Minha nova frase");

        //Efetua a leitura da linha inteira
        string inputString;
        Console.WriteLine("Digite seu nome:");
        inputString = Console.ReadLine();

        //Efetua a leitura do primeiro caractere, retornando seu valor ASCII
        int inputCaractere;
        Console.Write("Digite um caractere: ");
        inputCaractere = Console.Read();

        //Imprime na tela, e aguarda que alguma tecla seja pressionada para prosseguir
        Console.WriteLine("Pressione alguma tecla para finalizar.");
        Console.ReadKey();

        return;
    }
}
