using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crew
{
    class WorkerManager
    {
        public void Manager()
        {
            var worker_1 = new Worker("Worker", "1", 20, 1);
            var worker_2 = new Worker("Worker", "2", 21, 2);
            var worker_3 = new Worker("Worker", "3", 25, 7);
            var worker_4 = new Worker("Worker", "4", 23, 4);
            var list = new Crew();
            list.Add(worker_1);
            list.Add(worker_2);
            list.Add(worker_3);
            list.Add(worker_4);
            Console.WriteLine("Crew:\n");
            foreach (var worker in list)
            {
                Console.WriteLine($"Name: {worker.Name}\n" +
                                  $"Surname: {worker.Surname}\n" +
                                  $"Age: {worker.Age}\n" +
                                  $"Position: {worker.Position}\n");
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Sort:\n");
            foreach(var workers in list)
            {
                list.Compare(workers, worker_1);
                list.Compare(workers, worker_2);
                list.Compare(workers, worker_3);
                list.Compare(workers, worker_4);
            }
        }
    }
}
