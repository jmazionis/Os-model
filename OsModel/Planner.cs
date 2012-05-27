using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ookii.Collections.Generic;
using OsModel.Processes;
using OsModel.Comparers;

namespace OsModel
{
    public delegate void OSEventHandler();

    public static class Planner
    {
        public static Process CurrentProcess;
        public static int GlobalTimer;
        public static event OSEventHandler ProcessExecuted;

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
                try
                {
                    if (resource.State == Resources.State.Free)
                    {
                        var process = resource.WaitingProcesses.Dequeue();
                        process.State = State.Ready;
                        resource.State = Resources.State.Occupied;
                    }
                }
                catch (Exception)
                {
                    
                }         
            }
        }

        public static void Start()
        {
            while(!Core.FinishedWork)
            {
                PickWaitingProcess();
                DistributeResources();
                CurrentProcess.Execute();
                ProcessExecuted();
            }
        }
    }
}
