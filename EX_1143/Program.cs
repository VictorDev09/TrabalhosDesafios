namespace EX_1143
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um valor de linhas: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"{i} {i*i} {i*i*i}");
            }
        }
    }
}
