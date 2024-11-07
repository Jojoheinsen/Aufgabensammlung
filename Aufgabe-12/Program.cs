using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_12
{
    internal class Program
    {

       


        static void Main(string[] args)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Zahlen Aufsummieren");
            Console.WriteLine("-------------------");

            Console.WriteLine("Geben Sie die zu summierenden Ganzzahlen mit Komma getrennt ein: ");
            string eingabe = Console.ReadLine();


            int[] arr = eingabe.Split(',').Select(int.Parse).ToArray();
            int[] ergebnis = SumUp(arr);

            Console.WriteLine("Resultat: " + string.Join(", ", ergebnis));


            Console.ReadKey();
        }

        static int[] SumUp(int[] arr)
        {
            int[] summearray = new int[arr.Length];
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                summearray[i] = sum;
            }

            return summearray;

        }





    }

    }
    

