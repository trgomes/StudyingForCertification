using System;
using System.Threading.Tasks;

namespace _13_Using_A_Task_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<Int32[]> parent = Task.Run( () => {
                var results = new Int32[3];

                TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent, TaskContinuationOptions.ExecuteSynchronously);

                tf.StartNew( () => results[0] = 0);
                tf.StartNew(() => results[1] = 1);
                tf.StartNew(() => results[2] = 2);

                return results;
            });

            var finalTask = parent.ContinueWith( parentTask => {
                foreach (var i in parentTask.Result)
                {
                    Console.WriteLine(i);
                }
            });

            finalTask.Wait();

        }
    }
}
