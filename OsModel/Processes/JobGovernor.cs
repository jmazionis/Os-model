using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsModel.Resources;
using OsModel.VirtualMachineEmulator;

namespace OsModel.Processes
{
    public class JobGovernor : Process
    {
        StartJobGovernor startJobGovernor;

        public JobGovernor(int priority, State state, Process parentProcess, string id)
            : base(priority, state, parentProcess, id)
        {
        }

        public override void Execute()
        {
            switch (Checkpoint)
            {
                case 1:
                    startJobGovernor = (StartJobGovernor) RequestResource("StartJobGovernor");
                    if (startJobGovernor == null)
                    {
                        break;
                    }
                    Checkpoint++;
                    goto case 2;
                case 2:
                    Core.CreateProcess(new VirtualMachine(10, State.Blocked, startJobGovernor.VirtualMemory, this, "VirtualMachine1"));
                    Checkpoint++;
                    break;
            }
        }
    }
}
