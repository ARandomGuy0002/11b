using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parking = new Dictionary<string, string>();
            int count1 = 0;
            int count2 = 0;
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (input[0] == "end")
                {
                    break;
                }
                else if (input[0] == "in")
                {
                    if (parking.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {input[2]}");
                        
                    }
                    else
                    {
                        parking.Add(input[1], input[2]);
                        Console.WriteLine($"{input[1]} registered with plate number {input[2]}");
                        count1++;
                    }
                }
                else if (input[0] == "out")
                {
                    if (parking.ContainsKey(input[1]))
                    {
                        parking.Remove(input[1]);
                        Console.WriteLine($"{input[1]} unregistered successfully");
                        count2++;
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {input[1]} not found");
                    }
                }
            }
            foreach (KeyValuePair<string, string> kvp in parking)
            {
                    Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine($"In -> {count1}");
            Console.WriteLine($"Out -> {count2}");
        }
    }
}
