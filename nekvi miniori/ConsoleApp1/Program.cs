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
                string input = Console.ReadLine();
                if (input != "stop")
                {
                    int input1 = int.Parse(Console.ReadLine());
                    if (rechnik.ContainsKey(input))
                    {
                        rechnik[input] = rechnik[input] + input1;
                    }
                    else
                    {
                        rechnik.Add(input, input1);
                    }
                }
                else
                {
                    foreach (KeyValuePair<string, int> kvp in rechnik)
                    {
                        Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
                    }
                    break;
                }

            }
        }
    }
}
