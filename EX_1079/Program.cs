namespace EX_1079
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite valor int: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {

                string[] valores = Console.ReadLine().Split(' ');
                double valor1 = double.Parse(valores[0]);
                double valor2 = double.Parse(valores[0]);
                double valor3 = double.Parse(valores[0]);

                double MediaPonderada = (valor1 * 2 + valor2 * 3 + valor3 * 5) / 10;

                Console.WriteLine(MediaPonderada.ToString("F1"));

            }

        }
    }
}
