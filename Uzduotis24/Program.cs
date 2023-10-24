using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Paklausti vartotojo, kiek duomenų nori įvesti į masyvą. Pagal tai sukursime tokio dydžio masyvą
             * Iš konsolės įvesti duomenis į masyvą
             * Surasti 2 sumas:
             * Suma1 – kai masyvo elementas yra lyginis skaičius
             * Suma2 – kai masyvo indeksas nėra lyginis skaičius
             */
            Console.WriteLine("How many data entries do you want to make add to the array?");
            double entries = Convert.ToDouble(Console.ReadLine());
            double[] arr = new double[(int)entries];
            int index = 0;
            while (index < entries)
            {
                Console.WriteLine("Please enter a number:");
                arr[index] = Convert.ToDouble(Console.ReadLine());
                index++;
            }
            double sum_first = 0;
            double sum_second = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum_first += arr[i];
                }
                if (i % 2 != 0)
                {
                    sum_second += arr[i];
                }
            }
            Console.WriteLine($"Total, when counting only even array entries: {sum_first}");
            Console.WriteLine($"Total, when counting only odd array indexes: {sum_second}");

        }
    }
}
