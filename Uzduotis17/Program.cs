using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Liepkite vartotojui įvesti teigiamą skaičių.Ciklo pagalba šį skaičių išvesti mažėjimo tvarka iki kol jis pasieks 0.Pvz.: 5 4 3 2 1.
             * Kiekvieną kartą išvesti skirtingose eilutėse.
             */
            Console.WriteLine("Please enter any positive number and press enter: ");
            int number_pos = Convert.ToInt32(Console.ReadLine());
            while (number_pos > 0)
            {
                Console.WriteLine(number_pos--);
            }

            /* Liepkite vartotojui įvesti neigiamą skaičių.Ciklo pagalba šį skaičių išvesti didėjimo tvarka iki kol jis pasieks 0, taip pat išvesti 0.Pvz.: -4 - 3 - 2 - 1 0.
             * Kiekvieną kartą išvesti toje pačioje eilutėje, skaičius atskiriant tarpais.
             */
            Console.WriteLine("Please enter any positive number and press enter: ");
            int number_neg = Convert.ToInt32(Console.ReadLine());
            while (number_neg < 0)
            {
                Console.WriteLine(number_neg++);
            }

            /* Padarykite skaičiuotuvą. Kiekvieno ciklo iteracijos metu vartotojas turi suvesti du skaičius.Iš šių skaičių turi būti grąžinami visi sudėties, skirtumo, 
             * sandaugos ir dalmens atsakymai, išvedant kartu ir atliekamus veiksmus.Pvz.:
             * 5 + 4 = 9
             * 5 - 4 = 1
             * …
             * Programa vykdoma tol, kol vartotojas nori atlikinėti skaičiavimus.
             */
            while (true)
            {
                Console.WriteLine("Please write down any number:");
                int number_one = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please write down another number:");
                int number_two = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"{number_one} + {number_two} = " + number_one + number_two);
                Console.WriteLine($"{number_one} - {number_two} = " + (number_one - number_two));
                Console.WriteLine($"{number_one} * {number_two} = " + number_one * number_two);
                Console.WriteLine($"{number_one} / {number_two} = " + number_one / number_two);
            }
        }
    }
}
