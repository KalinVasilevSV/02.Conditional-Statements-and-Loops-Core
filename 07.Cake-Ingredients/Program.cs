using System;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            int numIngredients = 0;

            while(true) //Should contain check for empty string
            {
                input = Console.ReadLine();

                if (input == "Bake!") { break; }

                Console.WriteLine($"Adding ingredient {input}.");
                numIngredients++;
            }

            Console.WriteLine($"Preparing cake with {numIngredients} ingredients.");

        }
    }
}
