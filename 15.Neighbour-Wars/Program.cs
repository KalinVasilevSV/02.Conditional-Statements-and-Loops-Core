using System;

namespace _15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int dmgPesho = int.Parse(Console.ReadLine());
            int dmgGosho = int.Parse(Console.ReadLine());

            string winner = string.Empty;

            int healthPesho = 100;
            int healthGosho = 100;

            int round = 0;

            while ((healthGosho > 0) && (healthPesho > 0))
            {
                round++;

                if ((round % 2) == 1)
                {
                    healthGosho -= dmgPesho;
                    if (healthGosho <= 0)
                    {
                        winner = "Pesho";
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healthGosho} health.");
                }
                else
                {
                    healthPesho -= dmgGosho;
                    if (healthPesho <= 0)
                    {
                        winner = "Gosho";
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healthPesho} health.");
                }

                if ((round % 3) == 0)
                {
                    healthPesho += 10;
                    healthGosho += 10;
                }
            }

            Console.WriteLine($"{winner} won in {round}th round.");

        }
    }
}
