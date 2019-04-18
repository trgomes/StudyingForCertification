using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace _16_Using_ParallelFor_And_ParallelForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 10, i => {
                Console.WriteLine($"For => {i}");
                Thread.Sleep(1000);
            });

            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i => {
                Console.WriteLine($"FE => {i}");
                Thread.Sleep(1000);
            });

            Console.ReadKey();
        }
    }
}
