namespace EX_1149
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] entrada = Console.ReadLine().Split(' ');
            int a = int.Parse(entrada[0]);
            int n = int.Parse(entrada[1]);

            while (n <= 0)
            {
                n = int.Parse(Console.ReadLine());
            }

            int soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma += a + i;
            }

            Console.WriteLine(soma);
        }
    }
}