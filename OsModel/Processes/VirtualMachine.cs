using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsModel.VirtualMachineEmulator;

namespace OsModel.Processes
{
    public class VirtualMachine : Process
    {
        Memory virtualMemory;
        public VirtualMachine(int priority, State state, Memory virtualMemory, Process parentProcess, string id)
            : base(priority, state, parentProcess, id)
        {
            this.virtualMemory = virtualMemory;
        }

        public override void Execute()
        {
            //VirtualMachine.Start() or something;
        }
    }
}
