using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Susikurti 2 masyvus su duomenimis, išbandant abu kūrimo būdus (iškart su  duomenimis, arba pirma nusirodant dydį ir tada priskiriant reikšmes),
            * skirtą studentų pažymiams saugoti
            */
            double[] grades = new double[5];
            grades[0] = 1;
            grades[1] = 2;
            grades[2] = 3;
            grades[3] = 4;
            grades[4] = 5;
            Console.WriteLine($"First grade is {grades[0]} and the last grade is {grades[4]}");
            //skirtą mašinų markėms saugoti.
            string[] cars = { "Hyundai", "Audi", "BMW", "Toyota", "Mazda" };
            Console.WriteLine($"First car is {cars[0]} and the last car is {cars[4]}");
        }
    }
}
