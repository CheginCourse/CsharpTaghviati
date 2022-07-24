using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            try
            {
            Console.WriteLine("Enter your number");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your secend number");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            int Num3 = Num1/Num2;
            }
            catch (DivideByZeroException  ex)
            {
                System.Console.WriteLine("divided by zero section "); 
                System.Console.WriteLine(ex.StackTrace);  
                System.Console.WriteLine(ex.Message);
                
            }
            catch (FormatException ex){
                  System.Console.WriteLine("string format "); 
                   System.Console.WriteLine(ex.Message);

            }

            // finally{
            //         count++;
            //         System.Console.WriteLine(count);
            // }
            
       
        }
    }
}