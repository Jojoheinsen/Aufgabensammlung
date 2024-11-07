using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int i2 = 1; i2 <= 10; i2++)
                {
                    int zahl = i * i2;
                    Console.Write(zahl + "\t");
                }
                Console.Write("\n");
            }
            Console.Write("\nWartet auf eingabe...");
            Console.ReadKey();
        }
        
    }
}
