using System;

namespace Crew
{
    class Program
    {
        static void Main(string[] args)
        {
            var workerManager = new WorkerManager();
            workerManager.Manager();
        }
    }
}
