using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsModel.Resources;
using OsModel.VirtualMachineEmulator;

namespace OsModel.Processes
{
    public class MainProc : Process
    {
        TaskReady taskReady;
        public MainProc(int priority, State state, Process parentProcess, string id)
            : base(priority, state, parentProcess, id)
        {
        }

        public override void Execute()
        {
            switch (Checkpoint)
            {
                case 1:
                    taskReady = (TaskReady) RequestResource("TaskReady");
                    if (taskReady == null)
                    {
                        break;
                    }
                    Core.CreateProcess(new JobGovernor(9, State.Blocked, this, "JobGovernor1"));
                    
                    Checkpoint++;
                    goto case 2;
                case 2:
                    CreateResource(new StartJobGovernor(this, Resources.State.Free, taskReady.VirtualMemory, "StartJobGovernor",
                                   new List<string> { "JobGovernor1" }));
                    Checkpoint++;
                    State = Processes.State.Blocked;
                    break;
            }
        }
    }
}
