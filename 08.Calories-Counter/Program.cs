using System;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numIngredients = int.Parse(Console.ReadLine());
            string ingredient = string.Empty;

            int calCheese = 500;
            int calTomatoSauce = 150;
            int calSalami = 600;
            int calPepper = 50;

            int totalCalories = 0;

            for (int i = 0; i < numIngredients; i++)
            {
                ingredient = Console.ReadLine();

                switch (ingredient.ToLower())
                {
                    case "cheese":
                        totalCalories += calCheese;
                        break;
                    case "tomato sauce":
                        totalCalories += calTomatoSauce;
                        break;
                    case "salami":
                        totalCalories += calSalami;
                        break;
                    case "pepper":
                        totalCalories += calPepper;
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine($"Total calories: {totalCalories}");

        }
    }
}
