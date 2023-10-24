using System;
using System.Collections.Generic;
using System.Globalization;
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
            int daugiklis = 1; 
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

            //Susikurkite sveikojo skaičiaus kintamąjį su dviženklio skaičiaus reikšme. Išveskite į ekraną šio skaičiaus skaitmenų sandaugą.
            int num = 28;
            int tens = num / 10;
            int ones = num % 10;
            Console.WriteLine($"Sveikasis dviženklis skaičius yra {num}. Pirmas skaičius yra {tens}, antras skaičius yra {ones}. Jų sandauga yra " + tens * ones);

            int[] myNum = { 10, 20, 30, 40 };

            for (int i = 0; i < myNum.Length; i++)
            {
                Console.WriteLine(myNum[i]);
            }
            foreach (int i in myNum)
            {
                Console.WriteLine(i);
            }
        }
    }
}
