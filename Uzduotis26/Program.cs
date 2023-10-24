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
            List<int> numbers = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                int randomNumber = random.Next(100);
                numbers.Add(randomNumber);
            }
            int min_value = numbers.Min();
            int max_value = numbers.Max();
            double average_before = numbers.Average();
            double average_after = Math.Round(average_before, 2);
            double counter_less_avg = 0;
            double counter_even = 0;
            foreach (int number in numbers)
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
            Console.WriteLine($"Average is: {average_after}");
            Console.WriteLine($"How many numbers are lower than average: {counter_less_avg}");
            Console.WriteLine($"Total sum of even numbers: {counter_even}");
        }
    }
}
