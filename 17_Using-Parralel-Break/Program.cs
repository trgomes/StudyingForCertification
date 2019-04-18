using System;
using System.Threading.Tasks;

namespace _17_Using_Parralel_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            ParallelLoopResult result = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) => {

                Console.Write(i + " - ");

                if (i == 500)
                {
                    Console.WriteLine("Breaking loop");
                    loopState.Break();
                }

                return;
            });

            Console.ReadKey();
        }
    }
}
