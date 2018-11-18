using System;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {

            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            double discount = 0.0;
            double hallPrice = 0.00;
            double packagePrice = 0.00;
            string hall = string.Empty;
            bool haveHall = true;


            if (groupSize > 120)
            {
                haveHall = false;
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hall = "Great Hall";
                hallPrice = 7500.00;
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hall = "Terrace";
                hallPrice = 5000.00;
            }
            else if (groupSize <= 50)
            {
                hall = "Small Hall";
                hallPrice = 2500.00;
            }


            if (haveHall)
            {
                switch (package)
                {
                    case "Normal":
                        packagePrice = 500.00;
                        discount = 0.05;
                        break;
                    case "Gold":
                        packagePrice = 750.00;
                        discount = 0.10;
                        break;
                    case "Platinum":
                        packagePrice = 1000.00;
                        discount = 0.15;
                        break;
                    default: break;
                }

                double pricePerPerson = (hallPrice + packagePrice) * (1.00 - discount) / groupSize;

                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");

            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

        }
    }
}
