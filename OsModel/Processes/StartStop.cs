using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsModel.Resources;

namespace OsModel.Processes
{
    public class StartStop : Process
    {
        public StartStop(int priority, State state, Process parentProcess, string id)
            :base(priority, state, parentProcess, id)
        {

        }

        public override void Execute()
        {
            switch (Checkpoint)
            {
                case 1:
                    InitResources();
                    InitProcesses();
                    RequestResource("Memory"); //TODO: switch to EndOfOS or something
                    Checkpoint++;
                    break;
                case 2:
                    DestroyResources();
                    DestroyProcesses();
                    break;
            }
        }

        private void InitProcesses()
        {
            Core.CreateProcess(new Interrupt(2, State.Blocked, this, "Interrupt"));
            Core.CreateProcess(new TaskReader(3, State.Blocked, this, "TaskReader"));
            Core.CreateProcess(new TaskParser(4, State.Blocked, this, "TaskParser"));
            Core.CreateProcess(new Loader(5, State.Blocked, this, "Loader"));
            Core.CreateProcess(new ReadIn(6, State.Blocked, this, "ReadIn"));
            Core.CreateProcess(new MainProc(7, State.Blocked, this, "MainProc"));
            Core.CreateProcess(new WriteOut(8, State.Blocked, this, "WriteOut"));
        }

        private void InitResources()
        {
            CreateResource(new Memory(this, Resources.State.Free, "Memory"));
        }

        private void DestroyResources()
        {
            Core.ResourcesList.Clear();
        }

        private void DestroyProcesses()
        {
            Core.ProcessList.Clear();
        }
    }
}
