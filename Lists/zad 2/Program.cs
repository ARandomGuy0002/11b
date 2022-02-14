using System;
using System.Collections.Generic;
using System.Linq;
namespace zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] a = Console.ReadLine().Split().ToArray();
            while (true)
            {
                if (a[0] == "Print")
                {
                    Console.WriteLine(string.Join(" ", nums));
                    break;
                }
                else if (a[0] == "Contains")
                {
                    Console.WriteLine(nums.IndexOf(int.Parse(a[1])));
                }
                else if (a[0] == "Remove")
                {
                    nums.RemoveAt(int.Parse(a[1]));
                }
                else if (a[0] == "Add")
                {
                    nums.Insert(int.Parse(a[1]), int.Parse(a[2]));
                }
                a = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
