using System;

namespace Divisão
{

    public class Program 
    {
        public static void Main(string [] args)
        {
			double Numerador;
			double Denominador;
			double Resultado;
			
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Divisão");
			Console.ResetColor();
			
			Console.Write("Digite o numerador: ");
			Numerador = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine();
			
			Console.Write("Digite o denominador: ");
			Denominador = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine();
			
			if (Denominador == 0)
			{
				Console.WriteLine("Não é possível dividir por 0");
			}
			else
			{
				Resultado = Numerador / Denominador;
				Console.WriteLine($"{Numerador} dividido por {Denominador} é igual a {Resultado}");
			}
			
			Console.WriteLine();
			Console.WriteLine("Obrigado por utilizar este programa!");
        }
    }
}