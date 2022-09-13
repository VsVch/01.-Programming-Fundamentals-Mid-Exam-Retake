using System;
using System.Text;

namespace P01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activKey = Console.ReadLine();
            StringBuilder sb = new StringBuilder(activKey);

            string command = string.Empty;
            while (command != "Generate")
            {
                string[] commandAction = command.Split(">>>");

                if (commandAction[0] == "Contains")
                {
                    string subString = commandAction[1];
                    if (sb.ToString().Contains(subString))
                    {
                        Console.WriteLine($"{sb} contains {subString}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }

                }
                else if (commandAction[0] == "Flip")
                {
                    if (commandAction[1] == "Upper")
                    {
                        int startIndex = int.Parse(commandAction[2]);
                        int endIndex = int.Parse(commandAction[3]);

                        int validStartIndex = Math.Max(0, startIndex);
                        int validEndIndex = Math.Min(sb.Length - 1, endIndex);

                        if (validEndIndex >= validStartIndex)
                        {
                            for (int i = validStartIndex; i < validEndIndex; i++)
                            {
                                sb[i] = char.Parse(sb[i].ToString().ToLower());
                            }
                        }
                        Console.WriteLine(sb);
                    }
                }
                else if (commandAction[0] == "Slice")
                {
                    int startIndex = int.Parse(commandAction[1]);
                    int endIndex = int.Parse(commandAction[2]);
                    int validStartIndex = Math.Max(0, startIndex);
                    int validEndIndex = Math.Min(sb.Length - 1, endIndex);

                    if (validEndIndex >= validStartIndex)
                    {
                        int lenghtRemove = validEndIndex - validStartIndex;
                        sb.Remove(validStartIndex, lenghtRemove);
                    }
                    Console.WriteLine(sb);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {sb}");
        }

    }
}
