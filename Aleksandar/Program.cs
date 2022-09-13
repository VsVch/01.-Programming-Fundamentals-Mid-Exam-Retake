using System;

namespace P02_PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(1);
            if (n == 1)
            {
                return;
            }
            int[] first = new int[] { 1, 1 };
            Console.WriteLine(string.Join(' ', first));
            if (n == 2)
            {
                return;
            }
            else
            {
                for (int i = 0; i < first.Length + 1; i++)
                {
                    int[] arr = new int[first.Length + 1];
                    arr[0] = 1;
                    arr[arr.Length - 1] = 1;

                    for (int j = 1; j < arr.Length - 1; j++)
                    {
                        arr[j] = first[j - 1] + first[j];
                    }
                    Console.WriteLine(string.Join(" ", arr));

                    first = arr;
                    if (first.Length == n)
                    {
                        break;
                    }

                }
            }



        }
    }
}