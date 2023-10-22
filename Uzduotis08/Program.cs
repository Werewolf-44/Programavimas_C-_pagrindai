using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Liepkite vartotojui įvesti bet kokį sveikąjį skaičių. Išveskite šio skaičiaus daugybos lentelę nuo 1 iki 5. Pvz.: 2 * 1 = 2
            Console.WriteLine("Please enter any number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            var daugiklis = 1;
            Console.WriteLine(number + " * " + daugiklis + " = " + number * daugiklis++);
            Console.WriteLine(number + " * " + daugiklis + " = " + number * daugiklis++);
            Console.WriteLine(number + " * " + daugiklis + " = " + number * daugiklis++);
            Console.WriteLine(number + " * " + daugiklis + " = " + number * daugiklis++);
            Console.WriteLine(number + " * " + daugiklis + " = " + number * daugiklis++);
            Console.WriteLine(number + " * " + daugiklis + " = " + number * daugiklis++);
            Console.WriteLine(number + " * " + daugiklis + " = " + number * daugiklis++);
            Console.WriteLine(number + " * " + daugiklis + " = " + number * daugiklis++);
            Console.WriteLine(number + " * " + daugiklis + " = " + number * daugiklis++);
            Console.WriteLine(number + " * " + daugiklis + " = " + number * daugiklis++);

            //Liepkite vartotojui įvesti tris skaičius. Į ekraną išveskite šiuos skaičius ir jų vidurkį. Pvz.: Įvestų skaičių 4, 5, 8 vidurkis: 5,7.
            Console.WriteLine("Write down 3 numbers (press Enter after each number):");
            double[] list = new double[3];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Average of these three numbers is: " + list[0] + " + " + list[1] + " + " + list[2] + " = " + list.Average());

            //Liepkite įvesti tris skaičius. Išveskite įvestus skaičius, jų kvadratus, juos pakeltus trečiuoju laipsniu, taip pat tuos skaičius, padalintus iš dviejų.
            Console.WriteLine("Write down 3 numbers (press Enter after each number):");
            double[] list_two = new double[3];
            for (int i = 0; i < list_two.Length; i++)
            {
                list_two[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Your numbers are: " + list_two[0] + ", " + list_two[1] + " and " + list_two[2]);
            Console.WriteLine("Your numbers by power of 2 are: " + Math.Pow(list_two[0], 2) + ", " + Math.Pow(list_two[1], 2) + " and " + Math.Pow(list_two[2], 2));
            Console.WriteLine("Your numbers by power of 3 are: " + Math.Pow(list_two[0], 3) + ", " + Math.Pow(list_two[1], 3) + " and " + Math.Pow(list_two[2], 3));
            Console.WriteLine("Your numbers divided by 2 are : " + list_two[0] / 2 + ", " + list_two[1] / 2 + " and " + list_two[2] / 2);
        }
    }
}
