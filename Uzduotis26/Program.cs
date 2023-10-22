using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Sugeneruokite sąrašą, kurį užpildykite atsitiktiniais skaičiais nuo 1 iki 100. Raskite:
             * mažiausią skaičių;
             * didžiausią skaičių;
             * vidurkį;
             * kiek skaičių yra žemesni už vidurkį;
             * lyginių skaičių sumą;
             */
            List<double> numbers = new List<double>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(8);
            numbers.Add(9);
            numbers.Add(10);
            double min_value = numbers.Min();
            double max_value = numbers.Max();
            double average = numbers.Average();
            double counter_less_avg = 0;
            double counter_even = 0;
            foreach (double number in numbers)
            {
                if (number < numbers.Average())
                {
                    counter_less_avg++;
                }
                if (number % 2 == 0)
                {
                    counter_even += number;
                }
            }
            Console.WriteLine($"Lowests numbers is: {min_value}");
            Console.WriteLine($"Highest numbers is: {max_value}");
            Console.WriteLine($"Average is: {numbers.Average()}");
            Console.WriteLine($"How many numbers are lower than average: {counter_less_avg}");
            Console.WriteLine($"Total sum of even numbers: {counter_even}");
        }
    }
}
