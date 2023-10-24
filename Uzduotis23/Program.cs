using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Susikurkite kintamąjį, kuris pasakytų kiek automobilis vidutiniškai sunaudoja  degalų 100 – ui km. Susikurkite masyvą, kuriame saugotumėte skirtingose
             * kelionėse nuvažiuotų kilometrų rodmenis. 
             * Raskite:
             * trumpiausią kelionę;
             * ilgiausią kelionę;
             * kiek kuro sąnaudų sunaudojo automobilis (skaičiavimui reikės rasti visus  nuvažiuotus km).
             */
            double fuel_cons = 6.5;
            int[] trips = { 120, 111, 135, 84, 96, 156 };
            int shortest_trip = trips[0];
            foreach(int trip in trips)
            {
                if(trip < shortest_trip)
                {
                    shortest_trip = trip;
                }
            }
            int longest_trip = trips[0];
            foreach (int trip in trips)
            {
                if(trip > longest_trip)
                {
                    longest_trip = trip;
                }
            }
            int total_km = 0;
            foreach(int trip in trips)
            {
                total_km += trip;
            }
            double total_fuel_cons = total_km * fuel_cons / 100;
            Console.WriteLine($"Shortest trip: {shortest_trip} km");
            Console.WriteLine($"Longest trip: {longest_trip} km");
            Console.WriteLine($"Total km: {total_km} km");
            Console.WriteLine($"Total fuel consumption: {total_fuel_cons} liters");
        }
    }
}
