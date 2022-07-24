using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        delegate int del (int a);
          static  del delIGetName;
        static void Main(string[] args)
        {
            delIGetName =(x)=>{
                return x* x;
            };
           System.Console.WriteLine(delIGetName(29)); 
            Func<int, int, int> Kfuc = (x, y) =>
            {
                System.Console.WriteLine("asd");
                return x + 9;
            };

          System.Console.WriteLine(Kfuc(1,4));  
        }
    }
}
