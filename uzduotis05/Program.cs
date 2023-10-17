using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Išveskite į ekraną dviejų skaičių sumą, skirtumą, sandaugą ir dalmenį, kiekvieną kartą nurodant atliekamą veiksmą ir šių skaičių reikšmes. 
             * Pvz.: 4 + 5 = 9, 4 - 5 = -1
            */
            int first_number = 10;
            int second_number = 5;
            Console.WriteLine($"{first_number} + {second_number} = {first_number + second_number}");
            Console.WriteLine($"{first_number} - {second_number} = {first_number - second_number}");
            Console.WriteLine($"{first_number} * {second_number} = {first_number * second_number}");
            Console.WriteLine($"{first_number} / {second_number} = {first_number / second_number}");

            //Išveskite į ekraną pasirinktą skaičių, jo kvadratą ir jį pakeltą trečiuoju laipsniu.
            int number = 3;
            Console.WriteLine(number);
            Console.WriteLine(number * number);
            Console.WriteLine(Math.Pow(number, 3));

            //Išveskite į ekraną trijų skaičių sandaugą.
            int num1 = 3;
            int num2 = 4;
            int num3 = 5;
            Console.WriteLine(num1*num2*num3);

            /*Išveskite į ekraną šių veiksmų atsakymus:
             * -1 + 4 * 6
             * 14 + -4 * 6 / 11
             * 2 + 15 / 6 * 1 - 7 % 2
             */
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        }
    }
}
