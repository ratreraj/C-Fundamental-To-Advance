using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine("Welcome to multithreading concept");
            //Thread t = Thread.CurrentThread;
            //t.Name = "Test";
            //Console.WriteLine($"{t.Name}");

            Thread T1 = new Thread(Method1) { 
            
                Name="Thread1"
            };
            Thread T2 = new Thread(Method2) {
                Name="Thread2"
            };
            Thread T3 = new Thread(Method3)
            { Name = "Thread3" };
            //Method1();
            //Method2();
            //Method3();
            T1.Start();
            T2.Start();
            T3.Start();

            Console.ReadLine();

        }

        static void Method1()
        {
            Console.WriteLine("Method1 Started using " + Thread.CurrentThread.Name);
            for (int i = 1; i<=5; i++)
            {
                Console.WriteLine($"Method 1 called - {i}");

            }

        }
        static void Method2()
        {
            Console.WriteLine("Method2 Started using " + Thread.CurrentThread.Name);
            for (int i = 1; i<=5; i++)
            {
                Console.WriteLine($"Method 2 called - {i}");

                Console.WriteLine("Performing the Database Operation Started"+ Thread.CurrentThread.Name);
                //Sleep for 10 seconds
                Thread.Sleep(10000);
                Console.WriteLine("Performing the Database Operation Completed"+ Thread.CurrentThread.Name);
            }

        }

        static void Method3()
        {
            Console.WriteLine("Method3 Started using " + Thread.CurrentThread.Name);
            for (int i = 1; i<=5; i++)
            {
                Console.WriteLine($"Method 3 called - {i}");
            }

        }
    }
}
