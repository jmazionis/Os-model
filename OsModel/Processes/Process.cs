using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ookii;

namespace OsModel.Processes
{
    public enum State { Blocked, Ready, Active }
    public enum Mode { User, Supervisor }

    public class Process
    {
        private List<Resources.Resource> resources = new List<Resources.Resource>();
        
        public int Priority { get; set; }
        public string Name {  get; private set; }
        public Process Parent { get; private set; }

        public Process(int priority, string name, Process parent)
        {
            this.Priority = priority;
            this.Name = name;
            this.Parent = parent;
        }
    }
}
