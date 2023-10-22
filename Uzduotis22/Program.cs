using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Susikurkite savaitės temperatūrų rodmenų masyvą. Raskite:
            /* žemiausią temperatūrą;
             * didžiausią temperatūrą;
             * vidurkį;
             * Temperatūrų, esančių žemiau už vidurkį, kiekį;
             * Temperatūrų, esančių aukščiau už vidurkį, kiekį.
            */
            double[] temperaturos = new double[7];
            temperaturos[0] = 5;
            temperaturos[1] = 8;
            temperaturos[2] = 9;
            temperaturos[3] = 10;
            temperaturos[4] = 15;
            temperaturos[5] = 13;
            temperaturos[6] = 12;
            Console.WriteLine("The lowest temperature is: " + temperaturos.Min());
            Console.WriteLine("The highest temperature is: " + temperaturos.Max());
            Console.WriteLine("The average temperature is: " + temperaturos.Average());
            int counter_high = 0;
            int counter_low = 0;
            for(int i = 0; i < temperaturos.Length; i++)
            {
                if(temperaturos[i] < temperaturos.Average())
                {
                    counter_low++;
                }
                else
                {
                    counter_high++;
                }
            }
            Console.WriteLine("The temperatures that are below average: " + counter_low);
            Console.WriteLine("The temperatures that are above average: " + counter_high);

            /*Susikurkite studentų pažymių masyvą. Raskite:
             * geriausią pažymį;
             * kiek mokinių yra gavę dešimtukus;
             * kiek mokinių yra gavę neigiamą pažymį(žemiau nei 4);
             * pažymių vidurkį.
             */
            int[] pazymiai = {8, 10, 5, 3, 7, 6, 9};
            int counter_desimtukas = 0;
            int counter_neigiamas = 0;
            for (int i = 0; i < pazymiai.Length; i++)
            {
                if (pazymiai[i] == 10)
                {
                    counter_desimtukas++;
                }
                
                if (pazymiai[i] < 4)
                {
                    counter_neigiamas++;
                }
            }
            Console.WriteLine("Number of students that got a 10: " + counter_desimtukas);
            Console.WriteLine("Number of students that got less than 4: " + counter_neigiamas);
            Console.WriteLine("The average of the grades are: " + pazymiai.Average());
        }
    }
}
