using System;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int lastMagicN = -1;
            int lastMagicM = -1;
            int combinationCount = 0;
            bool foundMagicCombo = false;

            for (int i = N; i <= M; i++)
            {
                for (int j = N; j <= M; j++)
                {
                    if (i + j == magicNum)
                    {
                        lastMagicN = i;
                        lastMagicM = j;
                        foundMagicCombo = true;
                    }
                    combinationCount++;
                }
            }

            if (foundMagicCombo)
            {
                Console.WriteLine($"Number found! {lastMagicN} + {lastMagicM} = {magicNum}");
            }
            else
            {
                Console.WriteLine($"{combinationCount} combinations - neither equals {magicNum}");
            }
        }
    }
}
