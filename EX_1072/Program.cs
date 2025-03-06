namespace EX_1072
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N_inteiros, XNumeros, dentro, fora;

            dentro = 0;
            fora = 0;

            Console.Write("Quantos numeros vai digitar? ");
            N_inteiros = int.Parse(Console.ReadLine());

            for (int caso = 0; caso < N_inteiros; caso++)
            {
                Console.WriteLine("Digite os numeros: ");
                XNumeros = int.Parse(Console.ReadLine());

                if (XNumeros >= 10 && XNumeros <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine(dentro + " dentro");
            Console.WriteLine(fora + " fora");

        }
    }
}
