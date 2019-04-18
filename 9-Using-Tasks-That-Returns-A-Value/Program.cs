using System;
using System.Threading.Tasks;

namespace _9_Using_Tasks_That_Returns_A_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run( () =>
            {
                return 42;
            }).ContinueWith( (i) =>
            {
                return i.Result * 2;
            });

            var result = t.Result;

            Console.WriteLine(result); //Display 42 * 2;

            Console.ReadKey();
        }
    }
}
