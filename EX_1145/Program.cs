namespace EX_1145
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] entrada = Console.ReadLine().Split(' ');
            int x = int.Parse(entrada[0]);
            int y = int.Parse(entrada[1]);

            int contador = 1;
            while (contador <= y)
            {
                for (int i = 0; i < x; i++)
                {
                    if (contador <= y)
                    {
                        Console.Write(contador);
                        if (i < x - 1 && contador < y)
                        {
                            Console.Write(" ");
                        }
                        contador++;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}