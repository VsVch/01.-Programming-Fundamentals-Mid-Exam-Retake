using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();
            int count = 0;
            while (input != "End")
            {
                int index = int.Parse(input);


                if (index < number.Count && index >= 0)
                {
                    
                    
                    for (int i = 0; i < number.Count; i++)
                    {
                        int curr = number[index];
                        if (number[i] != -1 && i != index)
                        {
                            if (number[i] > curr)
                            {
                                number[i] -= curr;
                            }
                            else if (number[i] <= curr)
                            {
                                number[i] += curr;
                            }
                        }

                    }

                    number[index] = -1;

                    count++;


                }

                input = Console.ReadLine();
            }

            Console.Write($"Shot targets: {count} -> ");
            Console.WriteLine(string.Join(" ", number));
            
        }
    }
}
