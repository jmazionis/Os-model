using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsModel.Resources;
using System.IO;

namespace OsModel.Processes
{
    public class TaskReader : Process
    {
        public String[] TaskSource { get; set; }
        SupervisorMemory supervisorMemory;

        public TaskReader(int priority, State state, Process parentProcess, string id)
            : base(priority, state, parentProcess, id)
        {
        }

        //public void BindSupervisorMemory(SupervisorMemory supMem)
       // {
           // supervisorMemory = supMem;
       // }

        private void ReadTask(string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    throw new FileNotFoundException("Task at" + path + "could not be found", path, null);
                }
                TaskSource = File.ReadAllLines(path);
            }
            catch (Exception)
            {
            }
        }

        private void LoadTaskIntoSupervisorMemory()
        {
            for (int i = 0; i < TaskSource.Length; i++)
            {
                supervisorMemory[i] = TaskSource[i];
            }
        }

        public bool GetTask()
        {
            try
            {
                TaskInput resource = (TaskInput) Core.ResourcesList.SingleOrDefault(r => r.Id == "TaskInput");
                resource.TaskPath = resource.Load();
                ReadTask(resource.TaskPath);
                if (resource.State == Resources.State.Free)
                {
                    resource.State = Resources.State.Occupied;
                    return true;
                }
                else
                {
                    resource.WaitingProcesses.Enqueue(this);
                    State = Processes.State.Blocked;
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override void Execute()
        {
            switch (Checkpoint)
            {
                case 1:
                    if (!GetTask())
                    {
                        break;
                    }
                    Checkpoint++;
                    goto case 2;
                case 2:
                    supervisorMemory = (SupervisorMemory) base.RequestResource("SupervisorMemory");
                    if (supervisorMemory == null)
                    {
                        break;
                    }
                    else
                    {
                        LoadTaskIntoSupervisorMemory();
                        supervisorMemory.Free();
                        supervisorMemory.Clear();
                        CreateResource(new TaskInSupervisorMemory(this, Resources.State.Free, "TaskInSupervisorMemory", TaskSource, new List<string> { "TaskParser" }));
                        State = Processes.State.Blocked;
                        break;
                    }
            }
        }
    }
}
