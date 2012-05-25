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

        public Resource(Process creator, State state, string id)
        {
            WaitingProcesses = new PriorityQueue<Process>(new ProcessComparer());
            Creator = creator;
            State = state;
            Id = id;
        }

        public void Free()
        {
            State = Resources.State.Free;
        }
    }
}
