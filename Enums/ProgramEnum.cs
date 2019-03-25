using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class ProgramEnum
    {
        //enum is a keyword
        enum Breed { Bulldog,Boxer,Chihuahua, Briard};

        class Animal
        {
            //fields
            public string name;
            public int age;
            public float happiness;
        }

        class Dog : Animal
        {

            //You have to give an enum a variable when you declare it.
            public Breed breed;
            //an enum is its own data type, you cannot use string , float, bool,etc., with datatypes.
            public Dog(string name, int age, float happiness, Breed  breed)
            {
                this.name = name;
                this.age = age;
                this.happiness = happiness;

                this.breed = breed;               
            }
            public void Print()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Happiness: " + happiness);
                Console.WriteLine("Breed: "+ breed  );

               
            }


            static void Main(string[] args)
            {
                Dog hulk = new Dog("Hulk", 6, 0.7f,Breed.Chihuahua);
                hulk.Print();
                Console.ReadKey();
            }
        }
    }
}
