using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Sukurkite bazinę klasę Gyvunas su protected kintamaisiais ir paveldinčia klasę Gyvate.
             * Paveldinčioje klasėje turi būti metodas, kuris išveda visus klasės kintamuosius į ekraną.
             * Bazinės klasės konstruktorių panaudokite paveldinčioje klasėje.
             * Išveskite paveldinčios klasės kintamuosius į ekraną.
             */
            Dog dog = new Dog("Rocky", 10, "Pitbul");
            dog.Information();
        }
    }

    class Animal
    {
        protected string Name { get; set; }
        protected int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Dog : Animal
    {
        public string Breed { get; }
        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }
        public void Information()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Breed: {Breed}");
        }
    }
}
