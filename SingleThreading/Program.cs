using System;
using System.Threading;

namespace SingleThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            Console.WriteLine("Current Execution Thread is " + Thread.CurrentThread.Name);

            Test1();
            Test2();
            Test3();
            Console.ReadLine();
        }

        public static void Test1()
        {
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test1 : "+ i);
            }
        }
        public static void Test2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test2 : " + i);
                if(i == 50)
                {
                    Console.WriteLine("Main Thread going to sleep");
                    Thread.Sleep(5000); // 5 sec
                    Console.WriteLine("Main Thread weakup");
                }
            }
        }
        public static void Test3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test3 : " + i);
            }
        }
    }
}
