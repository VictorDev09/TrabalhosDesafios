namespace EX_1065
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (Primo(x))
                {
                    Console.WriteLine($"{x} e primo");
                }
                else
                {
                    Console.WriteLine($"{x} nao e primo");
                }
            }
        }

        public static bool Primo(int numero)
        {
            if (numero <= 1) return false;
            if (numero <= 3) return true;

            if (numero % 2 == 0 || numero % 3 == 0) 
                return false;

            for (int i = 5; i * i <= numero; i += 6)
            {
                if (numero % i == 0 || numero % (i + 2) == 0) 
                    return false;
            }

            return true;
        }
    }
}