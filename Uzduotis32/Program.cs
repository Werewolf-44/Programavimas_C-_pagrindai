using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Paprašyti įvesti vartotojo vardą.
             * Sukurti string tipo metodą, kuris gražina frazę pvz „Sveiki, Mantas“.
             * Išvesti šią frazę į konsolę.
             */
            Console.WriteLine("Please provide you name:");
            string name = Console.ReadLine();
            Name(name);
        }

        private static string Name(string name)
        {
            Console.WriteLine($"Hello {name}!");
            return name;
        }
    }
}
