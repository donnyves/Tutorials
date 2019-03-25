using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Animal
    {
        //static modifiers are shared through all instances of a class 
        //Properties default to the private accessor/scope/protection level.
        public static int Count = 0;//static will allow the Count be shared by all the classes

        public string name;
        public int age;
        public float happiness;

        //Class Methods
        public void Print()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Happiness" + happiness);
        }

        //Class Constructor
        public Animal()
        {
            name = "Spotty";
            age = 6;
            happiness = 0.5f;

            Count++;
        }
        public Animal(string name, int age, float happiness)
        {
            this.name = name;
            this.age = age;
            this.happiness= happiness ;
        }                     
    }
    class ProgramClasses
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal();
            dog.Print();
            Console.WriteLine();
            Animal.Count += 1;

            Animal cat = new Animal("Mr. Beans", 10, 0.8f);
            cat.Print();
            Console.WriteLine();
            Console.WriteLine($"Number of Animals: {Animal .Count}");

            Console.ReadLine();
        }
    }
}
