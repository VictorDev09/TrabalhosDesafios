namespace EX_1158
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int X = int.Parse(valores[0]);
                int Y = int.Parse(valores[1]);

                int soma = 0;
                int contador = 0;

                while (contador < Y)
                {
                    if (X % 2 != 0)
                    {
                        soma += X;
                        contador++;
                    }
                    X++;
                }

                Console.WriteLine(soma);
            }
        }
    }
}