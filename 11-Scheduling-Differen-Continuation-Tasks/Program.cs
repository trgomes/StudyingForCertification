using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Scheduling_Differen_Continuation_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run( () =>
            {
                return 42;
            });

            t.ContinueWith( (i) => {
                Console.WriteLine("Canceled");
            }, TaskContinuationOptions.OnlyOnCanceled);

            t.ContinueWith( (i) => {
                Console.WriteLine("Faulted");
            }, TaskContinuationOptions.OnlyOnFaulted);

            var completTask = t.ContinueWith( (i) => {
                Console.WriteLine("Completed");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            completTask.Wait();

            Console.ReadKey();
        }
    }
}
