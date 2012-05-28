using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsModel.VirtualMachineEmulator;
using OsModel.Processes;

namespace OsModel.Resources
{
    public class StartJobGovernor : Resource
    {
        public Memory VirtualMemory { get; set; }

        public StartJobGovernor(Process creator, State state, Memory virtualMemory, string id, List<string> processList)
            : base(creator, state, id, processList)
        {
            VirtualMemory = virtualMemory;
        }
    }
}
