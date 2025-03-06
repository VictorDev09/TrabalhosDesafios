namespace EX_1074
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Valores, numero;

            Console.WriteLine("Digite o numero de casos: ");
            Valores = int.Parse(Console.ReadLine());

            for (int parim = 0; parim < Valores; parim++)
            {
                Console.WriteLine("Digite um numero: ");
                numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    Console.WriteLine("NULO");

                }
                else
                {
                    string parimpar = (numero % 2 == 0) ? "PAR" : "IMPAR";
                    string positivoNegativo = (numero > 0) ? "POSITIVO" : "NEGATIVO";

                    Console.WriteLine($"{parimpar}{positivoNegativo}");
                }
            }
        }
    }
}
