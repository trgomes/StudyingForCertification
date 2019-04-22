using System;
using System.Linq;

namespace _25_Making_A_Parallel_Query_Sequential
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);
            var parallelResult = numbers.AsParallel().AsOrdered()
                .Where(i => i % 2 == 0).AsSequential();

            foreach (int i in parallelResult.Take(5)) // Somente os 5 prmeiros do array
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
