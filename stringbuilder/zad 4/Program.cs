using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace zad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string[] details = email.Split('@').ToArray();
            var sum = SumSymbols(details[0]);
            var sum1 = SumSymbols(details[1]);
            int sum2 = sum - sum1;
            if (sum2 >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
        private static int SumSymbols(string v) 
        {
            var sum = 0;
            for (int i = 0; i < v.Length; i++)
            {
                sum += (int)v[i];
            }
            return sum;
        }
    }
}
