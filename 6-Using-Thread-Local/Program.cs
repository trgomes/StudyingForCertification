using System;
using System.Threading;

namespace _6_Using_Thread_Local
{
    class Program
    {
        public static ThreadLocal<int> _field =
            new ThreadLocal<int>(() =>
            {
                return Thread.CurrentThread.ManagedThreadId;
            });

        static void Main(string[] args)
        {
            new Thread( () => 
            {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine($"Thread A({_field.Value}): {i}");
                }
            }).Start();

            new Thread( () =>
            {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine($"Thread B({_field.Value}): {i}");
                }
            }).Start();

            Console.ReadKey();
        }
    }
}
