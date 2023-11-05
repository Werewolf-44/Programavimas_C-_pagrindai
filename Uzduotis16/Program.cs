using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Raskite visų skaičių nuo 1 iki 100 sumą.
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            // Raskite visų lyginių skaičių nuo 20 iki 40 sumą.
            int sum_even = 0;
            for (int i = 20; i < 40; i++)
            {
                if (i % 2 == 0)
                {
                    sum_even += i;
                }
            }
            Console.WriteLine(sum_even);

            // Raskite visų nelyginių skaičių nuo 30 iki 60 sumą.
            int sum_odd = 0;
            for (int i = 30; i < 60; i++)
            {
                if ((i % 2) != 0)
                {
                    sum_odd += i;
                }
            }
            Console.WriteLine(sum_odd);

            /* Rasti visų skaičių, žemesnių už 1000 ir didesnių už 0 bei kurie dalinasi iš 3 arba
             * 5, sumą.
             * Pavyzdys:
             * Visi skaičiai mažesni už 10 ir kurie dalinasi iš 3 arba 5 yra: 3, 5, 6, 9.
             * Šių skaičių suma yra 23.
             * Turite gauti 233168 atsakymą.
             */
            int total_sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    total_sum += i;
                }
            }
            Console.WriteLine(total_sum);
        }
    }
}
