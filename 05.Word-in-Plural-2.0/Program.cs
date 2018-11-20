using System;

namespace _05.Word_in_Plural_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string wordPlural = string.Empty;

            bool isEndY = word.EndsWith('y');
            bool isEndOHSXZ = word.EndsWith('o') || word.EndsWith('h') || word.EndsWith('s') || word.EndsWith('x') || word.EndsWith('z');


            if (isEndY)
            {
                wordPlural=word.Remove(word.Length - 1)+"ies";
            }
            else if(isEndOHSXZ)
            {
                wordPlural = word + "es";
            }
            else
            {
                wordPlural = word + "s";
            }

            Console.WriteLine(wordPlural);
        }
    }
}
