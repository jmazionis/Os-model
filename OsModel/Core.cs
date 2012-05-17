using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ookii.Collections.Generic;
using OsModel.Processes;
using OsModel.Comparers;

namespace OsModel
{
    public static class Core
    {
        public static PriorityQueue<Process> ProcessList;
        public static PriorityQueue<Process> ReadyProcessList;

        static Core()
        {
            ProcessList = new PriorityQueue<Process>(new ProcessComparer());
            ReadyProcessList = new PriorityQueue<Process>(new ProcessComparer());
        }
    }
}
