using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exemplo_Exececoes
{
    static void Main(string[] args)
    {

    }

    static void ExemploExcecao()
    {
        try
        {
            // Funcoes a serem executadas
        }
        catch (Exception e)
        {
            // Este bloco é ativado no momento em que ocorre uma exceção, um erro em algum codigo do bloco TRY
            // Aqui é possivel: tratar o erro, "lancar" a excecao, informar o usuário ou gerar um log
        }
        finally
        {
            // Este bloco é sempre ativado, tenha o bloco try capturado um erro ou nao.
        }

        // Outras formas possiveis
        // Try-catch, sem finally
        try
        {

        }
        catch (Exception)
        {
            
        }

        // Try-Finally, sem catch
        try
        {

        }
        finally
        {
            
        }

        //Diversos catches, permitindo tratar excecoes da forma apropridade conforme o erro detectado
        try
        {

        }
        catch (ArithmeticException e)
        {

        }
        catch (IndexOutOfRangeException e)
        {
            
        }
        catch (Exception e)
        {
            
        }

    }

    // Exemplo Try-Catch-Finally
    static void ExemploDivisao1(int vlr1, int vlr2)
    {
        double resultado = 0;

        try
        {
            resultado = vlr1 / vlr2;
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Erro dividindo por 0." + e.Message);
        }
        finally
        {
            Console.WriteLine("Resultado: " + resultado);
        }
    }
}
