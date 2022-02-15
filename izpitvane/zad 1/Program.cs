using System;
using System.Collections.Generic;
using System.Linq;
namespace zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine($"sum = {sum}");
            Array.Reverse(arr);
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
