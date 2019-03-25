using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class ProgramMethod
    {
        static void Main(string[] args)
        {
            int result = Add(10, 8);
            if (result > 10)
            {
                Console.WriteLine("Result is greater then 10");
        }
            else
            {
                Console.WriteLine("resul is less than to 10");
            }

          

            GreetUser();
            

            Console.ReadLine();
        }
        public static void GreetUser()
        {
            Console.WriteLine("Hello, World!");

        }
     
        public static int Add(int num01, int num02)
        {
            return num01 + num02;
        }
    }
}