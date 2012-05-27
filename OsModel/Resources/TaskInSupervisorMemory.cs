using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsModel.Processes;

namespace OsModel.Resources
{
    public class TaskInSupervisorMemory : Resource
    {
        public string[] Memory;

        public TaskInSupervisorMemory(Process creator, State state, string id, string[] memory, List<string> processList)
            : base(creator, state, id, processList)
        {
            Memory = memory;
        }

        public string this[int i]
        {
            get
            {
                return Memory[i];
            }

            set
            {
                Memory[i] = value;
            }
        }
    }
}
