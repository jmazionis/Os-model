using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsModel.Processes;
using Ookii.Collections.Generic;
using OsModel.Comparers;


namespace OsModel.Resources
{
    public enum State { Occupied, Free }

    public abstract class Resource
    {
        public string Id { get; set; }
        public Process Creator { get; set; }
        public PriorityQueue<Process> WaitingProcesses { get; set; }
        public State State { get; set; }

        public Resource(Process creator, State state, string id, List<string> processList)
        {
            WaitingProcesses = new PriorityQueue<Process>(new ProcessComparer());
            Creator = creator;
            State = state;
            Id = id;
            InitWaitingProcessesList(processList);
        }

        protected void InitWaitingProcessesList(List<string> processList)
        {
            foreach (var processId in processList)
            {
                var process = Core.ProcessList.SingleOrDefault(p => p.Id == processId);
                WaitingProcesses.Enqueue(process);
            }
        }

        public void Free()
        {
            State = Resources.State.Free;
        }
    }
}
