using System;
namespace EX_1116
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N, x, y;
            double resultado;

            Console.Write("Numero de testes: ");
            N = int.Parse(Console.ReadLine());


            for (int i = 0; i < N; i++) 
            {
                Console.WriteLine("Divisao(x/y): ");
                string[] valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");

                }
                else
                {

                    resultado = (double)x / y;
                    Console.WriteLine("Resultado: " + resultado.ToString("F1"));
                }    
            }
        }
    }
}
