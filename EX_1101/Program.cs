﻿namespace EX_1101
{
    internal class Program
    {
        static void Main(string[] args)
        {
 while (true)
        {
            string linha = Console.ReadLine();
            string[] valores = linha.Split(' ');

            int M = int.Parse(valores[0]);
            int N = int.Parse(valores[1]);

            if (M <= 0 || N <= 0)
            {
                break;
            }

            int menor = Math.Min(M, N);
            int maior = Math.Max(M, N);
            int soma = 0;

            for (int i = menor; i <= maior; i++)
            {
                Console.Write(i + " ");
                soma += i;
            }

            Console.WriteLine("Sum=" + soma);
        }
    }
}}
