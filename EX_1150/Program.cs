namespace EX_1150
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int z;

            do
            {
                z = int.Parse(Console.ReadLine());
            } while (z <= x);

            int soma = x;
            int contador = 1;
            int proximoNumero = x + 1;

            while (soma <= z)
            {
                soma += proximoNumero;
                proximoNumero++;
                contador++;
            }

            Console.WriteLine(contador);
        }
    }
}