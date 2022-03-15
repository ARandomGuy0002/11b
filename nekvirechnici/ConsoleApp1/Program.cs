using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> rechnik = new Dictionary<string, int>();
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (input[0] == "END")
                {
                    break;
                }
                if (rechnik.ContainsKey(input[0]))
                {
                    rechnik[input[0]] += int.Parse(input[1]);
                }
                else
                {
                    rechnik.Add(input[0], int.Parse(input[1]));
                }
            }
            Console.WriteLine($"Total Count: {rechnik.Count}");
            foreach (KeyValuePair<string, int> kvp in rechnik)
            {
                Console.WriteLine("{0} -> Total: {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
