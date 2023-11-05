using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Susikurti žodžių sąrašą. Rasti trumpiausią ir ilgiausią žodžius, juos išvesti į ekraną, prie kiekvieno pasakant iš kiek raidžių jis yra sudarytas.
             * Tip: string kintamasis iš tiesų yra char masyvas, todėl galite naudoti zodis.Length
             */
            List<string> words = new List<string>();
            Console.WriteLine("Please write down 5 words of your choosing (press enter after each word):");
            for (int i = 0; i < 5; i++)
            {
                string input = Console.ReadLine();
                words.Add(input);
            }
            List<string> sortedbylettercount = words.OrderBy(word => word.Length).ToList();
            Console.WriteLine("The shortest word in the list is " + sortedbylettercount.First() + ". It has " + sortedbylettercount.First().Length + " letters.");
            Console.WriteLine("The longest word in the list is " + sortedbylettercount.Last() + ". It has " + sortedbylettercount.Last().Length + " letters.");
        }
    }
}
