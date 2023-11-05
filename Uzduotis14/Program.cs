using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Į ekraną išveskite kelis sunumeruotus pasirinkimus
             * 1 - stacionarus kompiuteris
             * 2 - nešiojamas kompiuteris
             * 3 - planšetė
             */
            Console.WriteLine("Please choose any of the following:");
            Console.WriteLine("1 - desktop");
            Console.WriteLine("2 - laptop");
            Console.WriteLine("3 - tablet");

            // Liepkite vartotojui įvesti pasirinkimo numerį.
            Console.WriteLine("Write down you choice and press enter:");
            int number = Convert.ToInt32(Console.ReadLine());

            /* Pagal įvestą numerį išveskite atitinkamą tekstą. Pvz:
             * nešiojamuoju kompiuteriu galite naudotis visur
             * stacionariu kompiuteriu galite naudotis tik namuose arba darbo vietoje
             * planšete galite naudotis visur
             */
            switch (number)
            {
                case 1:
                    Console.WriteLine("You can use a desktop only at home or at work");
                    break;
                case 2:
                    Console.WriteLine("You can use a laptop anywhere");
                    break;
                case 3:
                    Console.WriteLine("You can use a table anywhere");
                    break;
                default: Console.WriteLine("Your choice is not on the list");
                    break;
            }

             // Neradus tinkamo varianto išvesti, kad tokio pasirinkimo nėra.

        }
    }
}
