using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwithStatments
{
    class ProgramSwitch
    {
        static void Main(string[] args)
        {
            Start:
            Console.WriteLine();
            Random numberGen = new Random();


            //.Next method returns a non-negative number and set the range in the parameter.
            int num01 = numberGen.Next(1,11);// same as 1-10
            int num02 = numberGen.Next(1, 11);

            Console.WriteLine($"What is {num01} times {num02} ?");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input == num01 * num02)
            {
                int responseIndex = numberGen.Next(1, 4);

                switch (responseIndex)
                {
                    case 1:
                        Console.WriteLine("Great Job!");
                        break;
                    case 2:
                        Console.WriteLine("Spectacular");
                        break;
                    default:
                        Console.WriteLine("Wonderful!!");
                        break;
                }
            }
            else
            {
                int diff = Math.Abs(input  - (num01 * num02));
                if (diff == 1)
                {
                    Console.WriteLine("So close!");
                }
                else if (diff <= 10)
                {
                    Console.WriteLine("You can do better than that!");
                }
                else
                {
                    Console.WriteLine("You are not even close");
                }

            }
            Console.ReadKey();
            goto Start;
        }
    }
}
