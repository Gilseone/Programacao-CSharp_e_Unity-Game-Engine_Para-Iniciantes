using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exemplo_ExcecaoThrow
{
    static void Main(string[] args)
    {
        int vlr1 = 100, vlr2 = 0;
        double resultado = 0;

        try
        {
            // No caso de algum tipo de erro não detectado pelo sistema, pode ser utilizado o comando THROW
            // para lancar erros em situações que envolvam logica de negocio por exemplo.
            // A mensagem do erro também pode ser customizada, passando uma string no inicializador da classe. 

            // No caso, imagine que no vlr1 possa ser utilizado apenas valores PARES, se nao, um erro eh lancado

            if ((vlr1 % 2) != 0)
                throw new Exception("Valor1 deve ser par");

            // Ou é detectado que vlr2 é zero, substituindo assim a mensagem padrao, instruindo o usuario
            if (vlr2 == 0)
                throw new DivideByZeroException("Valor2 não pode ser 0");

            resultado = vlr1 / vlr2;
        }
        catch (Exception e)
        {
            Console.WriteLine("Erro capturado." + e.Message);

            throw;
        }
        finally
        {
            Console.WriteLine("Resultado: " + resultado);
        }



        // Exemplo com throw no bloco CATCH
        try
        {
            resultado = vlr1/vlr2;
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Erro dividindo por 0." + e.Message);

            // No caso de nao souber como proceder quando um erro deste tipo for detectado
            // lancando o "throw" no bloco catch, é gerado um erro no aplicativo, e o mesmo deve ser finalizado
            // nao permitindo proceder a partir deste ponto do código
            throw; 
        }
        finally
        {
            Console.WriteLine("Resultado: " + resultado);
        }

    }
}
