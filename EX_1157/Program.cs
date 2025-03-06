namespace EX_1157
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= N; i++)
            {

                if ( N % i == 0)
                {
                    Console.WriteLine(i);
                }            
            
            }
        }
    }
}
