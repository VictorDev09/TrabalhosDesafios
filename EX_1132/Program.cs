namespace EX_1132
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Valor 1: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor 2: ");
            int y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                int troca = x;
                x = y;
                y = troca;  
            }
            int soma = 0;
            for (int divisiveis = x; divisiveis <= y; divisiveis++)
            {

                if (divisiveis % 13 != 0)
                {
                   soma += divisiveis;
                }

            }
            Console.WriteLine(soma);

        }

    }
}
