using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_14
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Prüfen, ob es sich bei einem Jahr um ein Schaltjahr handelt.");
            Console.WriteLine("************************************************************");
            while (true)
            {
               

                Console.WriteLine("Ganzzahlige Dezimalzahl (q to Quit):");
                string eingabe = Console.ReadLine();
                if (eingabe.ToLower() == "q")
                {
                    break;
                }
                else
                {
                    
                }

                
            }
            Environment.Exit(0);
        }
    }
}
