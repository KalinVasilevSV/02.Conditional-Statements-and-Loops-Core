using System;

namespace _09.Count_the_Integers
{
    class Program
    {
        //This one worksin my console but gets Runtime errors on Judge tests #3 and #4
        //I will have to figure out the input that causes the errors in Judge

        static void Main(string[] args)
        {
            string input = string.Empty;

            int numIntegers = 0;

            while (true)
            {
                input = Console.ReadLine();

                bool isInteger = true;
                
                for (int i = 0; i < input.Length; i++)
                {
                    bool isDigit = false;

                    for (int digit = '0'; digit <= '9'; digit++)
                    {
                        if (input[i] == digit)
                        {
                            isDigit = true;
                            break;
                        }
                    }

                    if (!isDigit)
                    {
                        isInteger = false;
                        break;
                    }
                }

                if (!isInteger) { break; }

                numIntegers++;
            }

            Console.WriteLine(numIntegers);

        }
    }
}
