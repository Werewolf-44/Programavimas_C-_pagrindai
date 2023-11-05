using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Įvesti du skaičius iš konsolės
             * Paklausti vartotojo kokį veiksmą su tais skaičiais nori atlikti: sudėtis, atimtis,  kėlimas 4 laipsniu sudėjus abu skaičius, kvadratinė šaknis sudėjus abu skaičius.
             * Parašyti po atskirą metodą kiekvienam veiksmui (sudėčiai ir atimčiai naudoti  int tipą, o visiems kitiems double).
             * Su switch() patikrinti kokį veiksmą atlikti ir kiekviename case‘e išsikviesti  atitinkamą metodą, jei tokio case‘o nėra – informuoti vartotoją, jog tokio veiksmo nėra.
             */
            Console.Write("Please provide first number: ");
            int first_number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please provide a second number: ");
            int second_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose what you want the system to do and type:");
            Console.WriteLine("1 - Calculate the sum of both numbers");
            Console.WriteLine("2 - Calculate the difference of both numbers");
            Console.WriteLine("3 - Calculate the sum of both numbers and raise it by power of 4");
            Console.WriteLine("4 - Calculate the sum of both numbers and calculate the square root");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine(Sum(first_number, second_number));
                    break;
                case 2:
                    Console.WriteLine(Division(first_number, second_number));
                    break;
                case 3:
                    Console.WriteLine(Power_four(first_number, second_number));
                    break;
                case 4:
                    Console.WriteLine(Square_root(first_number, second_number));
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }
        private static int Sum(int first_number, int second_number)
        {
            Console.Write("Sum of both numbers is: ");
            return first_number + second_number;
        }
        private static int Division(int first_number, int second_number)
        {
            Console.Write("Difference of both numbers is: ");
            return first_number - second_number;
        }
        private static double Power_four(int first_number, int second_number)
        {
            Console.WriteLine("Sum of both number raised by power of 4 is:");
            int total_sum = first_number + second_number;
            return (double) Math.Pow(total_sum, 4);
        }
        private static double Square_root (int first_number, int second_number)
        {
            Console.WriteLine("Square root of sum of both numbers is:");
            int total_sum = first_number + second_number;
            return (double) Math.Sqrt(total_sum);
        }
    }
}
