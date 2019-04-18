using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace _15_Using_Task_WaitAny
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int>[] tasks = new Task<int>[3];

            tasks[0] = Task.Run(() => { Thread.Sleep(2000); return 1; });
            tasks[1] = Task.Run(() => { Thread.Sleep(2000); return 2; });
            tasks[2] = Task.Run(() => { Thread.Sleep(2000); return 3; });

            while (tasks.Length > 0)
            {
                // Não espera que todas as tarefas sejam concluídas. Uma já é o sufuciente
                int i = Task.WaitAny(tasks);
                Task<int> completedTask = tasks[i];

                Console.WriteLine(completedTask.Result);

                var temp = tasks.ToList();
                temp.RemoveAt(i);
                tasks = temp.ToArray();
            }

            Console.ReadKey();
        }
    }
}