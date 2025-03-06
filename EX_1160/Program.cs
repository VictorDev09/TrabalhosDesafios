namespace EX_1160
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int PA = int.Parse(input[0]);
                int PB = int.Parse(input[1]);
                double G1 = double.Parse(input[2]);
                double G2 = double.Parse(input[3]);

                int anos = 0;

                while (PA <= PB)
                {
                    PA += (int)(PA * (G1 / 100.0));
                    PB += (int)(PB * (G2 / 100.0));
                    anos++;

                    if (anos > 100)
                    {
                        Console.WriteLine("Mais de 1 seculo.");
                        goto proximoTeste;
                    }
                }

                Console.WriteLine($"{anos} anos.");

            proximoTeste:;
            }
        }
    }
}