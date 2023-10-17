using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Išveskite pasirinkto skaičiaus daugybos lentelę.
            int number = 8;
            Console.WriteLine(number * 1);
            Console.WriteLine(number * 2);
            Console.WriteLine(number * 3);
            Console.WriteLine(number * 4);
            Console.WriteLine(number * 5);
            Console.WriteLine(number * 6);
            Console.WriteLine(number * 7);
            Console.WriteLine(number * 8);
            Console.WriteLine(number * 9);
            Console.WriteLine(number * 10);

            // Arba for loop
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(number * i);
            }

            //Susikurkite sveikojo skaičiaus kintamąjį su dviženklio skaičiaus reikšme. Išveskite į ekraną šio skaičiaus skaitmenų sandaugą.
            double num = 28;
            Console.WriteLine(2 * 8);
        }
    }
}
