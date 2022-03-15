using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
namespace zad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nigga = Console.ReadLine();
            StringBuilder nigga1 = new StringBuilder();
            for (int i = 0; i < nigga.Length; i++)
            {
                nigga1.Append((Char)(nigga[i] + 3));
            }
            Console.WriteLine(string.Join("", nigga1));
        }
    }
}
