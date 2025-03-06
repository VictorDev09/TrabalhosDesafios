using System;
namespace EX_1151
{
    internal class Program
    {
        static void Main(string[] args)
        {

        int N = int.Parse(Console.ReadLine());
        int[]sq = new int[N];

            for (int i = 0; i < N; i++) 
            {
                if (i <= 1)
                {
                    sq[i] = i;
                }
                else 
                {
                    sq[i] = sq[i -1] + sq[i-2];
                }

                Console.Write(sq[i]);

                if (i < N - 1)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();

        }
    }
}
