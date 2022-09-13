using System;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            double sum = 0;
            while (input != "special" && input != "regular")
            {
                double parts = double.Parse(input);
                if (parts >= 0)
                {
                    sum += parts;
                }
                else
                {
                    Console.WriteLine($"Invalid price!");
                }
                input = Console.ReadLine();

            }

           


            if (input == "regular")
            {
                if (sum == 0)
                {
                    Console.WriteLine($"Invalid order!");
                    return;
                }
                double taxes = 0.2 * sum;
                double withTaxes = sum + taxes;
                double discount = withTaxes - withTaxes * 0.1;

                Console.WriteLine($"Congratulations you've just bought a new computer!");

                Console.WriteLine($"Price without taxes: {sum:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine($"-----------");
                Console.WriteLine($"Total price: {withTaxes:f2}$");
            }
            if (input == "special")
            {
                
                if (sum == 0)
                {
                    Console.WriteLine($"Invalid order!");
                    return;
                }
                double taxes = 0.2 * sum;
                double withTaxes = sum + taxes;
                double discount = withTaxes - withTaxes * 0.1;

                Console.WriteLine($"Congratulations you've just bought a new computer!");

                Console.WriteLine($"Price without taxes: {sum:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine($"-----------");
                Console.WriteLine($"Total price: {discount:f2}$");
            }


        }
    }
}
