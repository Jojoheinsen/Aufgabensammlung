using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dieses Programm berechnet die Summe von zwei Zahlen.");

            Console.Write("Zahl 1: ");
            string eingabe1 = Console.ReadLine();
            int zahl1 = Convert.ToInt32(eingabe1);

            Console.Write("Zahl 2: ");
            string eingabe2 = Console.ReadLine();
            int zahl2 = Convert.ToInt32(eingabe2);

            int endsumme = (zahl1 + zahl2);

            Console.Write("Summe: " + endsumme);

            Console.ReadKey();
        }
    }
}

