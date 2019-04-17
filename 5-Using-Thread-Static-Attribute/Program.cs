using System;
using System.Threading;

namespace _5_Using_Thread_Static_Attribute
{
    class Program
    {
        [ThreadStatic]
        public static int _field;

        static void Main(string[] args)
        {

            new Thread( () =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine($"Thread A: {_field}");
                }
            }).Start();

            new Thread( () =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine($"Thread B: {_field}");
                }
            }).Start();

            Console.ReadKey();
        }
    }
}
