using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class ProgramWhile
    {
        static void Main(string[] args)
        {
            Random numberGen = new Random();

            int numberOfAttempts = 0;
            int attempt = 0;

            while (attempt != 6)
            {
                attempt = numberGen.Next(1, 7);
                Console.WriteLine($"Donnyves rolled a {attempt}.");
                numberOfAttempts++;
            }
            Console.WriteLine($"It took Donnyves {numberOfAttempts } times to roll a six.");
            Console.ReadKey();
        }
    }
}
