
using System;
using System.Threading;

namespace SemaThread

{
    class Program
    {
        static void Main(string[] args)
        {
           
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            Console.WriteLine(mainThread.Name + " is starting!");

           
            Thread thread1 = new Thread(() => CountDown("Timer #1"));
            Thread thread2 = new Thread(() => CountUp("Timer #2"));

            thread1.Start();
            thread2.Start();

            
            thread1.Join();
            thread2.Join();

            Console.WriteLine(mainThread.Name + " is complete!");
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }

        public static void CountDown(string name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(name + " : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine(name + " is complete!");
        }

        public static void CountUp(string name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(name + " : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine(name + " is complete!");
        }
    }
}

