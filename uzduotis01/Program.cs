using System;

namespace uzduotis01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parašykite programą, kuri išvestų žodį “Labas” ir jūsų vardą toje pačioje eilutėje. //
            Console.WriteLine($"Labas, Ernestai!");

            /* Susikurkite kintamąjį žmogaus amžiui nusakyti, išveskite į ekraną tekstą su šiuo amžiumi: “Įvestas amžius: {amžius}”. 
             * Tarp {} nurodytas kintamasis, kurio reikšmė toje vietoje turi būti įstatyta.*/
            int amzius = 29;
            Console.WriteLine($"Įvestas amžius: {amzius}");

            /* Susikurkite skaičiaus kintamąjį, kurį išveskite penkis kartus toje pačioje eilutėje be tarpų tarp šių skaičių 
             * (skaičius - 25, išvedimas - 2525252525).*/
            int number = 25;
            Console.Write(number);
            Console.Write(number);
            Console.Write(number);
            Console.Write(number);
            Console.WriteLine(number);

            /* Susikurkite skaičiaus kintamąjį, kurį išveskite penkis kartus toje pačioje eilutėje su tarpais tarp šių skaičių 
             * (skaičius - 25, rezultatas - 25 25 25 25 25).*/
            Console.WriteLine(number + " " + number + " " + number + " " + number + " " + number);
        }
    }
}
