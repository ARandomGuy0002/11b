using System;
using System.Linq;
using System.Collections.Generic;
namespace zad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int counter = 0;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] > 5)
                {
                    counter += 1;
                }
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine($"count = {counter}");
            Console.WriteLine($"sum = {sum}");
            Console.WriteLine($"average = {arr.Average()}");
        }
    }
}
