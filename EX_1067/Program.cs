using System;
namespace EX_1067
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero, impares;

            Console.Write("Digite um numero de 1 a 1000: ");
            Numero = int.Parse(Console.ReadLine());


            if (Numero >= 1 && Numero <= 1000)
            {
                for (impares = 1; impares <= Numero; impares += 2)
                {
                    Console.WriteLine(impares);
                }
            }

        }
    }
}