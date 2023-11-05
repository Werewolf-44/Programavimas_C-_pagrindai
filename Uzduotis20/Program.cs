using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Įveskite iš konsolės 2 skaičius (stataus trikampio statinių ilgius).
             * Suraskite įžambinę ir ją išveskite į ekraną.
             * Tip: Pitagoro teorema teigia, jog stataus trikampio statinių kvadratų suma yra lygi įžambinės kvadratui.
             * Jau žinome, jog Math.Pow(skaicius, laipsnis) – kintamąjį skaičius pakelia laipsniu.  Jei norime ištraukti kvadratinę šaknį, reiktų kelti 0.5 laipsniu.
             * Arba naudoti šaknies funkciją Math.Sqrt(z)
             */
            Console.WriteLine("How long is one side of the triangle?");
            int first_side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How long is another side of the triangle?");
            int second_side = Convert.ToInt32(Console.ReadLine());
            double hypotenuse = Math.Sqrt(Math.Pow(first_side, 2) + Math.Pow(second_side, 2));
            Console.WriteLine("Hypotenuse of the right-angled triangle is: " + Math.Round(hypotenuse, 3));
        }
    }
}
