using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsModel.Processes;

namespace OsModel.Resources
{
    public class TaskInSupervisorMemory : Resource
    {
        string[] Memory;

        public TaskInSupervisorMemory(Process creator, State state, string id, string[] memory)
            : base(creator, state, id)
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
