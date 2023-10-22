using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leiskite vartotojui įvesti du sveikuosius skaičius į programą.  Sukurkite ir panaudokite šiuos metodus:
             * Suma;
             * Skirtumas;
             * Sandauga;
             * Dalmuo;
             */
            Console.WriteLine("Please provide two whole numbers:");
            int first_number = Convert.ToInt32(Console.ReadLine());
            int second_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The sum of these two numbers is: {first_number} + {second_number} = " + Sum(first_number, second_number));
            Console.WriteLine($"The difference of these two numbers is: {first_number} - {second_number} = " + Difference(first_number, second_number));
            Console.WriteLine($"The multiplication of these two numbers results to: {first_number} * {second_number} = " + Multiplication(first_number, second_number));
            Console.WriteLine($"The division of these two numbers is: {first_number} / {second_number} = " + Division(first_number, second_number));
        }

        private static int Sum(int one, int two)
        {
            return one + two;
        }
        private static int Difference(int one, int two)
        {
            return one - two;
        }
        private static int Multiplication(int one, int two)
        {
            return one * two;
        }
        private static double Division(int one, int two)
        {
            return (double)one / two;
        }

    }
}
