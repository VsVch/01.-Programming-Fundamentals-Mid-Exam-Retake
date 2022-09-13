using System;

namespace CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            double energy = double.Parse(Console.ReadLine()); // int can also be used
            int wins = 0;

            string command = Console.ReadLine();
            if (command == "end")
            {
                Console.WriteLine($"Aleksandar, please be careful");
            }

            while (command != "End of battle")
            {

                double distance = double.Parse(command);

                if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
                    // Before exiting the loop, energy must be subtracted otherwise can enter winning validation
                    energy -= distance;
                    break;
                }

                energy -= distance;
                wins++;

                if (wins % 3 == 0)
                {
                    energy += wins;
                }

                command = Console.ReadLine();
            }

            if (energy >= 0) // energy needs to be larger or equal to 0
            {
                Console.WriteLine($"Won battles: {wins}. Energy left: {energy}");
            }
            

        }
    }
}