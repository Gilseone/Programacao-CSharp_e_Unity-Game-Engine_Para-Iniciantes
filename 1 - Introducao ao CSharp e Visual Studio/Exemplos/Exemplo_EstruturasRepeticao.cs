using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exemplo_EstruturasRepeticao
{
    static void Main(string[] args)
    {
        int numeroTabuada = 5, i;

        // #########################################################
        //Estrutura for
        // #########################################################

        //Estrutura com variável de controle
        //A estrutura for possui a sintáxe
        //for(inicialização; teste condicional; incremento){bloco de execução}
        for (i = 0; i < 10; i++)
        {
            //Exite mensagem no console
            Console.WriteLine(numeroTabuada + " x " + i + " = " + numeroTabuada * i);
        }

        //Insere uma linha em branco para separar
        Console.WriteLine();

        // #########################################################
        //Estrutura while
        // #########################################################

        //Estrutura pré-testada
        //a estrutura while possui a sintáxe
        //while(teste condicional){bloco de execução}
        i = 0;
        while (i <= 10)
        {
            //Exite mensagem no console
            Console.WriteLine(numeroTabuada + " x " + i + " = " + numeroTabuada * i);
            //Realiza o incremento de i
            i++;
        }

        //Insere uma linha em branco para separar
        Console.WriteLine();

        // #########################################################
        //Estrutura do while
        // #########################################################

        //Estrutura pós-testada
        //a estrutura do while possui a sintáxe
        //do{bloco de execução } while(teste condicional){}
        i = 0;
        do
        {
            //Exite mensagem no console
            Console.WriteLine(numeroTabuada + " x " + i + " = " + numeroTabuada * i);
            //Realiza o incremento de i
            i++;
        } while (i <= 10);

        //Imprime mensagem na tela e aguarda que alguma tecla seja precionada
        Console.WriteLine("Pressione qualquer tecla para continuar");
        Console.ReadKey();
    }
}
