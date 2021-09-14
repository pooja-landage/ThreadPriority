using System;
using System.Threading;
namespace Pratice25Multithread
{
    class Program
    {
        public static  void childthreadcall1()
        {
            Console.WriteLine("Child thread1 started");
            for(int i =0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Child thread1 finished");
        }

        public static void childthreadcall2()
        {
            Console.WriteLine("Child thread2 started");
            for (int i = 5; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Child thread2 finished");
        }
        static void Main(string[] args)
        {
            ThreadStart child1 = new ThreadStart(childthreadcall1);
            ThreadStart child2 = new ThreadStart(childthreadcall2);
            Console.WriteLine("Mains begins here");
            Thread th1 = new Thread(child1);
            Thread th2 = new Thread(child2);
            th1.Priority = ThreadPriority.Highest;
            th2.Priority = ThreadPriority.Lowest;
            th1.Start();
            th2.Start();
        }
    }
}
