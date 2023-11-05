using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parašyti For ciklą, kuris suskaičiuotų, kiek skaičių intervale[0 – 1000) dalinasi iš 16.
            int counter = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 16 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);

            /* Liepkite vartotojui įvesti teigiamą skaičių. While ciklo viduje skaičių kelkite vis
             * didesniu laipsniu ir jį išveskite į ekraną, kol skaičius netaps didesnis už 1500.
             */
            Console.WriteLine("Please provide any positive number");
            int number = Convert.ToInt32(Console.ReadLine());
            int power = 1;
            int result = number;
            while(result <= 1500)
            {
                Console.WriteLine(result);
                power++;
                result = (int)Math.Pow(number, power);
            }
        }
    }
}
