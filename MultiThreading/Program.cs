using System;
using System.Threading;

namespace MultiThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //child thread
            Thread T1 = new Thread(Test1);
            Thread T2 = new Thread(Test2);
            Thread T3 = new Thread(Test3);
            T1.Start();
            T2.Start();
            T3.Start();
            Console.WriteLine("Main Thread Exiting");
            Console.ReadLine();
        }

        public static void Test1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test1 : " + i);
            }
            Console.WriteLine("Thread1 Exiting");
        }
        public static void Test2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test2 : " + i);
                if (i == 50)
                {
                    Console.WriteLine("Main Thread going to sleep");
                    Thread.Sleep(5000); // 5 sec
                    Console.WriteLine("Main Thread weakup");
                }
            }
            Console.WriteLine("Thread2 Exiting");
        }
        public static void Test3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test3 : " + i);
            }
            Console.WriteLine("Thread3 Exiting");
        }
    }
}
