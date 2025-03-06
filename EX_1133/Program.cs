using System;
namespace EX_1133
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int valor;

            Console.WriteLine("Digite x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite y: ");
            int y = int.Parse(Console.ReadLine());

            if (x > y) 
            {
                int troca = x;
                x = y; 
                y = troca;
            }

            for (valor = x + 1; valor < y; valor++)
            {
                if (valor % 5 == 2 || valor % 5 == 3)
                {
                    Console.WriteLine(valor);
                }
            }
        }
    }
}
