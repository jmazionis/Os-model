using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsModel.Resources;

namespace OsModel.Processes
{
    public class StartStop : Process
    {
        SupervisorMemory supervisorMemory;
        TaskReader taskReader;

        public StartStop(int priority, State state, Process parentProcess, string id)
            : base(priority, state, parentProcess, id)
        {

        }

        public override void Execute()
        {
            switch (Checkpoint)
            {
                case 1:
                    InitProcesses();
                    InitResources();
                    Init();
                    if (!RequestResource("EndOfOs"))
                    {
                        Checkpoint++;
                        break;
                    }
                    goto case 2;
                case 2:
                    DestroyResources();
                    DestroyProcesses();
                    Core.FinishedWork = true;
                    break;
            }
        }

        private void InitProcesses()
        {
            //Core.CreateProcess(new Interrupt(2, State.Blocked, this, "Interrupt"));
            taskReader = new TaskReader(3, State.Blocked, this, "TaskReader");
            Core.CreateProcess(taskReader);
            Core.CreateProcess(new TaskParser(4, State.Blocked, this, "TaskParser"));
            //Core.CreateProcess(new Loader(5, State.Blocked, this, "Loader"));
            //Core.CreateProcess(new ReadIn(6, State.Blocked, this, "ReadIn"));
            //Core.CreateProcess(new MainProc(7, State.Blocked, this, "MainProc"));
            //Core.CreateProcess(new WriteOut(8, State.Blocked, this, "WriteOut"));
        }

        private void InitResources()
        {
            //CreateResource(new Memory(this, Resources.State.Free, "Memory"));
            CreateResource(new TaskInput(this, Resources.State.Free, 
                                         "TaskInput", new Queue<string>(new List<string> { "Tasks/Fibonacci.txt" }), 
                                         new List<string> { "TaskReader" }));
           // CreateResource(new EndOfOs(this, Resources.State.Occupied, "EndOfOs", new List<string> { "StartStop" }))
            supervisorMemory = new SupervisorMemory(this, Resources.State.Free, "SupervisorMemory", new List<string> { "TaskReader" });
            CreateResource(supervisorMemory);
        }

        private void Init()
        {
            taskReader.BindSupervisorMemory(supervisorMemory);
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
