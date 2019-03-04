using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lab_24_tasks
{
    class Program
    {
        static void Main(string[] args)
        {

            // it's possible to let tasks finish randomly
            // or we can batch them and wait for a batch to complete
            var task01 = Task.Run( ()=> {
                Console.WriteLine("Task01 running");
                Thread.Sleep(5000);
            });
            Console.WriteLine("Initial task : waiting");
            task01.Wait();
            Console.WriteLine("Initial task : All done");

            // create batch job of 10 tasks
            // create an array of tasks
            // wait for all to complete or just first to complete
            // waitany  waitall
            Task[] FiveTasks = new Task[5];
            FiveTasks[0] = Task.Run(() => { Console.WriteLine("Task00 running");
                Thread.Sleep(1000);
            });
            FiveTasks[1] = Task.Run(() => { Console.WriteLine("Task01 running");
                Thread.Sleep(2000);
            });
            FiveTasks[2] = Task.Run(() => { Console.WriteLine("Task02 running");
                Thread.Sleep(6000);
            });
            FiveTasks[3] = Task.Run(() => { Console.WriteLine("Task03 running");
                Thread.Sleep(5000);
            });
            FiveTasks[4] = Task.Run(() => { Console.WriteLine("Task04 running");
                Thread.Sleep(4000);
            });
            Task.WaitAny(FiveTasks);
            Console.WriteLine("first task done");
            Task.WaitAll(FiveTasks);
            Console.WriteLine("Done");   


        }
    }
}
