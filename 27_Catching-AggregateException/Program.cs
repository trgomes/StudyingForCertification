using System;
using System.Linq;

namespace _27_Catching_AggregateException
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);

            try
            {
                var parallelResult = numbers.AsParallel()
                    .Where(i => IsEvent(i));

                parallelResult.ForAll(e => Console.WriteLine(e));
            }
            catch (AggregateException e)
            {
                Console.WriteLine($"Excepition {e.InnerExceptions.Count}");
            }

            Console.ReadKey();
        }

        private static bool IsEvent(int i)
        {
            if (i % 10 == 0) throw new ArgumentException("i");

            return i % 2 == 0;
        }
    }
}
