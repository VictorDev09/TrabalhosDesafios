namespace EX_1155
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double S;

            S = 0;

            for (int i = 1; i <= 100; i++)
            {
                S = S + 1.0 / i;

            }
            Console.WriteLine($"{S:F2}");
        }
    }
}
