using System;
using System.Threading.Tasks;

namespace _8_Startig_New_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = Task.Run( () => 
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write('*');
                }
            });

            t.Wait();

            Console.ReadKey();
        }
    }
}
