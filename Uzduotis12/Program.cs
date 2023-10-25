using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Liepkite įvesti tris skirtingus skaičius. Suraskite, kuris iš šių skaičių yra didžiausias.
            Console.WriteLine("Please enter 3 random numbers (after each number input press Enter)");
            double[] array = new double[3];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine(array.Max());

            /* Liepkite įvesti egzamino rezultatą. Atlikite šiuos patikrinimus:
             * ar gautas rezultatas yra [8-10];
             * ar gautas rezultatas yra [5-8);
             * ar gautas rezultatas yra < 5.
             */
            Console.WriteLine("Please write down your exam grade");
            double number = Convert.ToDouble(Console.ReadLine());
            if (number > 8 && number <= 10)
            {
                Console.WriteLine("Exam result is more than 8 and less than 10");
            }
            else if (number >= 5  && number < 8)
            {
                Console.WriteLine("Exam is more than 5 but less than 8");
            }
            else
            {
                Console.WriteLine("Exam is less than 5");
            }

            /* Liepkite įvesti du skaičius. Patikrinkite (naudojant 4 atskirus if’us):
             * ar pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0;
             * ar antras skaičius yra didesnis už pirmąjį, arba yra lygus 5;
             * ar pirmas skaičius yra didesnis už antrąjį ir yra lygus 20;
             * ar antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100.
             */
            Console.WriteLine("Please enter 2 random numbers (after each number input press Enter)");
            double[] array_two = new double[2];
            for (int i = 0; i < array_two.Length; i++)
            {
                array_two[i] = Convert.ToDouble(Console.ReadLine());
            }
            if (array_two[0] > array_two[1] || array_two[0] == 0)
            {
                Console.WriteLine("First number in the array is bigger than the second number or equal to 0");
            }
            if (array_two[1] > array_two[0] || array_two[1] == 5)
            {
                Console.WriteLine("Second number in the array is bigger than the first number or equal to 5");
            }
            if (array_two[0] > array_two[1] && array_two[0] == 20)
            {
                Console.WriteLine("First number in the array is bigger than the second number and is equal to 20");
            }
            if (array_two[1] > array_two[0] && array_two[1] < 100)
            {
                Console.WriteLine("Second number in the array is bigger than the first number and is less than 100");
            }
        }
    }
}
