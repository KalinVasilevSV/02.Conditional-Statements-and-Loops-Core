using System;

namespace _06.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            if(numOne<numTwo)
            {
                for (int i = numOne; i <= numTwo; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = numTwo; i <= numOne; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
