using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ookii;

namespace OsModel.Processes
{
    public enum State { Blocked, Ready, Active }

    public abstract class Process
    {
        private List<Process> childProcessList, currentProcessList;
        private List<Resources.Resource> createdResources, ownedResources;

        public State State { get; set; }
        public int Priority { get; set; }
        public string Name {  get; private set; }
        public Process Parent { get; private set; }
        public int Id { get; set; }

        

        public Process(int priority, string name, Process parent)
        {
            this.Priority = priority;
            this.Name = name;
            this.Parent = parent;
        }

    }
}
