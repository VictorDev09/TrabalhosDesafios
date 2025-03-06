namespace EX_1153
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
         int N = int.Parse(Console.ReadLine());

            long fatorial = CalcularFatorial(N);

            Console.WriteLine(fatorial);
        }
        public static long CalcularFatorial(int N)
        {
            long resultado = 1;

            for (int i = 1; i <= N; i++)
            {
                resultado *= i;
            }

            return resultado;
        }

    }
}
