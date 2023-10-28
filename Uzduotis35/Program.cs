using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Sukurti void tipo metodą, kuriam paduosim masyvą.
             * Metodas turi išvesti masyvo sumą (sumai skaičiuoti naudoti for ciklą ir .Sum()  funkciją. 
             * Tuomet metodas išves į konsolę 2 tokias pačias sumas suskaičiuotas skirtingais būdais)
             * Išsikviesti metodą.
             */
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8};
            Method(numbers);
        }

        private static void Method(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Sum of the array using for loop: " + sum);
            Console.WriteLine("Sum of the array usin Sum(): " + numbers.Sum());
        }
    }
}
