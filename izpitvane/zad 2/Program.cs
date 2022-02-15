using System;
using System.Collections.Generic;
using System.Linq;
namespace zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            string[] a = Console.ReadLine().Split().ToArray();
            while (true)
            {
                if (a[0] == "stop")
                {
                    Console.WriteLine(string.Join(" ", names));
                    break;
                }
                else if (a[0] == "find")
                {
                    if (names.Contains(a[2]) == false)
                    {
                        names.Insert(int.Parse(a[1]), a[2]);
                    }
                }
                else if (a[0] == "add")
                {
                    int b = int.Parse(a[1]);
                    while (b != 0)
                    {
                        names.Add(a[2]);
                        b -= 1;
                    }
                }
                else if (a[0] == "del")
                {
                    names.Remove(a[1]);
                }
                a = Console.ReadLine().Split().ToArray();
            }
    }
}
