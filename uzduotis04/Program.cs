using System;

namespace uzduotis04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Susikurkite reikiamus kintamuosius užduočiai atlikti. Į ekraną išveskite: Automobilio {markė} {modelis} ({metai} m.) rida - {rida} km.
             * Tarp {} nurodyti reikiami kintamieji, šiose vietose jų reikšmės turi būti įstatytos.*/
            string marke = "Hyundai";
            string modelis = "Ioniq";
            int metai = 2020;
            double rida = 33476;
            Console.WriteLine($"Automobilio {marke} {modelis} ({metai} m.) rida - {rida} km.");
        }
    }
}
