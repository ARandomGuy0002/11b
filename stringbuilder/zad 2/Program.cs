using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string bukvaci = Console.ReadLine();
            StringBuilder cifri = new StringBuilder();
            StringBuilder bukvi = new StringBuilder();
            StringBuilder drugoto = new StringBuilder();
            for (int i = 0; i < bukvaci.Length; i++)
            {
                if (Char.IsDigit(bukvaci[i]))
                {
                    cifri.Append(bukvaci[i]);
                }
                else if (Char.IsLetter(bukvaci[i]))
                {
                    bukvi.Append(bukvaci[i]);
                }
                else
                {
                    drugoto.Append(bukvaci[i]);
                }
            }
            Console.WriteLine(string.Join("", cifri));
            Console.WriteLine(string.Join("", bukvi));
            Console.WriteLine(string.Join("", drugoto));
        }
    }
}
