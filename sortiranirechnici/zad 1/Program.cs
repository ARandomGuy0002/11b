using System;
using System.Collections.Generic;
using System.Linq;
namespace zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            foreach (var num in nums)
            {
                if (numbers.ContainsKey(num))
                {
                    numbers[num]++;
                }
                else
                {
                    numbers.Add(num, 1);
                }
            }
            foreach (KeyValuePair<double, int> kvp in numbers)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
