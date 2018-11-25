using System;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int boundary = int.Parse(Console.ReadLine());

            int combinationCount = 0;
            int totalSum = 0;

            for (int i = N; i >= 1; i--)
            {
                for (int j = 1; j <= M; j++)
                {
                    if (totalSum > boundary) { break; }

                    totalSum += (i * j) * 3;
                    combinationCount++;
                }
            }

            if (totalSum >= boundary)
            {
                Console.WriteLine($"{combinationCount} combinations");
                Console.WriteLine($"Sum: {totalSum} >= {boundary}");
            }
            else
            {
                Console.WriteLine($"{combinationCount} combinations");
                Console.WriteLine($"Sum: {totalSum}");
            }
        }
    }
}
