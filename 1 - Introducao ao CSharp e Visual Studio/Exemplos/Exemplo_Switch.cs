using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exemplo_Switch
{
    static void Main(string[] args)
    {
        string sexo = "Homem";

        switch (sexo)
        {
            case "masculino":
                Console.Write("Homem");
                break;

            case "feminino":
                Console.Write("Mulher");
                break;

            default:
                Console.Write("Não informado");
                break;
        }
    }
}
