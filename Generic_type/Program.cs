using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var k = "string1";
            var l = k.Length;

            dynamic op = "string1";
            dynamic sp = op.Length;

            GenericArray<int>(1,2).ToList().ForEach(c => System.Console.WriteLine(c.ToString()));
            GenericArray<string>("a","b").ToList().ForEach(c => System.Console.WriteLine(c.ToString()));;
            ShowArray(1, "3").ToList().ForEach(c => System.Console.WriteLine(c.ToString()));
            ShowArray("1", "3").ToList().ForEach(c => System.Console.WriteLine(c.ToString()));
            ShowArray(true, false).ToList().ForEach(c => System.Console.WriteLine(c.ToString()));
        }

        public static dynamic[] ShowArray(dynamic first, dynamic last)
        {
            return new dynamic[] { first, last };
        }

        public static T[]  GenericArray<T>(T first, T last)
        {
            return new T[] { first, last };
        }
    }
}
