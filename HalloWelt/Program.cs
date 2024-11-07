using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWelt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Was ist ihr name");

            string eingabeVomBenutzer = Console.ReadLine();

            Console.WriteLine("Hallo " + eingabeVomBenutzer);

            Console.ReadKey();
        }
    }
}
