using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti savo vardą ir amžių. Į ekraną išveskite: “Jūsų vardas {vardas}, o amžius {amžius}.”
            Console.WriteLine("Write down your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Write down your age:");
            double age = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Your name is {name} and your age is {age}");

            //Liepkite vartotojui įvesti bet kokį simbolį. Atspausdinkite 3x3 kvadratą iš to simbolio.
            Console.WriteLine("Write down any symbol:");
            var symbol = Console.ReadLine();
            Console.WriteLine(symbol + symbol + symbol);

            //Liepkite vartotojui įvesti bet kokį skaičių. Išveskite į ekraną šio skaičiaus kvadratą.
            Console.WriteLine("Write down any number:");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(number + number);

            //Liepkite vartotojui įvesti tris skaičius. Išveskite visų šių skaičių sumą, nurodant atliekamus veiksmus ir šių skaičių reikšmes ekrane.
            Console.WriteLine("Write down 3 numbers (press Enter after each number):");
            double[] list = new double[3];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Total sum of these three numbers is: " + list[0] + " + " + list[1] + " + " + list[2] + " = " + list.Sum());
        }
    }
}
