using System;

namespace _05.Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string wordPlural = string.Empty;
            char endingChar = word[word.Length - 1];

            string esChars = "ohsxz";

            bool isEndInY = false;
            bool isEndInEsChars = false;

            if (endingChar == 'y')
            {
                isEndInY = true;
            }
            else
            {
                for (int i = 0; i < esChars.Length; i++)
                {
                    if (endingChar == esChars[i])
                    {
                        isEndInEsChars = true;
                    }
                }
            }

            if (isEndInY)
            {
                for (int i = 0; i < word.Length-1; i++)
                {
                    wordPlural += word[i];
                }
                wordPlural += "ies";
            }
            else if (isEndInEsChars)
            {
                wordPlural=word+"es";
            }
            else
            {
                wordPlural=word +'s';
            }

            Console.WriteLine(wordPlural);


        }
    }
}
