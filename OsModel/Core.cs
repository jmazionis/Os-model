using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ookii.Collections.Generic;
using OsModel.Processes;
using OsModel.Comparers;
using OsModel.Resources;

namespace OsModel
{
    public static class Core
    {
        public static List<Process> ProcessList;
        public static PriorityQueue<Process> ReadyProcessQueue;
        public static List<Resource> ResourcesList;

        static Core()
        {
            ProcessList = new List<Process>();
            ReadyProcessQueue = new PriorityQueue<Process>(new ProcessComparer());
            ResourcesList = new List<Resource>();
        }

        public static void StartOperatingSystem()
        {
            CreateProcess(new StartStop(1, Processes.State.Active, null, "StartStop"));
            Planner.Start();
        }

        public static void DeleteResource(Resource resource)
        {
            resource.Creator.CreatedResources.Remove(resource);
            foreach (var process in resource.WaitingProcesses)
            {
                process.State = Processes.State.Ready;
            }
            ResourcesList.Remove(resource);
        }

        public static void CreateProcess(Process process)
        {
            ProcessList.Add(process);
            if (process.State == Processes.State.Ready || process.State == Processes.State.Active)
            {
                ReadyProcessQueue.Enqueue(process);
            }
        }

        public static void DeleteProcess(Process process)
        {
            process.Delete();
            //TODO: delete from ReadyProcessQueue
        }
    }
}
