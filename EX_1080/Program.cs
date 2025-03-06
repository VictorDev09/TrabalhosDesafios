namespace EX_1080
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int maiorvalor = int.MinValue, posicaomaiorValor = 0;

            for (int i = 0; i <= 100; i++)
            {

                Console.WriteLine("Digite 100 valores: ");
                int valor = int.Parse(Console.ReadLine());

                if(valor > maiorvalor)
                {
                    maiorvalor = valor;
                    posicaomaiorValor = i;
                }
            }
            Console.Write("MAIOR VALOR: ");
            Console.WriteLine(maiorvalor);
            Console.Write("POSICAO: ");
            Console.WriteLine(posicaomaiorValor);

        }
    }
}
