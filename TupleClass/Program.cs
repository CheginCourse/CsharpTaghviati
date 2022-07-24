using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tuple<int,string,int,int,int> tlp = new Tuple<int, string, int,int,int>(12,"asd",34,54,32);
            // System.Console.WriteLine(tlp.Item5);
            var tlp2 = Tuple.Create(231,"332",44);
            // System.Console.WriteLine(tlp2.Item1);
            var result = getName("akbar",3,89);
            System.Console.WriteLine(result.Item1);

        }


        static (int , string , int) getName(string a , int b, int c){
            return (b,a,c);
        }
    }
}
