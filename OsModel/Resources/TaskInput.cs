using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsModel.Processes;

namespace OsModel.Resources
{
    public class TaskInput : Resource
    {
        public Queue<string> Tasks { get; set; }
        public string TaskPath { get; set; }

        public TaskInput(Process creator, State state, string id, Queue<string> taskList, List<string> processList)
            : base(creator, state, id, processList)
        {
            Tasks = taskList;
        }

        public void Add(string taskPath)
        {
            Tasks.Enqueue(taskPath);
        }

        public string Load()
        {
            return Tasks.Dequeue();
        }
    }
}
