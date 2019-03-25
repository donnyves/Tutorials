using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class ProgramArray
    {
        static void Main(string[] args)
        {
            //int amountOfNumbers = 5;

            ////1.) Printing out an element of an array
            //int[] numbers = new int[5];
            //numbers[0] = 12;
            //numbers[1] = 3;
            //numbers[2] = 5;
            //Console.WriteLine(numbers [1]);

            ////2.) For loops and arrays
            //for (int i = 0; i < numbers.Length ; i++)
            //{
            //    Console.WriteLine(numbers [i]);
            //}
            //Console.ReadLine();

            ////3.) Array with foreach
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            ////4.) String an array
            //string[] names = new string[3] { "Donnyves", "Chuck", "Nancy" };
            //foreach (string  name in names)
            //{
            //    Console.WriteLine(name);
            //}

            ////5). Lists- Used when you do not know the capicity of your list.

            //List<int> numbers = new List<int>();

            //numbers.Add(13);
            //numbers.Add(4);
            //numbers.Add(8);

            //List use .Count instead of .Length
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine(numbers[i] + ",");
            //}

            //Console.WriteLine();
            ////The .RemoveAt() function will remove an element of an array
            //numbers.RemoveAt(1);
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine(numbers[i] + ",");
            //}
            //Console.WriteLine();
            //Console.ReadLine();
            CreateGrid();
        }

        //Multidimensional arrays with a method
        public static void CreateGrid()
        {

            //7). Jagged Arrays (array of an array.
            int[][] jaggedArray =
            {
            new int[] { 3, 5, 7, },
            new int[] { 1, 0, 2, 4, 6 },
            new int[] {1, 2, 3, 4, 5, 6, 7, 8},
            new int[] {4, 5, 6, 7, 8}
            };




            //6.) 2D arrays
            //int width = 20;
            //int hieght = 20;

            //int[,] grid = new int[width, hieght];

            //for (int x = 0; x < width; x++)
            //{
            //    for (int y = 0; y < hieght; y++)
            //    {

            //        grid[x, y] = x + y;//creates a different shapes
            //        //Make sure it's Console.Write to create a "grid shape".
            //        Console.Write(grid[x, y] + " ");
            //    }
            //    Console.WriteLine();
            //}
            Console.ReadLine();
        }

    }
}
