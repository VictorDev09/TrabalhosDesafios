namespace EX_1144
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= N; i++) 
            {

                Console.WriteLine($"{i} {i*i} {i*i*i}  ");
                Console.WriteLine($"{i} {i * i +1} {i * i * i +1} ");



            }
        }
    }
}
