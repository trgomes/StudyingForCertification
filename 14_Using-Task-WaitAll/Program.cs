using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace _14_Using_Task_WaitAll
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>(3);

            tasks.Add(Task.Run(() => {
                Thread.Sleep(1000);
                Console.WriteLine('1');
                return 1;
            }));

            tasks.Add(Task.Run(() => {
                Thread.Sleep(1000);
                Console.WriteLine('2');
                return 2;
            }));

            tasks.Add(Task.Run(() => {
                Thread.Sleep(1000);
                Console.WriteLine('3');
                return 3;
            }));

            //Espera as tasks, caso seja lançada uma exceção, cancela a execução
            //Task.Wait(tasks.ToArray());

            //Executa todas as tasks independente do lançamento de exceção. As exceções são acumuladas como AgragationException
            Task.WaitAll(tasks.ToArray());

            Console.ReadKey();
        }
    }
}
