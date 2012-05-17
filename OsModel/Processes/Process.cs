using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ookii;

namespace OsModel.Processes
{
    public enum State { Blocked, Ready, Active }

    public class Process
    {
        public int Priority { get; set; }

        public Process(int priority)
        {
            this.Priority = priority;
        }
    }
}
