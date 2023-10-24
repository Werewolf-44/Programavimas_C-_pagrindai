using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti savo amžių. Jei amžius yra 18 arba daugiau, tuomet į ekraną išveskite, kad “jūs galite balsuoti”.
            Console.WriteLine("Please enter your age: ");
            double age = Convert.ToDouble(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You can vote!");
            }

            //Liepkite vartotojui įvesti bet kokį skaičių. Parašykite šias atskiras if sąlygas:
            /* Patikrinti, ar skaičius neigiamas, jei taip - aprėkti vartotoją :)
             * Patikrinti, ar skaičius teigiamas, jei taip - pasveikinti vartotoją;
             * Patikrinti, ar skaičius lyginis, jei taip - išvesti “taip, skaičius yra lyginis”;
             * Patikrinti, ar skaičius dalinasi iš 4, jei taip - išvesti “taip, dalinasi iš 4”;
             * Patikrinti, ar skaičius yra didesnis nei 10, jei taip - išvesti “taip, skaičius yra didesnis už 10”.
             */
            Console.WriteLine("Please enter any number:");
            double number = Convert.ToDouble(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("THE NUMBER PROVIDED IS LESS THAN ZERO!");
            }
            else
            {
                Console.WriteLine("Great! The number is acceptable");
            }
            
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }

            if (number % 4 == 0)
            {
                Console.WriteLine("The number is divisible by 4");
            }
            else
            {
                Console.WriteLine("The number is not divisible by 4");
            }

            if (number > 10)
            {
                Console.WriteLine("The number is bigger than 10");
            }
            else
            {
                Console.WriteLine("The number is less than 10");
            }

            // Liepkite vartotojui įvesti du savo pažymius, raskite šių pažymių vidurkį, patikrinkite, ar vidurkis yra lygus arba didesnis už 5, jei taip, išveskite “Valio!!!”.
            Console.WriteLine("Please enter last 2 grades you received (after each grade input press Enter)");
            double[] list = new double[2];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("The average of your two grades is: " + list.Average());
            if (list.Average() >= 5)
            {
                Console.WriteLine("Huuraaay!");
            }
            else
            {
                Console.WriteLine("You can do better....");
            }
        }
    }
}
