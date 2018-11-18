using System;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            //Prices are Per Night
            double studioPrice = 0.00;
            double doublePrice = 0.00;
            double suitePrice = 0.00;

            double discount = 1.0;
            double discountOneNight = 0.0;

            double totalStudioPrice = 0.00;
            double totalDoublePrice = 0.00;
            double totalSuitePrice = 0.00;

            if(month=="May"||month=="October")
            {
                if (nightsCount > 7) { discount = 1 - 0.05; }

                studioPrice = 50.00*discount;
                doublePrice = 65.00;
                suitePrice = 75.00;

                if (month == "October"&&nightsCount>7) { discountOneNight = studioPrice; }

            }
            else if(month=="June"||month=="September")
            {
                if (nightsCount > 14) { discount = 1 - 0.10; }

                studioPrice = 60.00;
                doublePrice = 72.00 * discount;
                suitePrice = 82.00;

                if (month == "September"&&nightsCount>7) { discountOneNight = studioPrice; }
            }
            else if(month=="July"||month=="August"||month=="December")
            {
                if (nightsCount > 14) { discount = 1 - 0.15; }

                studioPrice = 68.00;
                doublePrice = 77.00;
                suitePrice = 89.00 * discount;
            }

            totalStudioPrice = nightsCount * studioPrice;
            totalDoublePrice = nightsCount * doublePrice;
            totalSuitePrice = nightsCount * suitePrice;

            if (month == "September" || month == "October") { totalStudioPrice -= studioPrice; }

            Console.WriteLine($"Studio: {totalStudioPrice:F2} lv.");
            Console.WriteLine($"Double: {totalDoublePrice:F2} lv.");
            Console.WriteLine($"Suite: {totalSuitePrice:F2} lv.");
        }
    }
}
