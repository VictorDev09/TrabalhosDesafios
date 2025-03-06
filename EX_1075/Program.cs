using System;
namespace EX_1075
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um valor int: ");
          int Nvalor = int.Parse(Console.ReadLine());

            for (int N = 1; N < 10000; N++)
            {

                if ( N % Nvalor == 2)
                {
                    Console.WriteLine(N);
                }
            }

        }
    }
}

