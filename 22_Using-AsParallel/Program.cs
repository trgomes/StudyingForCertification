using System;
using System.Linq;

namespace _22_Using_AsParallel
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 1000);

            var parallelResult = numbers.AsParallel()
                .Where(i => i % 2 == 0)
                .ToArray();

            foreach (var item in parallelResult)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
