using System;
using System.Diagnostics.CodeAnalysis;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
            }

            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine($" sayı: {i}");

            }
            for (int i = 1; i < 20; i++)
            {
                int remainder = i % 2;

                if (remainder == 0)
                    Console.WriteLine($"sayı: {i}");

            }

            int sum = 0;

            for (int i = 50; i < 150; i++)
            {
                sum += i;
            }

            Console.WriteLine($"50 den 150'ye kadar olan sayıların toplamı: {sum}");


            int evenSum = 0;
            int oddSum = 0;
            for (int i = 1; i < 120; i++)

            {
                int remainder = i % 2;

                if (remainder == 0)
                {
                    evenSum += i;
                   
                }
                else if (remainder == 1)
                {
                    oddSum += i;  
                }
            }

            Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı: {evenSum}");
            Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı: {oddSum}");

        }
    }
}