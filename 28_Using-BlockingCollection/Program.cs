using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace _28_Using_BlockingCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<string> col = new BlockingCollection<string>();

            Task read = Task.Run(() => {
                while (true)
                {
                    Console.WriteLine(col.Take());
                }
            });

            Task write = Task.Run(() => {
                while (true)
                {
                    string s = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(s)) break;
                    col.Add(s);
                }
            });

            write.Wait();

            Console.ReadKey();
        }
    }
}
