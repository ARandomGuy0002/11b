using System;
using System.Collections.Generic;
using System.Linq;
namespace zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int firstNum = nums[0];
            while (nums.Contains(firstNum))
            {
                nums.Remove(firstNum);
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
