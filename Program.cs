﻿namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string star = "*";
           string pusto = " ";
           string perehod = "\n";

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.Write(pusto);
                    pusto += "  ";
                }

                for (int k = 0; k < 3; k++)
                {
                    Console.Write(star);

                }
                for (int m = 0; m < 1; m++)
                {
                    Console.Write(perehod);
                    Console.Write("   " + star);
                    perehod += "  ";
                }
                Console.WriteLine();
            }
        }
    }
}
