using System;
using System.Linq;

namespace _26_Using_ForAll
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);

            var parallelResults = numbers.AsParallel()
                .Where(i => i % 2 == 0);

            parallelResults.ForAll(e => Console.WriteLine(e));

            Console.ReadKey();
        }
    }
}
