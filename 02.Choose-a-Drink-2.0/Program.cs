using System;

namespace _02.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            string drink = string.Empty;
            double totalPrice = -1;

            switch (profession)
            {
                case "Athlete": drink = "Water"; break;
                case "Businessman":
                case "Businesswoman": drink = "Coffee"; break;
                case "SoftUni Student": drink = "Beer"; break;

                default: drink = "Tea"; break;
            }

            switch (drink)
            {
                case "Water": totalPrice = quantity * 0.70; break;
                case "Coffee": totalPrice = quantity * 1.00; break;
                case "Beer": totalPrice = quantity * 1.70; break;
                case "Tea": totalPrice = quantity * 1.20; break;

                default: break;
            }


            Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");

        }
    }
}
