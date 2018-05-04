using System;
using System.Threading;

namespace _1_Understanding_Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Main Thread: Do some work.");
                Thread.Sleep(0);
            }

            t.Join();

        }

        public static void ThreadMethod()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Tread proc {i}");
                Thread.Sleep(0);
            }
        }
    }
}
