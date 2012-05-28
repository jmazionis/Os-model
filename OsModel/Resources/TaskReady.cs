using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsModel.Processes;
using OsModel.VirtualMachineEmulator;

namespace OsModel.Resources
{
    public class TaskReady : Resource
    {
        public Memory VirtualMemory { get; set; }

        public TaskReady(Process creator, State state, Memory virtualMemory, string id, List<string> processList)
            : base(creator, state, id, processList)
        {
            VirtualMemory = virtualMemory;
        }
    }
}
