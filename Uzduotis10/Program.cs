using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Liepkite įvesti skaičių.
            /*Jei skaičius lyginis, tuomet išveskite šį skaičių bei jo penktą laipsnį.
             * Jei skaičius nesidalina iš 4, tuomet liepkite įvesti antrąjį skaičių. Išveskite abiejų skaičių sumą ir sandaugą.
             */
            Console.WriteLine("Please enter any number:");
            double number = Convert.ToDouble(Console.ReadLine());
            if(number % 2  == 0 )
            {
                Console.WriteLine($"Number is even. Your number is: {number} and this number by power of 5 is:" + Math.Pow(number, 5));
            }
            else
            {
                Console.WriteLine("Number is not even");
            }

            if (number % 4 != 0 )
            {
                Console.WriteLine("Number is not divisible by 4. Please enter another number: ");
                double number_two = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("First number plus second number is: " + (number + number_two));
                Console.WriteLine("First number times second number is: " + number * number_two);
            }
            else
            {
                Console.WriteLine("Number is divisible by 4");
            }
        }
    }
}
