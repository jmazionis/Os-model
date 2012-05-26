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
        public SupervisorMemory SupervisorMemory { get; set; }

        public TaskReader(int priority, State state, Process parentProcess, string id, SupervisorMemory supervisorMemory)
            : base(priority, state, parentProcess, id)
        {
            SupervisorMemory = supervisorMemory;
        }

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
                SupervisorMemory[i] = TaskSource[i];
            }
        }

        public override bool RequestResource(string resourceName)
        {
            try
            {
                TaskInput resource = (TaskInput) Core.ResourcesList.SingleOrDefault(r => r.Id == resourceName);
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
                    if (!RequestResource("TaskInput"))
                    {
                        break;
                    }
                    Checkpoint++;
                    goto case 2;
                case 2:
                    if (!base.RequestResource("SupervisorMemory"))
                    {
                        break;
                    }
                    else
                    {
                        LoadTaskIntoSupervisorMemory();
                        SupervisorMemory.Free();
                        SupervisorMemory.Clear();
                        CreateResource(new TaskInSupervisorMemory(this, Resources.State.Free, "TaskInSupervisorMemory", TaskSource));
                        break;
                    }
            }
        }
    }
}
