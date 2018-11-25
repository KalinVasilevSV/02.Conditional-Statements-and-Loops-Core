using System;

namespace _14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char letterOne = char.Parse(Console.ReadLine());
            char letterTwo = char.Parse(Console.ReadLine());
            char magicLetter = char.Parse(Console.ReadLine());

            for (char i = letterOne; i <= letterTwo; i++)
            {
                for (char j = letterOne; j <= letterTwo; j++)
                {
                    for (char k = letterOne; k <= letterTwo; k++)
                    {
                        if ((i == magicLetter) || (j == magicLetter) || (k == magicLetter)) { continue; }
                        Console.Write($"{i}{j}{k} ");
                    }
                }
            }
        }
    }
}
