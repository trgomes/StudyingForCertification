using System;
using System.Threading;

namespace _2_Using_A_Background_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            // Se você executar esta aplicação com IsBackground como true, a aplicação sai imediatamente
            // Se você executar esta aplicação com IsBackground como false, a aplicação imprime a mensagem 10 vezes
            t.IsBackground = false;
            t.Start();
        }

        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"ThreadProc: {i}");
                Thread.Sleep(1000);
            }
        }
    }
}
