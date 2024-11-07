using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zahl eingeben: ");
            
            string eingabe = Console.ReadLine();
            int zahl = Convert.ToInt32(eingabe);


            string[] monate =  {"Januar", "Februar", "März", "April", "Mai", "Juni", "Juli", "August", "September", "Oktober", "November", "Dezember" };
            Console.Write(monate[zahl -1]);

            Console.ReadKey();

        }
    }
}
