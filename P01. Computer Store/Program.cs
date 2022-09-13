using System;

namespace P01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;
            double amount = 0;
            while (input != "special" && input != "regular")
            {
                double curr = double.Parse(input);
                if (curr < 0) { Console.WriteLine($"Invalid price!"); }
                else{sum += curr;}
                amount = 0.2 * sum;
                input = Console.ReadLine();
            }
            if (sum == 0)
            {Console.WriteLine($"Invalid order!");return;}


            if (input == "special")
            {
                Console.WriteLine($"Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sum:f2}$");
                Console.WriteLine($"Taxes: {amount:f2}$");
                Console.WriteLine($"-----------");
                Console.WriteLine($"Total price: {((sum + amount)*0.9):f2}$");
            }
            else if (input == "regular")
            {
                Console.WriteLine($"Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sum:f2}$");
                Console.WriteLine($"Taxes: {amount:f2}$");
                Console.WriteLine($"-----------");
                Console.WriteLine($"Total price: {(sum + amount):f2}$");
            }
            
            
        }
    }
}
