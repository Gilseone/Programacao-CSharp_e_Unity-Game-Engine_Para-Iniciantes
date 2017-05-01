using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
	static void Main(string[] args)
	{
		//Declaração de Variáveis
		int i;
		int resultado;

		//Pós-Incremento
		i = 1;
		resultado = i++;
		//Exibe no console
		Console.WriteLine("Pós-Incremento: " + resultado);

		//Pré-Incremento
		i = 1;
		resultado = ++i;
		//Exibe no console
		Console.WriteLine("Pré-Incremento: " + resultado);

		//Pós-Incremento
		i = 1;
		//Exibe no console
		Console.WriteLine("Pós-Incremento IF");
		if (i++ == 2)
			Console.WriteLine("É igual");
		else
			Console.WriteLine("Não é igual");

		//Pré-Incremento
		i = 1;
		//Exibe no console
		Console.WriteLine("Pré-Incremento IF");
		if (++i == 2)
			Console.WriteLine("É igual");
		else
			Console.WriteLine("Não é igual");

		//Imprime mensagem na tela e aguarda que alguma tecla seja precionada
		Console.WriteLine("Pressione qualquer tecla para continuar");
		Console.ReadKey();
	}
}
