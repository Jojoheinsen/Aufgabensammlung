using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wieviele Tage hat der Monat, für den sie die Sekunden ausrechnen wollen?\t");
            string eingabe = Console.ReadLine();

            
            

            if (int.TryParse(eingabe, out int tage) && (tage == 28 || tage == 29 || tage == 30 || tage == 31))
            {
                Console.WriteLine("Ihre Eingabe " + tage + " ist gültig.");
                int sekunden = tage * 24 * 60 * 60;
                Console.WriteLine($"Die Anzahl der Sekunden in " + tage + "Tagen beträgt " + sekunden + " Sekunden.");
            }
            else
            {
                Console.WriteLine("Eingabefehler. Bitte geben Sie eine Zahl ein.");
            }



            Console.ReadKey();
        }
    }
}
