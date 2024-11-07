using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_11
{
    internal class Program
    {
        static int BerechneQuersumme1(int zahl1)
        {

            int sum1 = 0;
            
            while (zahl1 != 0)
            {
                sum1 += (zahl1 % 10);
                zahl1 /= 10;
            }
            return sum1;
        }
        static int BerechneQuersumme2(int zahl2)
        {
            int sum2 = 0;

            while (zahl2 != 0)
            {
                sum2 += (zahl2 % 10);
                zahl2 /= 10;
            }
            return sum2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Zahl1: ");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zahl2: ");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("Zahl\t|Quersumme\t|Zahl / Quersummer");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - ");
            

            int i = BerechneQuersumme1(zahl1);
            int ergebnis2 = BerechneQuersumme2(zahl2);


            Console.WriteLine(zahl1 + "\t" +i + "\t");
            Console.WriteLine(zahl2 + "\t" + ergebnis2 + "\t");


            Console.ReadKey();
        }
    }
}
