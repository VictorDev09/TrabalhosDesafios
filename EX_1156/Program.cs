namespace EX_1156
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double S, numerador, denominador;

            S = 1.0;
            numerador = 3.0;
            denominador = 2.0;

            while (numerador <= 39)
            {
                S = S + (numerador / denominador);
                numerador = numerador + 2.0;
                denominador = denominador * 2.0;
            }

            Console.WriteLine($"{S:F2}");

        }
    }
}
