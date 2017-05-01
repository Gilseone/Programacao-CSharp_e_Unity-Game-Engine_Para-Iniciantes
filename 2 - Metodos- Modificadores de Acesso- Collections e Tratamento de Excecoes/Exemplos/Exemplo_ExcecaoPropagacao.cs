using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exemplo_ExcecaoPropagacao
{
    static void Main(string[] args)
    {

        // Todos os metodos e funcoes executados dentro deste bloco TRY
        // serão capturados e tratados neste mesmo bloco de catch
        try
        {
            ExemploDivisao1(1, 0);
        }
        catch (Exception e)
        {
            Console.WriteLine("Exceção encontrada: " + e.GetType());
            throw;
        }

    }

    // Ou seja, os erros que acontecem neste metodo, serão tratadas no método que o chamou (Main)
    static double ExemploDivisao1(int vlr1, int vlr2)
    {
        return  vlr1 / vlr2;
    }
}
