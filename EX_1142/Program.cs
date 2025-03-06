namespace EX_1142
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um valor de linhas: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int contador = 1;

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"{contador} {contador + 1} {contador + 2} PUM");
                Console.WriteLine();
                contador +=4;
            }
        }
    }
}
