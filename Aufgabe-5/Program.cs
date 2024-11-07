using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wie vile Kilometer willst du rennen? ");
            string eingabe = Console.ReadLine();
            int km = Convert.ToInt32(eingabe);

            int runden = ((km * 1000) / 400);

            if (km > 42)
            {
                Console.WriteLine("Das schaffst du nicht!");
            }
            else
            {

                
                Console.Write("Das sind die " + runden + " Runden. Bereit für den Lauf? ");
                Console.Write(" Bist du Bereit? [ j / n ]: ");
                string antwort = Console.ReadLine().ToLower();

                if (antwort == "j")
                {
                    for (int i = 1; i <= runden; i++)
                    {
                        Console.WriteLine("Du läufst Runde " + i);
                    }
                }
                else
                {
                    Console.WriteLine("Dann mach dich bereit");
                }
            }
            
            Console.ReadKey();
            
        }
    }
}
