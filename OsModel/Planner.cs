using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ookii.Collections.Generic;
using OsModel.Processes;
using OsModel.Comparers;

namespace OsModel
{
    public static class Planner
    {
        public static PriorityQueue<Process> processQueue;

        static Planner()
        {
            processQueue = new PriorityQueue<Process>(new ProcessComparer()); //testing purposes only
            processQueue.Enqueue(new Process(5));
            processQueue.Enqueue(new Process(2));
            processQueue.Enqueue(new Process(3));
        }
    }
}
