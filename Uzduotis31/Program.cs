using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Parašykite sumos funkciją su 3 parametrais, kuris gražina int tipo atsakymą.
             * Parašykite dalmens funkciją su 2 parametrais, kuris gražina double tipo  atsakymą.
             * Išsikvieskite abi funkcijas ir atsakymą išveskite į ekraną.
             */
            Console.WriteLine("Please provide 3 numbers and system will do the calculations. Your first number? ");
            int first_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your second number is?");
            int second_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your third number is?");
            int third_number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Total sum of your 3 numbers is: ");
            Console.WriteLine(Sum(first_number, second_number, third_number));
            Console.Write("Dividing first 2 numbers gets you: ");
            Console.WriteLine(Division(first_number, second_number));
        }

        private static int Sum(int first_number, int second_number, int third_number)
        {
            int total_sum = first_number + second_number + third_number;
            return total_sum;
        }

        private static double Division(int first_number, int second_number)
        {
            double division = (double) first_number / second_number;
            return division;
        }
    }
}
