using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Liepkite vartotojui įvesti tris skaičius, parašyti šią patikrinimo sąlygą, naudojant else if dalis:
            /* ar pirmas skaičius didesnis už antrą
             * ar antras skaičius didesnis už trečią;
             * ar trečias skaičius didesnis už pirmą;
             * ar pirmi du skaičiai lygūs
             */
            Console.WriteLine("Please enter three numbers (after each grade input press Enter)");
            double[] list = new double[3];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = Convert.ToDouble(Console.ReadLine());
            }
            if (list[0] > list[1])
            {
                Console.WriteLine("First number is bigger than the second number");
            }
            else if (list[1] > list[2])
            {
                Console.WriteLine("Second number is bigger than the third number");
            }
            else if (list[2] > list[1])
            {
                Console.WriteLine("Third number is bigger than the first number");
            }
            else if (list[0] == list[1])
            {
                Console.WriteLine("First number and second number are equal");
            }

            //Liepkite vartotojui įvesti šios dienos oro temperatūrą, atlikite šiuos patikrinimus
            /* ar temperatūra < 0 - išvesti “žiauriai šalta"
             * ar temperatūra < 10 - išvesti “labai šalta”
             * ar temperatūra < 20 - išvesti “šalta”
             * ar temperatūra < 30 - išvesti “normali temperatūra”
             * ar temperatūra < 40 - išvesti “karšta”
             * ar temperatūra >= 40 - išvesti “visiškai degina”
             */
            Console.WriteLine("Please enter today's temperature: ");
            double temperature = Convert.ToDouble(Console.ReadLine());
            if (temperature < 0 )
            {
                Console.WriteLine("It is freezing cold!");
            }
            else if (temperature < 10)
            {
                Console.WriteLine("It is really cold!");
            }
            else if(temperature < 20)
            {
                Console.WriteLine("It is cold!");
            }
            else if(temperature <30)
            {
                Console.WriteLine("It is a normal temperature");
            }
            else if( temperature < 40)
            {
                Console.WriteLine("It is hot!");
            }
            else if ( temperature >= 40)
            {
                Console.WriteLine("It is really hot!");
            }
        }
    }
}
