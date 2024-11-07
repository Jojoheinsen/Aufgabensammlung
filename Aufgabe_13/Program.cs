using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Wie lang soll die Linie sein? ");
            string eingabe = Console.ReadLine();
            int linie = Convert.ToInt32(eingabe);

            for (int i1 = 0; i1 < linie; i1++)
            {
                for (int i2 = 0; i2 < linie; i2++)
                {
                    if (i1 != i2)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine("\n");

                
            }
            Console.ReadKey();
        }
    }
}
