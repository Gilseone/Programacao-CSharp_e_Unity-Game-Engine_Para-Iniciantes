using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exemplo_OperadorTernario
{
    static void Main(string[] args)
    {
        //###################################
        //EXEMPLO OPERADOR TERNÁRIO
        //###################################

        // Declaração da variável e leitura de dados do console
        Console.WriteLine("Digite um valor positivo ou negativo: ");
        int entrada = Convert.ToInt32(Console.ReadLine());
        string classificacao;

        // Utilizando Operador ternário
        classificacao = (entrada > 0) ? "positivo" : "negativo";

        Console.WriteLine(classificacao);



        //###################################
        //EXEMPLO IF
        //###################################

        // Declaração da variável e leitura de dados do console
        Console.WriteLine("Digite um valor positivo ou negativo: ");
        entrada = Convert.ToInt32(Console.ReadLine());
        classificacao = "";

        // Utilizando IF
        if (entrada > 0)
            classificacao = "positivo";
        else
            classificacao = "negativo";

        Console.WriteLine(classificacao);
    }
}
