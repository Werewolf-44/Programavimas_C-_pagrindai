using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Įvesti du skaičius iš konsolės
             * Paklausti vartotojo kokį veiksmą su tais skaičiais nori atlikti: Daugybą ar  dalybą
             * Parašyti po atskirą metodą kiekvienam veiksmui (daugybai naudoti int tipą, o  dalybai double)
             * Su if patikrinti kokį veiksmą atlikti ir išsikviesti atitinkamą metodą, jei tokio  veiksmo nėra – informuoti vartotoją, jog tokio veiksmo nėra.
             */
            Console.Write("Please provide first number: ");
            int first_number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please provide a second number: ");
            int second_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose what you want the system to do and type:");
            Console.WriteLine("1 - Multiply first number by second number");
            Console.WriteLine("2 - Divide first number by second number");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine(Multiply(first_number, second_number));
            }
            else if (choice == 2)
            {
                Console.WriteLine(Division(first_number, second_number));
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        private static int Multiply(int first_number, int second_number)
        {
            Console.Write("Multiplicion of first number by second number results in: ");
            return first_number * second_number;
        }
        private static double Division(int first_number, int second_number)
        {
            Console.Write("Dividing first number by second number results in: ");
            return (double) first_number / second_number;
        }
    }
}
