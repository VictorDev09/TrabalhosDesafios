namespace EX_1094
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int totalCobaias = 0;
            int totalCoelhos = 0;
            int totalRatos = 0;
            int totalSapos = 0;

            Console.WriteLine("Quantidade de testes: ");
            int testes = int.Parse(Console.ReadLine());

            for (int i = 0; i < testes; i++) {

                string[] entrada = Console.ReadLine().Split(' ');
                int quantidade = int.Parse(entrada[0]);
                char tipo = char.Parse(entrada[1]);

                totalCobaias += quantidade;

                switch (tipo) {

                    case 'C':
                        totalCoelhos += quantidade;
                        break;
                    case 'R':
                        totalRatos += quantidade;   
                        break;
                    case 'S':
                        totalSapos += quantidade;
                        break;

                
                }

            }

            Console.WriteLine($"Total: {totalCobaias} cobaias");
            Console.WriteLine($"Total de coelhos: {totalCoelhos}");
            Console.WriteLine($"Total de ratos: {totalRatos}");
            Console.WriteLine($"Total de sapos: {totalSapos}");

            Console.WriteLine($"Percentual de coelhos: {((double)totalCoelhos / totalCobaias * 100).ToString("F2")}%");
            Console.WriteLine($"Percentual de ratos: {((double)totalRatos / totalCobaias * 100).ToString("F2")}%");
            Console.WriteLine($"Percentual de sapos: {((double)totalSapos / totalCobaias * 100).ToString("F2")}%");

        }
    }
}
