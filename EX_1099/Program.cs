namespace EX_1099
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int casosN = int.Parse(Console.ReadLine());


            for (int i = 0; i < casosN; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                Console.WriteLine("Valor 1: ");
                int x = int.Parse(valores[0]);
                Console.WriteLine("Valor 2: ");
                int y = int.Parse(valores[1]);

                int soma = 0;

                if (x > y)
                {
                    int troca = x;
                    x = y;
                    y = troca;
                }

                for (int j = x + 1; j < y; j++)
                {

                    if (j % 2 != 0)
                    {
                        soma = soma + j;
                    }
                }

                Console.WriteLine($"SOMA = {soma}");

            }
        }
    }
}
