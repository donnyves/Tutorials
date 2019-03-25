using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brackeys
{ 
    class ProgramPractice
    {

       public static void Reverse(int[] array)
        {
            for (int i = array.Length -1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] A = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 9 };

            Reverse(A);

            Console.ReadLine();
        }
    }
}
