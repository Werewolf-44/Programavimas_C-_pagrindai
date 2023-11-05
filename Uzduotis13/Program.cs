using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Liepkite vartotojui įvesti tris skaičius.Su switch patikrinkite pirmąjį skaičių:
             * ar jis lygus 1: išveskite visų trijų skaičių sumą;
             * ar jis lygus 2: išveskite pirmo ir trečio skaičių skirtumą;
             * ar jis lygus 3: išveskite antro ir trečio skaičių sandaugą.
             */
            Console.WriteLine("Please enter 3 random numbers (after each number input press Enter)");
            double[] array = new double[3];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            switch (array[0])
            {
                case 1:
                    if (array[0] == 1)
                    {
                        Console.WriteLine(array[0] + array[1]+ array[2]);
                    }
                    break;
                case 2:
                    if (array[0] == 2)
                    {
                        Console.WriteLine(array[0] - array[2]);
                    }
                    break;
                case 3:
                    if (array[0] == 3)
                    {
                        Console.WriteLine(array[1] * array[2]);
                    }
                    break;
            }

            /*Liepkite vartotojui įvesti gyvūno rūšį.Su switch patikrinkite:
             * ar įvestas gyvūnas yra šuo;
             * ar įvestas gyvūnas yra katė;
             * ar įvestas gyvūnas yra žiurkėnas.
             */
            Console.WriteLine("Please enter any animal");
            string animal = Console.ReadLine();
            switch (animal)
            {
                case "one":
                    if(animal == "dog")
                    {
                        Console.WriteLine("The animal is a dog");
                    }
                    break;
                case "two":
                    if(animal == "cat")
                    {
                        Console.WriteLine("The animal is a cat");
                    }
                    break;
                case "three":
                    if(animal == "hamster")
                    {
                        Console.WriteLine("The animal is a hamster");
                    }
                    break;
            }
        }
    }
}
