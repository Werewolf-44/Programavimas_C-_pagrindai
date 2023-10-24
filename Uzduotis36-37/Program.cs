using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis36_37
{
    internal class Program
    {
        /*Sukurti klasę Mokinys su kintamaisiais: vardas, pavardė, amžius, klasė ir  pažymių sąrašą, kur saugosime 5 pažymius.
         * Sukurti konstruktorių, kad priskirtų reikšmes.
         * Klasės viduje sukurti metodą, kad išvestų visą informaciją apie mokinį.
         * Susikurti 3 objektus, jiems priskirti reikšmes ir naudojant sukurtą metodą  išvesti kiekvieno mokinio informaciją.
         */
        class Student
        {
            public string name;
            public string surname;
            public int age;
            public int school_year;
            public List<int> grades = new List<int>();

            public Student(string name, string surname, int age, int school_year, List<int> grades)
            {
                this.name = name;
                this.surname = surname;
                this.age = age;
                this.school_year = school_year;
                this.grades = grades;
            }

            public void Information()
            {
                Console.WriteLine($"Information about the student! Meet {name} {surname}, a {age} year old, {school_year} year student with grades: ");
                foreach (int grade in grades)
                {
                    Console.Write(grade + " ");
                }
                Console.WriteLine("\n");
            }

            /* Klasės viduje sukurti void tipo metodą, kuris išvestų į ekraną už, kiek metų  mokinys baigs mokyklą, jei atsakymas 0 – tuomet išvesti 
             * „Mokinys mokyklą  baigs šiais metais“. Iškviesti metodą Main‘o viduje visiems objektams.
             */
            public void FinishSchool()
            {
                int yearsLeft = 12 - school_year;
                if (yearsLeft > 0)
                {
                    Console.Write($"{name} {surname} will finish school in {yearsLeft} years.");
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine($"{name} {surname} will finish school this year.");
                    Console.WriteLine("\n");
                }
            }
         }

        static int CountGradesAboveFour(Student student)
        {
            int count = 0;
            foreach (int grade in student.grades)
            {
                if(grade > 4)
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            List<int> studentOneGrades = new List<int> { 9, 10, 10, 10, 8 };
            Student one = new Student("Ben", "Smith", 9, 3 , studentOneGrades);
            one.Information();
            one.FinishSchool();

            List<int> studentTwoGrades = new List<int> { 5, 9, 9, 10, 6 };
            Student two = new Student("Laura", "Jennings", 7, 1, studentTwoGrades);
            two.Information();
            two.FinishSchool();

            List<int> studentThreeGrades = new List<int> { 7, 10, 7, 9, 7 };
            Student three = new Student("William", "Hearth", 8, 2, studentThreeGrades);
            three.Information();
            three.FinishSchool();

            //Main‘o viduje naudojant Sąrašo komandas Max() ir Min() išvesti į ekraną kiekvieno mokinio geriausią ir blogiausią pažymį.
            Console.WriteLine($"Bens' best grade: {one.grades.Max()}");
            Console.WriteLine($"Bens' worst grade: {one.grades.Min()}");
            Console.WriteLine();

            Console.WriteLine($"Lauras' best grade: {two.grades.Max()}");
            Console.WriteLine($"Lauras' worst grade: {two.grades.Min()}");
            Console.WriteLine();

            Console.WriteLine($"Williams' best grade: {three.grades.Max()}");
            Console.WriteLine($"Williams' worst grade: {three.grades.Min()}");
            Console.WriteLine();

            /*Sukurti int tipo metodą (pagrindinės klasės viduje), kuriam paduosim kintamąjį, kurio tipas yra Mokinys.  
             * Metodas turi apskaičiuoti, kiek yra mokinio pažymių, didesnių už 4. Išvesti šią informaciją apie kiekvieną mokinį
             */
            Console.WriteLine($"Bens' grades above 4: {CountGradesAboveFour(one)}");
            Console.WriteLine($"Lauras' grades above 4: {CountGradesAboveFour(two)}");
            Console.WriteLine($"Williams' grades above 4: {CountGradesAboveFour(three)}");
        }
    }
}

