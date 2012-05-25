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
        public static Process CurrentProcess;
        public static int GlobalTimer;

        static Planner()
        {
        }

        private static void PickWaitingProcess()
        {
           CurrentProcess = Core.ReadyProcessQueue.Dequeue();
        }

        private static void DistributeResources()
        {
            foreach (var resource in Core.ResourcesList)
            {
                if (resource.State == Resources.State.Free)
                {
                    var process = resource.WaitingProcesses.Dequeue();
                    process.State = State.Ready;
                    resource.State = Resources.State.Occupied;
                }
            }
        }

        public static void Start()
        {
            while(true)
            {
                PickWaitingProcess();
                CurrentProcess.Execute();
                DistributeResources();
            }
        }
    }
}
