using System;
using System.Threading;

namespace _4_Stopping_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stopped = false;

            Thread t = new Thread( new ThreadStart( () => 
            {
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            }));

            t.Start();
            Console.WriteLine("Pressione alguma tecla para sair");
            Console.ReadKey();

            stopped = true;
            t.Join();
        }

        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.Write($"ThreadProc: {i}");
            }
        }

    }

}
