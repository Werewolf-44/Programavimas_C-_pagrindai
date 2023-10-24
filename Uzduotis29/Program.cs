using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please provide your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please provide your age!");
            double age = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please provide one of your hobies!");
            string hobby = Console.ReadLine();
            Saying_Hello(name, age, hobby);
        }

        /* Parašykite metodą, kuris pasisveikintų su vartotoju.
         * Vartotojas turi įvesti savo vardą, amžių ir hobio pavadinimą.
         * Visi šie duomenys yra duodami metodui, kuris visą šią informaciją išveda formatuotai
         */
        private static void Saying_Hello(string name, double age, string hobby)
        {
            Console.WriteLine($"Hello {name} ({age})! Very nice to meet you! I also like {hobby}");
        }
    }
}
