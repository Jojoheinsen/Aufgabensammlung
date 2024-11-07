using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]  forbiddenWords = { "viagra", "sex", "porno", "fick", "schlampe", "arsch" };

            bool foundForbiddenWord = false;

          

            int counter = 0;

            for(int i = 0; i < forbiddenWords.Length; i++)
            {
                Console.WriteLine("Text:");
                string antwort = Console.ReadLine().ToLower();

                if (antwort.Contains(forbiddenWords[i]))
                {
                    counter = 0 + 1;
                }
                if (counter == 0)
                {
                Console.WriteLine("Keine verbotenen Wörter gefunden.");
                }
                if (counter > 0)
                {
                    Console.WriteLine("Ihre nachricht kann nicht geschickt werden.");
                }

            }

            Console.ReadKey();
        }
    }
}
