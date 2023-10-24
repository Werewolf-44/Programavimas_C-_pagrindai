using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Liepti vartotojui įvesti 5 pažymius VIENOJE eilutėje atskiriant tarpu. Rasti  didžiausią pažymį.
            Console.WriteLine("Enter 5 grades by separating them with a space:");
            string[] grades_string = Console.ReadLine().Split(' ');
            int[] grades = Array.ConvertAll(grades_string, int.Parse);
            Console.WriteLine("The biggest grade is: " + grades.Max());

            //Liepti vartotojui įvesti 5 pažymius VIENOJE eilutėje atskiriant kableliu. Rasti mažiausią pažymį.
            Console.WriteLine("Enter 5 grades by separating them with a space:");
            string[] grades_string_two = Console.ReadLine().Split(',');
            int[] grades_two = Array.ConvertAll(grades_string_two, int.Parse);
            Console.WriteLine("The lowest grade is: " + grades_two.Min());
        }
    }
}
