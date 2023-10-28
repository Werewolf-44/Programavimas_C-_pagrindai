using System;
using System.CodeDom.Compiler;
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
            /* Nusikopijuokite praeitos užduoties kodą į naują projektą.
             * Base klasėje parašykite virtualų išvedimo metodą.
             * Paveldinčioje klasėje pakeiskite esamą išvedimo metodą, kad jis override‘intu base klasės virtual metodą.
             * Base klasėje sukurkite private const kintamąjį, kadangi jo negalima pasiekti  už klasės ribų – base klasėje sukurkite public metodą, kuris išspausdina 
             * private const kintamąjį. Panaudoję šį metodą, iškvieskite jį paveldinčios klasės išvedimo metode.
             */
            Dog dog = new Dog("Rocky", 10, "Pitbul");
            dog.Virtual_Information();
        }
    }

    class Animal
    {
        protected string Name;
        protected int Age;

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void Virtual_Information()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }

        private const string collar_color = "Blue";

        public void Collar()
        {
            Console.WriteLine(collar_color);
        }
    }
    class Dog : Animal
    {
        public string Breed;
        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }
        public override void Virtual_Information()
        {
            base.Virtual_Information();
            Console.WriteLine($"Breed: {Breed}");
            Console.Write("The collar color is: ");
            Collar();
        }
    }
}