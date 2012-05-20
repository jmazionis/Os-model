using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ookii;
using Ookii.Collections.Generic;
using OsModel.Comparers;
using OsModel.Resources;

namespace OsModel.Processes
{
    public enum State { Blocked, Ready, Active }

    public class Process
    {
        public static int Id = 0;
        public int Priority { get; set; }
        public State State { get; set; }
        //public List<int> SavedRegisters { get; set; }
        public List<Resource> CreatedResources { get; set; }
        public List<Process> CreatedProcesses { get; set; }
        public Process ParentProcess { get; set; }

        public Process(int priority, State state, Process parentProcess)
        {
            Id++;
            Priority = priority;
            State = state;
            ParentProcess = parentProcess;
            CreatedProcesses = new List<Process>();
            CreatedResources = new List<Resource>();
        }
    }
}
