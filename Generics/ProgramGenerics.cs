using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class ProgramGenerics
    {
        static void Main(string[] args)
        {
            KeyValuePair<string, int> meaning = new KeyValuePair<string, int>("Life", 42);//"Life" and  42 are passed in from constructor
                meaning.Print();

            Console.ReadKey();
        }
    }
    //This is a KeyValuePair
    //KeyValuePair helps you pair two pieces of data
    class KeyValuePair<TKey,TValue>//
    {
        public TKey key;//fields
        public TValue value;

        public KeyValuePair (TKey _key, TValue _value)//constructor
        {
            key = _key;
            value = _value;
        }

        public void Print()
        {
            Console.WriteLine("Using a Key Value Pair");
            Console.WriteLine($"Key: {key.ToString ()}");//the field is convered to a string using ToString
            Console.WriteLine($"Value: {value.ToString ()}");
            Console.WriteLine();

            //This is a Dictionary
            Console.WriteLine("Using a Dictionary");
            Dictionary<string, int> prices = new Dictionary<string, int>(5);
            prices.Add("Watermelon", 5);
            prices.Add("Car", 100000);
            Console.WriteLine( prices ["Watermelon"]);//prints out 5 , which the value
            Console.WriteLine();

            Console.WriteLine("Using a Generic that compares 2 numbers or strings");
            Console.WriteLine(Utility .CompareValue(10,10));//true
            Console.WriteLine(Utility.CompareValue(10, 4));//false
            Console.WriteLine(Utility.CompareValue("hi", "hi"));//true
            Console.WriteLine(Utility.CompareValue("ho", 10));//false

            Console.WriteLine();
            Console.WriteLine("Compare types using Generics");
            Console.WriteLine(Utility .CompareTypes("hello", "hello"));//true
            Console.WriteLine(Utility.CompareTypes("hello", "world"));//true
            Console.WriteLine(Utility.CompareTypes("hello", 10));//false
            Console.WriteLine(Utility.CompareTypes(11, 10));//true
        }

        //This is a GENERIC class
        class Utility
        {
            public static bool CompareValue <T01,T02>(T01 value01, T02 value02 )//Comparing values
            {
                return value01.Equals(value02);
            }

            public static bool CompareTypes<T01, T02>(T01 value01, T02 value02)//Comparing types
            {
                return typeof(T01).Equals(typeof(T02));
            }
        }
    }
}
