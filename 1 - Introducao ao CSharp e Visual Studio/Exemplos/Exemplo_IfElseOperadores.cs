using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExemploIfElse
{
    static void Main(string[] args)
    {
        //Declaração de Variável
        int idade = 18;

        //Verificar se a idade da pessoa é 18 anos ou superior para ser autorizada a contratação d@ funcionári@

        // #########################################################
        //Operador >=
        // #########################################################
        //Teste se a idade é maior ou igual a 18 anos (ou igual)
        if (idade >= 18)
        {
            //Mostra mensagem no console
            Console.WriteLine("Autorizado.");
            Console.WriteLine("Sua idade é: " + idade);
        }
        else
        {
            //Mostra mensagem no console
            Console.WriteLine("Não autorizado.");
            Console.WriteLine("Menor de 18 anos.");
        }

        // #########################################################
        //Operador <
        // #########################################################
        //Teste se a idade for menor que 18 anos
        if (idade < 18)
        {
            //Mostra mensagem no console
            Console.WriteLine("Não autorizado.");
            Console.WriteLine("Menor de 18 anos.");
        }
        else
        {
            //Mostra mensagem no console
            Console.WriteLine("Autorizado.");
            Console.WriteLine("Sua idade é: " + idade);
        }

        //Mas imagine que é autorizada a contratação d@ funcionári@ que possuir idade entre 18 e 40 anos

        // #########################################################
        //Operador >= && <=
        // #########################################################
        //Teste se a idade for maior que 18 anos (ou igual) E (AND) menor que 40 (ou igual) anos
        if (idade >= 18 && idade <= 40)
        {
            //Mostra mensagem no console
            Console.WriteLine("Autorizado.");
            Console.WriteLine("Sua idade é: " + idade);
        }
        else
        {
            //Mostra mensagem no console
            Console.WriteLine("Não autorizado.");
            Console.WriteLine("Menor de 18 anos.");
        }

        // #########################################################
        //Operador >= && <=
        // #########################################################
        //Teste se a idade for menor que 18 anos OU (OR) maior que 40 anos
        if (idade < 18 || idade > 40)
        {
            //Mostra mensagem no console
            Console.WriteLine("Não autorizado.");
            Console.WriteLine("Menor de 18 anos.");
        }
        else
        {
            //Mostra mensagem no console
            Console.WriteLine("Autorizado.");
            Console.WriteLine("Sua idade é: " + idade);
        }

        //Imprime mensagem na tela e aguarda que alguma tecla seja precionada
        Console.WriteLine("Pressione qualquer tecla para continuar");
        Console.ReadKey();
    }
}
