using System;

namespace _09.Count_the_Integers_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numIntegers=0;

            try
            {
                while(true)
                {
                    int.Parse(Console.ReadLine());
                    numIntegers++;
                }
            }
            catch(Exception)
            {
                Console.WriteLine(numIntegers);
            }

        }
    }
}
