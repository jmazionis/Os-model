using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsModel.Resources;

namespace OsModel.Processes
{
    public class TaskParser : Process
    {
        TaskInSupervisorMemory taskSource;

        public TaskParser(int priority, State state, Process parentProcess, string id)
            : base(priority, state, parentProcess, id)
        {
        }

        private bool Parse() //TODO: implement properly
        {                    //how to check: if taskSource[0] does not belong to virtual machine command set, return false
            //if (!blockTags.Contains(taskSource[0].Substring(0, 2)))
                //return false;
            //if (!taskSource.Memory.Contains("$END"))
                //return false;
            return true; //if no errors were found while parsing taskSource array, consisting of source code of a task, method must return true
        }

        public override void Execute()
        {
            switch (Checkpoint)
            {
                case 1:
                    taskSource = (TaskInSupervisorMemory) RequestResource("TaskInSupervisorMemory");
                    if (taskSource == null)
                    {
                        break;
                    }
                    Checkpoint++;
                    goto case 2;
                case 2:
                    if (!Parse())
                    {
                        break;
                    }
                    else
                    {
                        CreateResource(new Task(this, Resources.State.Free, "Task", taskSource, new List<string> { "Loader", "MainProc" } ));
                        break;
                    }
            }
        }

        private static List<string> blockTags = new List<string>()
        {
            "$000", "$010", "$020", "$030", "$040" 
        };
        /*private static List<string> commands = new List<string>()
        {
            "AD", "SU", "CM", "GD", "PD", "JM", 
            "JE", "JA", "JN", "JB", "JG", "JL", "SA",
            "SC", "LA", "LC", "$E"
        };*/
    }
}
