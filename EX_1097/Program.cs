﻿using System;
namespace EX_1097
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 9; i +=2)
            {
                for(int j = i + 6; j >= i + 4; j--)
                {
                    Console.WriteLine($"I={i} J={j}");
                }
            }

        }
    }
}
