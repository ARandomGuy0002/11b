using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> ukazatel = new Dictionary<string, string>();
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string command = input[0];
                if (command == "END")
                {
                    break;
                }
                else if (command == "A")
                {
                    if (ukazatel.ContainsKey(input[1]))
                    {
                        ukazatel[input[1]] = input[2];

                    }
                    else
                    {
                        ukazatel.Add(input[1], input[2]);
                    }
                }
                else if (command == "S")
                {
                    if (ukazatel.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{input[1]} -> {ukazatel[input[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"contact {input[1]} does not exist");
                    }
                }


            }
        }
    }
}
