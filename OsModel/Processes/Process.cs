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

    public abstract class Process
    {
        public static int Id = 0;

        public State State { get; set; }
        public int Priority { get; set; }
        public Registers Registers { get; set; }
        public List<Resource> CreatedResources { get; set; }
        public List<Process> CreatedProcesses { get; set; }
        public List<Process> CurrentProcessList { get; set; }
        public Process ParentProcess { get; set; }

        public Process(int priority, State state, Process parentProcess, List<Process> currentProcessList)
        {
            Id++;
            Priority = priority;
            State = state;
            ParentProcess = parentProcess;
            CreatedProcesses = new List<Process>();
            CreatedResources = new List<Resource>();
            CurrentProcessList = currentProcessList;
        }

        public void Delete()
        {
            CreatedResources.Clear();
            foreach (Process proc in CreatedProcesses)
                proc.Delete();
            CreatedProcesses.Clear();
        }

    }
}
