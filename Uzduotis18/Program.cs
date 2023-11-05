using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis18
{
    internal class Program
    {
        private static int loaf_sell_price;

        static void Main(string[] args)
        {
            /* Tikslas: Suskaičiuoti, kiek duonos kepalų kepykla sugebės iškepti per dieną.
             * Patikrinti, ar kepykla spės iškepti visus tos dienos užsakymus, jei ne, suskaičiuoti, kiek kepalų nespės iškepti.
             * Suskaičiuoti, kiek kepykla uždirbs pelno iš visų tą dieną iškeptų duonos kepalų.
             * Iš anksto žinoma informacija:
             * Darbo valandų per dieną -8 val.
             * Vartotojo įvedama informacija:
             * Kiek darbuotojas gali iškepti kepalų per valandą.
             * Kiek darbuotojų turi kepykla.
             * Vieno kepalo savikaina.
             * Vieno kepalo pardavimo kaina.
             * Kiek kepykla turi tą dieną iškepti kepalų(užsakymai).
             */
            int working_hours_a_day = 8;
            Console.WriteLine("Please provide how many loafs can a baker made in a day: ");
            int loafs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please provide how many employees does the bakery have?");
            int employees = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much to make a loaf of bread cost?");
            int loaf_cost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much does a loaf of bread cost?");
            int loaf_sell_price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many orders does the bakery have?");
            int oders = Convert.ToInt32(Console.ReadLine());

            int loafs_per_hour_per_employee = loafs / working_hours_a_day / employees;

            Console.WriteLine("Loafs per hour per employee: " + loafs_per_hour_per_employee);

            int total_loafs_possible = employees * working_hours_a_day * loafs_per_hour_per_employee;

            if (total_loafs_possible >= oders)
            {
                Console.WriteLine("The bakery can fulfill all the orders.");
            }
            else
            {
                int loafs_short = oders - total_loafs_possible;
                Console.WriteLine("The bakery cannot fulfill " + loafs_short + " loafs.");
            }

            int total_cost = total_loafs_possible * loaf_cost;
            int total_revenue = total_loafs_possible * loaf_sell_price;
            int total_profit = total_revenue - total_cost;

            Console.WriteLine("Total profit for the day: " + total_profit);
        }
    }
}
