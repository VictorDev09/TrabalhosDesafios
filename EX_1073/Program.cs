namespace EX_1073
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int valores;

            Console.WriteLine("Digite um numero int: ");
            valores = int.Parse(Console.ReadLine());

            for (int par = 2; par <= valores; par += 2)
            {
                long quad = (long)par * par;
                Console.WriteLine($"{quad}");
            }


        }
    }
}


