using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> rechnik = new Dictionary<string, double>();
            double grandTotal = 0;
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                /*string product = input[0];
                double price = double.Parse(input[1]);
                int count = int.Parse(input[2]);*/
                rechnik.Add(input[0], double.Parse(input[1]));
                if (input[0] == "stocked")
                {
                    foreach (KeyValuePair<string, double> kvp in rechnik)
                    {
                        double total = kvp.Value * int.Parse(input[2]);
                        grandTotal += total;
                        Console.WriteLine($"{kvp.Key}: ${kvp.Value:F2} * {int.Parse(input[2])} = {total:F2}");
                    }
                    break;
                }

            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${grandTotal:F2}");
        }
    }
}
