using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exemplo_Metodos
{

    static void Main(string[] args)
    {
        //Metodo padra de inicio do console
        //Não é necessario no caso de classes
    }

    public static void MeuMetodo()
    {
        
    }

    public static int MeuMetodoInt()
    {
        //O metodo deve sempre retornar um valor do mesmo tipo que foi designado
        return 0;
    }

    // Metodos podem ter nomes repetidos, se a ASSINATURA (parametros) for diferente
    public static string MeuMetodoInt(string valor)
    {
        return "minha string";
    }

    //Podem receber mais de um parametro
    public static int MeuMetodoInt(string valor1, int valor2)
    {
        return 0;
    }

    //Metodos podem receber parametros de valor (numericos) ou por referencia (objetos, listas e strings)
    public static int MeuMetodoInt(string valor1, List<string> lst, int valor2)
    {
        return 0;
    }
}
