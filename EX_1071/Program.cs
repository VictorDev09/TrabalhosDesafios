using System;
namespace EX_1071
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, impares, somaImpar;

            Console.WriteLine("Digite dois numeros: ");
            valor1 = int.Parse(Console.ReadLine());
            valor2 = int.Parse(Console.ReadLine());

            if (valor1 > valor2)
            {
                int troca = valor1;
                valor1 = valor2;
                valor2 = troca;
            }

            somaImpar = 0;

            for (impares = valor1 + 1; impares < valor2; impares++)
            {
                if (impares % 2 != 0)
                {

                    somaImpar += impares;
                }

            }
            Console.WriteLine("SOMA IMPARES = " + somaImpar);
        }
    }
}




