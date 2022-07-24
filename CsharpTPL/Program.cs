using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate();
            Console.ReadLine();
        }

        public static void Calculate()
        {
            // var tsk1 = new Task(() =>
            // {
            //     Method4();
            // });

            // var tsk2 = new Task(() =>
            // {
            //     Method5();
            // });
            // var tsk3 = new Task(() =>
            // {
            //     Method6();
            // });

            // tsk1.Start();
            // tsk1.Wait();
            // tsk2.Start();
            // tsk2.Wait();
            // tsk3.Start();
            // tsk3.Wait();



            var tsk1 = Task.Run(() =>
                {
                      System.Console.WriteLine("done 1");
                  return  Method1();
                });
              
            var tsk2 = Task.Run(() =>
            {
                // System.Console.WriteLine("Task 2 started");

            return  Method2();
            });
            var tsk3 = Task.Run(() =>

            {
                // Thread.Sleep(7000);
                // System.Console.WriteLine("Task 3 started");
           return   Method3();
            });
            Task.WaitAll(tsk1,tsk2,tsk3);
            var result = tsk1.GetAwaiter().GetResult();
            var result2 = tsk2.GetAwaiter().GetResult();
        
            


            System.Console.WriteLine(result);
              System.Console.WriteLine(result2);


        }

        public static int Method1()
        {
            System.Console.WriteLine("Method 1");
            return 100;
        }

        public static int Method2()
        {
            System.Console.WriteLine("Method 2");
            return 200;
        }

        public static int Method3()
        {
            System.Console.WriteLine("Method 3");
            return 300;
        }

        public static int Method4()
        {
            Thread.Sleep(7000);
            System.Console.WriteLine("Method 4");
            return 400;
        }

        public static int Method5()
        {
            System.Console.WriteLine("Method 5");
            return 500;
        }

        public static int Method6()
        {
            System.Console.WriteLine("Method 6");
            return 600;
        }
    }
}
